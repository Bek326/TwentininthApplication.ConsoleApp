using System;

namespace TwentininthApplication.ConsoleApp
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            var worker1 = new Worker1(Logger);
            worker1.Work();
            Console.ReadKey();
        }

    }

    public interface ILogger
    {
        void Event();
    }
    public class Logger : ILogger
    {
        public void Event()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                int num1 = 0;
                int num2 = 0;
                Console.WriteLine("Введите первое значние:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе значние:");
                num2 = Convert.ToInt32(Console.ReadLine());
                int result = num1 + num2;
                Console.WriteLine($"\n{result}");
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
        }
    }
    public interface IWorker
    {
        void Work();
    }
}
