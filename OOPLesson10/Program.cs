using System;
using System.IO;
namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {

            // получаем текущий поток
            Thread currentThread = Thread.CurrentThread;

            //получаем имя потока
            Console.WriteLine($"Имя потока: {currentThread.Name}");
            currentThread.Name = "Метод Main";
            Console.WriteLine($"Имя потока: {currentThread.Name}");

            Console.WriteLine($"Запущен ли поток: {currentThread.IsAlive}");
            Console.WriteLine($"Id потока: {currentThread.ManagedThreadId}");
            Console.WriteLine($"Приоритет потока: {currentThread.Priority}");
            Console.WriteLine($"Статус потока: {currentThread.ThreadState}");
        }
    }
}