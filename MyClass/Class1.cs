using System;
namespace MyClass
{
    public class Class1
    {
        public int GetRandNum()
        {
            Random rnd = new Random();
            int value=rnd.Next(0,100);
            Console.WriteLine(value);
            return value;
        }
    }
}