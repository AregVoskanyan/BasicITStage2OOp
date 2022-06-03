using System;

namespace Inheritance
{
    public class A
    {
        public string Name;
        public void GetName()
        {
            Console.WriteLine("Name: {0}", Name);
        }
    }
    public class B : A
    {
        public string Location;
        public void GetLocation()
        {
            Console.WriteLine("Location: {0}", Location);
        }
    }
    public class C : B
    {
        public int Age;
        public void GetAge()
        {
            Console.WriteLine("Age: {0}", Age);
        }
    }

//------------- Cars --------------\\
    public class Car //Base class
    {
        public int Price;
        public void GetPrice()
        {
            Console.WriteLine("Price: {0}", Price + "$");
        }

        public string Type;
        public void GetType()
        {
            Console.WriteLine("Type: {0}", Type);
        }


    }

    public class BMW : Car
    {
        public string ProducingCountry;
        public void GetProducingCountry()
        {
            Console.WriteLine("Producing Country: {0}", ProducingCountry);
        }
    }

    public class Series4 : BMW
    {
        public int HorsePower;
        public void GetHorsePower()
        {
            Console.WriteLine("Horsepower: {0}", HorsePower + "HP");
        }

        public string Type;
        public void GetType()
        {
            Console.WriteLine("Type: {0}", Type);
        }
    }
    public class SeriesX6 : BMW
    {
        public int HorsePower;

        public void GetHorsePower()
        {
            Console.WriteLine("Horsepower: {0}", HorsePower + "HP");
        }

        public string Type;
        public void GetType()
        {
            Console.WriteLine("Type: {0}", Type);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.Name = "Hayk";
            c.Location = "Haykyan";
            c.Age = 25;
            c.GetName();
            c.GetLocation();
            c.GetAge();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();

//----------- Cars -----------\\

            Console.WriteLine("Series4 Characteristics\n");
            Series4 series4 = new Series4();
            series4.Price = 63700;
            series4.Type = "Sedan";
            series4.ProducingCountry = "Germany";
            series4.HorsePower = 342;
            series4.GetPrice();
            series4.GetType();
            series4.GetProducingCountry();
            series4.GetHorsePower();

            Console.WriteLine("\n");

            Console.WriteLine("SeriesX6 Characteristics\n");
            SeriesX6 seriesx6 = new SeriesX6();
            seriesx6.Price = 77900;
            seriesx6.Type = "SUV Coupe";
            seriesx6.ProducingCountry = "Germany";
            seriesx6.HorsePower = 720;
            seriesx6.GetPrice();
            seriesx6.GetType();
            seriesx6.GetProducingCountry();
            seriesx6.GetHorsePower();
        }
    }
}