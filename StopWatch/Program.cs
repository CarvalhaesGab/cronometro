using System;
using System.Threading;

namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Seconds => 10s = 10 Seconds.");
            Console.WriteLine("Minuts => 1m = 1 Minute.");
            Console.WriteLine("Exit => 0s");
            Console.WriteLine("how long do you want to time? Example: 1m or 10s");


            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;


            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);


            Console.ReadKey();
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.Write("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO!");
            Thread.Sleep(1200);

            Start(time);

        }

        static void Start(int Time)
        {

            int CurrentTime = 0;

            while (CurrentTime != Time)
            {
                Console.Clear();
                CurrentTime++;
                Console.WriteLine(CurrentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWatch finished!");
            Thread.Sleep(2500);
            Menu();

        }

    }
}