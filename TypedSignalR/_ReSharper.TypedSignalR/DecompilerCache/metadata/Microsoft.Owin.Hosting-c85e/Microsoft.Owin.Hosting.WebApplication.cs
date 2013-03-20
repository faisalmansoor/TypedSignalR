// Type: Microsoft.Owin.Hosting.WebApplication
// Assembly: Microsoft.Owin.Hosting, Version=0.18.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Users\faisal.mansoor\Documents\Visual Studio 2010\Projects\TypedSignalR\Resources\Microsoft.Owin.Hosting.dll

using System;

namespace Microsoft.Owin.Hosting
{
    public static class WebApplication
    {
        public static IDisposable Start<TStartup>(string url = null, string server = null, string scheme = null,
                                                  string host = null, int? port = null, string path = null,
                                                  string boot = null, string outputFile = null, int verbosity = 0);

        public static IDisposable Start(string app = null, string url = null, string server = null, string scheme = null,
                                        string host = null, int? port = null, string path = null, string boot = null,
                                        string outputFile = null, int verbosity = 0);

        public static IDisposable Start(StartParameters parameters);
    }
}
