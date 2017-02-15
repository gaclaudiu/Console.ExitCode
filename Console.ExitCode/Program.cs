using Newtonsoft.Json;
using System;

namespace Console.ExitCode
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entered");

            System.Console.WriteLine("Paramas:");

            foreach (var item in args)
            {
                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine(item);
                System.Console.WriteLine("------------------------------");
            }

            int value = int.Parse(args[0]);

            switch (value)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Environment.Exit(1);
                    break;
            }

            System.Console.WriteLine("Leave");
            System.Console.ReadKey();
        }
    }

    internal class QueueWorkerConfig
    {
        public string IP { get; set; }

        public int MaxJobsToRun { get; set; }
    }
}