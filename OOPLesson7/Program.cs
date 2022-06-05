using System;
namespace Excepitons
{
    class Program
    {
        static void Main(string[] args)
        {
            //example 1
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Result: {y}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: DivideByZeroException");
            }

            //example 2
            int a = 1;
            int b = 0;

            try
            {
                int result1 = a / b;
                int result2 = b / a;
            }
            catch (DivideByZeroException) when (b == 0)
            {
                Console.WriteLine(" y must not be equal 0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //example 3
            try
            {
                Console.Write("Anter your name: ");
                string? name = Console.ReadLine();
                if (name == null || name.Length < 3)
                {
                    throw new Exception("Name must be more than 2 sombols");
                }
                else
                {
                    Console.WriteLine($"Enter your name: {name}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            //example 4
            try
            {
                try
                {
                    Console.Write("Enter your name: ");
                    string? name = Console.ReadLine();
                    if (name == null || name.Length < 3)
                    {
                        throw new Exception("Name must be more than 2 symbols");
                    }
                    else
                    {
                        Console.WriteLine($"Your name: {name}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}