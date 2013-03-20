using System.Collections.Generic;

namespace Test
{
    public interface IMathService
    {
        int Add(int num1, int num2);
        List<int> ListPrimes(int num);
    }

    public interface IClientCallback
    {
        void Notify(string msg);
    }
}
