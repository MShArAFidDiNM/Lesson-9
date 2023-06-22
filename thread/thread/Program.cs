namespace thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            double inputNumber = double.Parse(Console.ReadLine());
            Thread thread = new Thread(() => kopaytma(inputNumber));
            Thread thread1 = new Thread(() => yigindi(inputNumber));
            thread1.Start();
            thread.Start();

            Main(args);
        }
        static void kopaytma(double input)
        {
            double kopaytma = 1;
            for(double i = 1; i <= input; i++)
            {
                kopaytma*=i;
            }
            Console.WriteLine("Result Product : " + kopaytma);
        }  
        static void yigindi(double input)
        {
            double yigindi = 0;
            for(double i = 1; i <= input; i++)
            {
                yigindi+=i;
            }
            Console.WriteLine("Result Sum : " + yigindi);
        }

    }
}