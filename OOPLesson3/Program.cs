using System;
namespace Polymorphism 
{
//----- Classic Polymorphism (UpCast) -----
    class BaseClass1
    {
        public int field1;
        public int field2;
        public int field3;
    }

    class DerivedClass1 : BaseClass1
    {
        public int field4;
        public int field5;
    }

//----- Classic Polymorphism (virtual/override) -----
    class BaseClass2
    {
        public virtual void Method()
        {
            Console.WriteLine("Method from BaseClass");
        }
    }
     
    class DerivedClass2 : BaseClass2
    {
        public override void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
//----- Classic Polymorphism (UpCast) -----
            
            DerivedClass1 instance1 = new DerivedClass1();


            instance1.field1 = 1;
            instance1.field2 = 2;
            instance1.field3 = 3;

            instance1.field4 = 4;
            instance1.field5 = 5;

            BaseClass1 newInstance = (BaseClass1)instance1;

            Console.WriteLine(newInstance.field1);
            Console.WriteLine(newInstance.field2);
            Console.WriteLine(newInstance.field3);

//----- Classic Polymorphism (virtual/override) -----

            DerivedClass2 instance2 = new DerivedClass2();
            instance2.Method();

            //UpCast
            BaseClass2 instance2Up = instance2;
            instance2Up.Method();

            //DownCast
            DerivedClass2 instanceDown = (DerivedClass2)instance2Up;
            instanceDown.Method();
        }
    }
}