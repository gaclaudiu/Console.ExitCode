using System;

namespace Console.ExitCode
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entered");

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
        }
    }
}