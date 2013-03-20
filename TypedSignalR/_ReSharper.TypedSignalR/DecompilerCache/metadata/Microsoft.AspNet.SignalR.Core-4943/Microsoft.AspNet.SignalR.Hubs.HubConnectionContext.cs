// Type: Microsoft.AspNet.SignalR.Hubs.HubConnectionContext
// Assembly: Microsoft.AspNet.SignalR.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Users\faisal.mansoor\Documents\Visual Studio 2010\Projects\TypedSignalR\TypedSignalR\Resources\Microsoft.AspNet.SignalR.Core.dll

using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.AspNet.SignalR.Hubs
{
    public class HubConnectionContext : IHubConnectionContext
    {
        private readonly string _connectionId;
        private readonly string _hubName;
        private readonly Func<string, ClientHubInvocation, IEnumerable<string>, Task> _send;
        public HubConnectionContext();

        public HubConnectionContext(IHubPipelineInvoker pipelineInvoker, IConnection connection, string hubName,
                                    string connectionId, StateChangeTracker tracker);

        public dynamic Others { get; set; }
        public dynamic Caller { get; set; }

        #region IHubConnectionContext Members

        public dynamic AllExcept(params string[] exclude);
        public dynamic Group(string groupName, params string[] exclude);
        public dynamic Client(string connectionId);
        public dynamic All { get; set; }

        #endregion

        public dynamic OthersInGroup(string groupName);
    }
}
