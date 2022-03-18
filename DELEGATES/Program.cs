namespace DELEGATES
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Downloader downloader = new();
            Display display = new();

            int answer = -1;

            while (true)
            {

                Console.WriteLine("Do you want to start download?" +
                    "\n1. Yes" +
                    "\n2. No (exit)");

                try
                {
                    answer = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    answer = -1;
                }

                switch (answer)
                {
                    case -1: 
                        Console.WriteLine("???");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 1:
                        InternetFile internetFile = new("Big File", random.Next(200, 600));

                        downloader.RegisterDelegate(Print);
                        display.RegisterDelegate(Print);
                        downloader.Start(internetFile);
                        break;
                    case 2: Environment.Exit(0);
                        break;
                }
            }
        }

        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}