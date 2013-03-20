// Type: System.IObservable`1
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

namespace System
{
    [__DynamicallyInvokable]
    public interface IObservable<out T>
    {
        [__DynamicallyInvokable]
        IDisposable Subscribe(IObserver<T> observer);
    }
}
