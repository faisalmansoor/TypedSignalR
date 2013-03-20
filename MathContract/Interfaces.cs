using System.Collections.Generic;

namespace MathContract
{
    public interface IMathService
    {
        int Add(int num1, int num2);
        List<int> ListPrimes(int num);
        void NotifyClient(string id);
    }

    public interface ITestService
    {
        void TestInt(int num1, int num2);
        void TestDouble(double num1, double num2);
        void TestString(string str1, string str2);
    }

    public interface IClientCallback
    {
        void Notify(string msg);
    }
}
