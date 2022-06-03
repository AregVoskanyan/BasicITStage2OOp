using System;
using System.Collections;
using System.Globalization;

namespace Events
{
    public delegate void EventDelegate();

    public class MyClass
    {
        public event EventDelegate MyEvent = null;

        public void InvokeEvent()
        {

            MyEvent.Invoke();
        }
    }
    class Program
    {
        static private void Handler1()
        {
            Console.WriteLine("Handler 1");
        }

        static private void Handler2()
        {
            Console.WriteLine("Handler 2");
        }
        public static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            instance.MyEvent += new EventDelegate(Handler1);
            instance.MyEvent += Handler2;

            instance.InvokeEvent();

            Console.WriteLine(new String('-', 20));

            instance.MyEvent -= new EventDelegate(Handler2);

            instance.InvokeEvent();
        }
    }
}