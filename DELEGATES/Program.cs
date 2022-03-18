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

/*namespace learn_anything_c_sharp
{
    internal class Program
    {
        delegate int Operation(int value, int value2);

        static void Main(string[] args)
        {
            Account account = new(200);

            account.RegisterDelegate(Print);
            account.Take(20);
            account.Add(50);
        }

        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}

namespace learn_anything_c_sharp
{
    public delegate void AccountHandler(string msg);

    internal class Account
    {
        public Account(int sum) => Sum = sum;

        private int Sum { get; set; }
        private AccountHandler? accHand;

        public void RegisterDelegate(AccountHandler dlgt)
        {
            accHand = dlgt;
        }

        public void Add(int value)
        {
            Sum += value;
            accHand?.Invoke($"Зачислено {value}. На счету {Sum}");
        }
        public void Take(int value)
        {
            if (Sum >= value)
            {
                Sum -= value;
                accHand?.Invoke($"Списано {value}. Осталось {Sum}");
            }
            else
            {
                accHand?.Invoke($"Недостаточно средств");
            }
        }
    }
}*/