namespace thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int input = int. Parse(Console.ReadLine());

            Thread threadjuft = new Thread(() => juft(input));
            Thread threadtub = new Thread(() => tub(input));

            threadjuft.Start();
            threadtub.Start();
        }
        public static void juft (int input )
        {
            for (int i = 2; i < input; i+=2)
            {
                Console.WriteLine("Juft : " + i);
            }
        }
        public static void tub (int input)
        {
            for (int i = 1;  i < input; i++)
            {
                int count = 0;
                for (int j = 1; j < input; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("Tub Son : " + i);
                }
            }
        }
    }
}