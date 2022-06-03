using System;
using System.Collections;
using System.Globalization;

namespace ZDRAFT1
    //Fancy example with Events
{
    public delegate void PressKeyEventHandler();
    public class Keybord
    {
        public event PressKeyEventHandler PressKeyA = null;
        public event PressKeyEventHandler PressKeyB = null;

        public void PressKeyAEvent()
        {
            if(PressKeyA != null)
            {
                PressKeyA.Invoke();
            }
        }

        public void PressKeyBEvent()
        {
            if(PressKeyB != null)
            {
                PressKeyB.Invoke();
            }
        }

        public void Start()
        {
            while (true)
            {
                string s = Console.ReadLine();

                switch (s)
                {
                    case "a":
                    case "A":
                        PressKeyAEvent();
                        break;
                    case "b":
                    case "B":
                        PressKeyBEvent();
                        break;
                    case "exit":
                        goto Exit;
                    default:
                        Console.WriteLine($"No handler for {s}");
                        break;
                }
            }
            Exit:
            Console.WriteLine("Exit!");
        }
    }
    class Program
    {
        static private void PressKeyA_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("    X    ");
            Console.WriteLine("   X X   ");
            Console.WriteLine("  X   X  ");
            Console.WriteLine(" XXXXXXX ");
            Console.WriteLine("X       X");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
        }

        static private void PressKeyB_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("XXXXX  ");
            Console.WriteLine("X    X ");
            Console.WriteLine("XXXXXX ");
            Console.WriteLine("X     X");
            Console.WriteLine("XXXXXX ");
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        public static void Main(string[] args)
        {
            Keybord keybord = new Keybord();

            keybord.PressKeyA += new PressKeyEventHandler(PressKeyA_Handler);
            keybord.PressKeyB += PressKeyB_Handler;

            keybord.Start();
        }
    }
}