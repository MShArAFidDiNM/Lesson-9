namespace thread
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            string path = Directory.GetCurrentDirectory()+"tekshiruvchi.txt";

            Thread threadYozuv = new Thread(() => FileYozish(path));
            Thread threadOqish = new Thread(() => FileOqish(path));
            threadYozuv.Start();
            threadOqish.Start(200);
        }
        public static void FileYozish(string path)
        {
            File.Create(path).Close();
            File.WriteAllText(path, "Men Keldim");
            Console.WriteLine("Yozildi");
        }
        public static void FileOqish(string path)
        {
            string read = File.ReadAllText(path);
            Console.WriteLine(read);
        }
    }
}