using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClass;
using System;
using System.Diagnostics;

namespace TestProject2

{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Even()
        {
            Class1 c = new Class1();
            int value = c.GetRandNum();
            try
            {
                Assert.IsTrue(IsEven(value));
                Console.WriteLine("������");
            }
            catch {
                Console.WriteLine("�� ������");
            }
            static bool IsEven(int number)
            {
                return number % 2 == 0;
            }
        }
    }
}