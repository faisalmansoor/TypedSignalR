// Type: Microsoft.AspNet.SignalR.IHubContext
// Assembly: Microsoft.AspNet.SignalR.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Users\faisal.mansoor\Documents\Visual Studio 2010\Projects\TypedSignalR\TypedSignalR\Resources\Microsoft.AspNet.SignalR.Core.dll

using Microsoft.AspNet.SignalR.Hubs;

namespace Microsoft.AspNet.SignalR
{
    public interface IHubContext
    {
        IHubConnectionContext Clients { get; }
        IGroupManager Groups { get; }
    }
}
