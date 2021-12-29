using System;

namespace DelegatesPractice
{
    public delegate void MyDelegate(string msg); // declare a delegate
    class Program
    {
        static string Name = "Test";
        public static string NameMethod()
        {
            return Name;
        }

        public static string AddressMethod()
        {
            Name = "Address";
            return Name;
        }

        static void Main(string[] args)
        {
            MyDelegate del = Test.methodData;
            del("TestDel");
            MyDelegate del1 = Test1.methodData1;
            del1("");
            //Console.WriteLine("Hello World!" );
        }
    }

    class Test
    {
        public static void methodData(string msg)
        {
            Console.WriteLine("Test : ");
        }
    }

    class Test1
    {
        public static void methodData1(string msg)
        {
            Console.WriteLine("Test1 : ");
        }
    }
}
