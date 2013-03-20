using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Client.Hubs;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace TypedSignalR
{
    public class HubProxyInterceptor : IInterceptor
    {
        private readonly IHubProxy _proxy;
        private readonly HubConnection _connection;
        private readonly Dictionary<Type, List<object>> _subscribers = new Dictionary<Type, List<object>>();
        private readonly List<IObservable<JToken[]>> _observables = new List<IObservable<JToken[]>>();

        public HubProxyInterceptor(HubConnection connection, IHubProxy proxy)
        {
            _proxy = proxy;
            _connection = connection;
        }

        #region Implementation of IInterceptor

        public void Intercept(IInvocation invocation)
        {
            if (invocation.Method.DeclaringType == typeof(IDualProxy))
            {
                object target = invocation.GetArgumentValue(0);
                Type targetType = invocation.GenericArguments[0];

                List<object> targets;
                if (!_subscribers.TryGetValue(targetType, out targets))
                {
                    targets = new List<object>();
                    _subscribers.Add(targetType, targets);
                }

                if (!targets.Contains(target))
                {
                    foreach (MethodInfo method in targetType.GetMethods())
                    {
                        IObservable<JToken[]> observable = _proxy.Observe(method.Name);
                        MethodInfo methodTemp = method;
                        observable.Subscribe(args => InvokeCallback(targetType, target, methodTemp, args));
                        _observables.Add(observable);
                    }
                    targets.Add(targets);
                }
                return;
            }

            if (_connection.State != ConnectionState.Connected)
            {
                _connection.Start().Wait();
            }

            bool hasResults = invocation.Method.ReturnType != typeof(void);

            if (hasResults)
            {
                Task<object> task = _proxy.Invoke<object>(invocation.Method.Name, invocation.Arguments);
                object result = JsonConvert.DeserializeObject(task.Result.ToString(), invocation.Method.ReturnType);
                invocation.ReturnValue = Convert.ChangeType(result, invocation.Method.ReturnType);
            }
            else
            {
                Task task = _proxy.Invoke<object>(invocation.Method.Name, invocation.Arguments);
                task.Wait();
            }
        }

        #endregion

        private void InvokeCallback(Type targetType, object target, MethodInfo method, IEnumerable<JToken> args)
        {
            try
            {
                Console.WriteLine("Invoking {0}.{1}", targetType.Name, method.Name);

                ParameterInfo[] parameters = targetType.GetMethod(method.Name).GetParameters();

                object[] values = parameters
                    .Zip(args, (parameter, arg) => JTokenToObject(arg, parameter))
                    .ToArray();
                
                targetType.GetMethod(method.Name).Invoke(target, values);
            }
            catch (Exception ex)
            {
                String msg = Util.FormatNamed(
                    "Failed to call {Method} on target type {TargetType}.",
                    new
                    {
                        Method = method.Name,
                        TargetType = targetType.ToString()
                    });

                Console.WriteLine(msg, ex);
            }
        }

        private object JTokenToObject(JToken obj, ParameterInfo paramInfo)
        {
            try
            {
                string json = obj.CreateReader().ReadAsString();

                object value = JsonConvert.DeserializeObject(String.Format("\"{0}\"", json), paramInfo.ParameterType);
                return value;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(
                    Util.FormatNamed(
                        "Failed to deserialize argument {ArgName}, expected type {ParameterType}, actual type {ArgType}, actual value = {ArgValue}",
                        new
                            {
                                paramInfo.Name,
                                paramInfo.ParameterType,
                                ArgType = obj.Type,
                                ArgValue = obj.ToString()
                            }), ex);
            }
        }
    }



    public class TypedHubConnection : HubConnection
    {
        public TypedHubConnection(string url)
            : base(url)
        {
        }

        public T CreateProxy<T>(string hubName) where T : class
        {
            var interceptor = new HubProxyInterceptor(this, base.CreateHubProxy(hubName));

            var generator = new ProxyGenerator();

            var proxy = generator.CreateInterfaceProxyWithoutTarget(typeof(T), new[] { typeof(IDualProxy) }, interceptor);
            return (T)proxy;
        }
    }

    public interface IDualProxy
    {
        void Subscribe<T>(T target);
    }
}
