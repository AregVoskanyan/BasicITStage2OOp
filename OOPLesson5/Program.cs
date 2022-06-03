using System;
using System.Text;
using System.Collections.Generic;  
namespace Generics
{
//--- Example 1 ---\\
    class MyClass<T>
    {
        public T field;

        public void Method()
        {
            Console.WriteLine(field.GetType());
        }
    }

//--- Example 2 ---\\

    class MyGenerics<TYPE1, TYPE2>
    {
        private TYPE1 variable1;
        private TYPE2 variable2;

        public MyGenerics(TYPE1 argument1, TYPE2 argument2)
        {
            this.variable1 = argument1;
            this.variable2 = argument2;
        }

        public TYPE1 Variable1
        {
            get { return this.variable1; }
            set { this.variable1 = value; }
        }
        public TYPE2 Variable2
        {
            get { return this.variable2; }
            set { this.variable2 = value; }
        }
    }

//--- Example 3 ---\\

    class OtherClass
    {
        public void Method<T>(T argument)
        {
            T variable = argument;
            Console.WriteLine(variable);
        }
    }

//--- Generics Restriction With Interfaces ---\\

    interface IInterface { }
    interface IInterface<U> { }

    class Derived : IInterface, IInterface<object> { }
    class MyClass1<T> where T : IInterface, IInterface<object> { }
    class MyClass2<T> where T : IInterface { }
    class MyClass3<T> where T : IInterface<object> { }

//--- Generics Restriction With Classes ---\\
    class MyClassX<T> where T : new()
    {
        public T instanceX = new T();

        public void Getvalues()
        {
            Console.WriteLine(instanceX.ToString());
        }
    }

    class TestClass : Object
    {
        public int MyIntProperty { get; set; }
        public string MyStringProperty { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", MyIntProperty, MyStringProperty);
        }
    }

//--- Example 4 ---\\

    class Animal { }
    class Cat : Animal { }
    class Dog : Animal { }

    class Program
    {
//--- Covarianty ---\\

        delegate T MyDelegate1<out T>();
        public static Cat CatCreator()
        {
            return new Cat();
        }

//--- Contrvarianty ---\\

        delegate void Mydelegate2<in T>(T a);
        public static void DogUser(Animal animal)
        {
            Console.WriteLine(animal.GetType().Name);
        }



//--- Example 1 ---\\

        static void Main(string[] args)
        {
            MyClass<int> instance1 = new MyClass<int>();
            instance1.Method();

            MyClass<long> instance2 = new MyClass<long>();
            instance2.Method();

            MyClass<string> instance3 = new MyClass<string>();
            instance3.field = "Hello World!";
            instance3.Method();

//--- Example 2 ---\\

            MyGenerics<int, int> inst1 = new MyGenerics<int, int>(1, 2);
            Console.WriteLine(inst1.Variable1 + inst1.Variable2);

            MyGenerics<string, int> inst2 = new MyGenerics<string, int>("Number", 1);
            Console.WriteLine(inst2.Variable1 + inst2.Variable2);

            MyGenerics<string, string> inst3 = new MyGenerics<string, string>("Hello ", "World!");
            Console.WriteLine(inst3.Variable1 + inst3.Variable2);

//--- Example 3 ---\\

            OtherClass instancee = new OtherClass();
            instancee.Method(365);
            instancee.Method("Hello World!");

//--- With Classes ---\\
            MyClassX<TestClass> foo = new MyClassX<TestClass>();
            foo.instanceX.MyIntProperty = 1;
            foo.instanceX.MyStringProperty = "Hello World!";
            foo.Getvalues();

//--- With Interfaces ---\\                                                            // Lines 53 - 61 are possibale casting ways

            MyClass1<Derived> my1 = new MyClass1<Derived>();


            MyClass2<IInterface> my2 = new MyClass2<IInterface>();
            MyClass2<Derived> my3 = new MyClass2<Derived>();

            MyClass3<IInterface<object>> my4 = new MyClass3<IInterface<object>>();
            MyClass3<Derived> my5 = new MyClass3<Derived>();

//--- Example 4 ---\\

//--- Covarianty ---\\

            MyDelegate1<Cat> delegateCat = new MyDelegate1<Cat>(CatCreator);
            MyDelegate1<Animal> delegateAnimal1 = delegateCat;

            Animal animal = delegateAnimal1.Invoke();
            Console.WriteLine(animal.GetType().Name);

//--- Contrvarianty ---\\

            Mydelegate2<Animal> delegateAnimal2 = new Mydelegate2<Animal>(DogUser);
            Mydelegate2<Dog> delegateDog = delegateAnimal2;

            delegateAnimal2(new Animal());
            delegateDog(new Dog());
        }
    }
}
