
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入m:");
            int intValue1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入n:");
            int intValue2 = Convert.ToInt32(Console.ReadLine());
            int c, d,max,min,b;
            c = intValue1 % intValue2;
            b = intValue1 * intValue2;
            while (c != 0)
            {
            intValue1 = intValue2;
            intValue2 = c;
                c = intValue1 % intValue2;
            }
            max = intValue2;
            min = b / max;

        Console.WriteLine("最大公约数为"+max+"最小公倍数"+min);
            Console.ReadKey();
        }
    }


