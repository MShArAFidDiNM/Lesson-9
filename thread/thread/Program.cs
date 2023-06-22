using System.Runtime.CompilerServices;

namespace thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            int input = int.Parse(Console.ReadLine());

            Thread thread = new Thread (() => Wright(input));
            thread.Start();
        }
        public static void Wright(int input)
        {
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("Thread Name : " + i);
            }
        }
    }
}