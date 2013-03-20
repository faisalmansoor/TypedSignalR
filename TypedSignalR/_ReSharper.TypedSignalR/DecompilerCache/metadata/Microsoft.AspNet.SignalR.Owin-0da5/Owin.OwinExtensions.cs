// Type: Owin.OwinExtensions
// Assembly: Microsoft.AspNet.SignalR.Owin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Users\faisal.mansoor\Documents\Visual Studio 2010\Projects\TypedSignalR\Resources\Microsoft.AspNet.SignalR.Owin.dll

using Microsoft.AspNet.SignalR;
using System;

namespace Owin
{
    public static class OwinExtensions
    {
        public static IAppBuilder MapHubs(this IAppBuilder builder);
        public static IAppBuilder MapHubs(this IAppBuilder builder, HubConfiguration configuration);
        public static IAppBuilder MapHubs(this IAppBuilder builder, string path, HubConfiguration configuration);
        public static IAppBuilder MapConnection<T>(this IAppBuilder builder, string url) where T : PersistentConnection;

        public static IAppBuilder MapConnection<T>(this IAppBuilder builder, string url,
                                                   ConnectionConfiguration configuration) where T : PersistentConnection;

        public static IAppBuilder MapConnection(this IAppBuilder builder, string url, Type connectionType,
                                                ConnectionConfiguration configuration);

        private static IAppBuilder UseType<T>(this IAppBuilder builder, params object[] args);
    }
}
