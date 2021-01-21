using System;
using System.Threading;

namespace Console_App
{
    class Program
    {
        private static void PrintWelcomeText()
        {
            string text = "Basic Command Line Interface [version 1.0.0]\n(c) 2021 ZiGMA Technologies";
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Green;
            using(var progress = new ProgressBar())
            {
                for(int i = 0; i <= 100; i++)
                {
                    progress.Report((double)i / 100);
                    Thread.Sleep(20);
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void Initialize()
        {
            PrintWelcomeText();
            string command = "";
            bool quit = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"/ ZiGMA: ");
                Console.ForegroundColor = ConsoleColor.White;
                command = Console.ReadLine();
                if(command.Equals("quit"))
                {
                    quit = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Quiting console...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                    quit = false;
            } while (!quit);
        }

        static void Main(string[] args)
        {
            Initialize();
        }
    }
}
