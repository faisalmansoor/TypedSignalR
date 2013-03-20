using System;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace TypedSignalR
{
    public class ClientProxyInterceptor : IInterceptor
    {
        private readonly Func<IClientProxy> _clientProxyGetter;
        public ClientProxyInterceptor(Func<IClientProxy> clientProxyGetter)
        {
            _clientProxyGetter = clientProxyGetter;
        }

        #region Implementation of IInterceptor

        public void Intercept(IInvocation invocation)
        {
            IClientProxy proxy = _clientProxyGetter();
            Task task = proxy.Invoke(invocation.Method.Name, invocation.Arguments);
            task.Wait();
        }
        #endregion
    }

    public static class HubExtensions
    {
        public static TProxy CallerAs<TProxy>(this Hub hub)
        {
            return CreateProxy<TProxy>(() => hub.Clients.Caller);
        }

        public static TProxy ClientsAs<THub, TProxy>() where THub : IHub
        {
            return CreateProxy<TProxy>(() => GlobalHost.ConnectionManager.GetHubContext<THub>().Clients.All);
        }

        private static TProxy CreateProxy<TProxy>(Func<IClientProxy> clientProxyGetter)
        {
            var interceptor = new ClientProxyInterceptor(clientProxyGetter);
            var generator = new ProxyGenerator();
            var proxy = generator.CreateInterfaceProxyWithoutTarget(typeof(TProxy), interceptor);
            return (TProxy)proxy;
        }
    }
}
