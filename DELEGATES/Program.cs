namespace DELEGATES
{
    class Program
    {
        static void Main(string[] args)
        {
            Downloader downloader = new();
            Display display = new();
            InternetFile internetFile = new("Big File", 500);

            
            downloader.RegisterDelegate(Print);
            downloader.Start(internetFile);
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