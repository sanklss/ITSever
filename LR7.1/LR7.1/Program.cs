namespace LR7._1
{
    internal  class Program
    {
        public static  async Task Read()
        {
            string path = @"C:/Users/Григорий/Desktop/txt.txt";
            await Task.Run(() =>
            {
                using StreamReader reader = new StreamReader(path);
                {
                    string s;
                    string lines;
                    while ((lines = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(lines);
                        Thread.Sleep(300);
                    }
                }
            });
        }
    }
    public class Main1
    {
        public static void Main()
        {
            Program.Read();
            Console.ReadLine();
        }
    }
}
