using System;
namespace Abstraction
{
    //Interface--------------
    interface IMovable
    {
        void Move()
        {
            Console.WriteLine("Walking");
        }
    }
    class Person : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Human walks");
        }
    }

    class Automobile : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is driven");
        }
    }
    //Abstraction--------------

    abstract class Shape
    {
        public abstract double GetPerimeter();
        public abstract double GetArea();
    }

    class Rectangle : Shape
    {
        public float Width { get; set; }
        public float Length { get; set; }

        public override double GetPerimeter() => Width * 2 + Length * 2;
        public override double GetArea() => Width * Length;
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetPerimeter() => Radius * 2 * 3.14;
        public override double GetArea() => Radius * Radius * 3.14;
    }

    //---------------------------------

    abstract class Transport
    {
        public void Move()
        {
            Console.WriteLine("Trasnport is moving");
        }
    }
    class Ship : Transport { }
    class Aircraft : Transport { }
    class Car : Transport { }

    //----------------------------------

    abstract class AbstractClass
    {
        public AbstractClass()
        {
            Console.WriteLine("1 AbstractClass()");
            this.AbstrcatMethod();
            Console.WriteLine("2 AbstractClass()");
        }
        public abstract void AbstrcatMethod();
    }

    class ConcreteClass : AbstractClass
    {
        string s = "FIRST";
        public ConcreteClass()
        {
            Console.WriteLine("3 ConcreteClass()");
            s = "SECOND";
        }
        public override void AbstrcatMethod()
        {
            Console.WriteLine("Realization of AbstractMethod() in ConcreteClass {0}", s);
        }
    }
    class Program
    {
        public static void DoAction(IMovable movable)
        {
            movable.Move();
        }
        static void Main(string[] args)
        {
            //Interface--------------
            Person areg = new Person();
            Automobile zap = new Automobile();
            //default realization
            areg.Move();
            zap.Move();
            //Realization with method
            DoAction(areg);
            DoAction(zap);

            //Abstraction--------------

            var rectangle = new Rectangle { Width = 10, Length = 20 };
            var circle = new Circle { Radius = 3 };

            void PrintShape(Shape shape)
            {
                Console.WriteLine($"Perimeter: {shape.GetPerimeter()}cm  Area: {shape.GetArea()}cm^2");
            }

            PrintShape(rectangle);
            PrintShape(circle);

            //-------------------------

            Transport car = new Car();
            Transport ship = new Ship();
            Transport aircraft = new Aircraft();

            car.Move();
            ship.Move();
            aircraft.Move();

            //--------------------------

            AbstractClass instance = new ConcreteClass();
            Console.WriteLine(new string('-', 55));
            instance.AbstrcatMethod();

            Console.ReadKey();
        }
    }
}