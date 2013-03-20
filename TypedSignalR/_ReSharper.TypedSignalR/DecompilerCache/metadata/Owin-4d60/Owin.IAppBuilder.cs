// Type: Owin.IAppBuilder
// Assembly: Owin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f0ebd12fd5e55cc5
// Assembly location: C:\Users\faisal.mansoor\Documents\Visual Studio 2010\Projects\TypedSignalR\Resources\Owin.dll

using System;
using System.Collections.Generic;

namespace Owin
{
    public interface IAppBuilder
    {
        IDictionary<string, object> Properties { get; }
        IAppBuilder Use(object middleware, params object[] args);
        object Build(Type returnType);
        IAppBuilder New();
    }
}
