using System;
namespace Encapsulation
{
    class MyClass
    {
        private string field = null;

        public string Field { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.Field = "Hello World!";
            Console.WriteLine(instance.Field);
        }
    }
}