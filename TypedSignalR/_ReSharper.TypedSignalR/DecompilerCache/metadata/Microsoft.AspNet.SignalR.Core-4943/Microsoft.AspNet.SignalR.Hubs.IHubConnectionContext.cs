// Type: Microsoft.AspNet.SignalR.Hubs.IHubConnectionContext
// Assembly: Microsoft.AspNet.SignalR.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Users\faisal.mansoor\Documents\Visual Studio 2010\Projects\TypedSignalR\TypedSignalR\Resources\Microsoft.AspNet.SignalR.Core.dll

namespace Microsoft.AspNet.SignalR.Hubs
{
    public interface IHubConnectionContext
    {
        dynamic All { get; }
        dynamic AllExcept(params string[] exclude);
        dynamic Client(string connectionId);
        dynamic Group(string groupName, params string[] exclude);
    }
}
