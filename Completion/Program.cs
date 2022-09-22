using System;

namespace homework22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[2000];
            int[] a2 = new int[2000];
            int b = 0; int c = 0; int c2 = 0; int d = 0;
            Console.WriteLine("请输入一个整数：");
            try
            {
                c = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入格式不规范，请重新输入！");
                c = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i <= c; i++)
            {
                int n = 0;
                c2 = i;
                for (b = 1; b < i; b++)
                {
                    if (i % b == 0)
                    {
                        a[n] = b;
                        n++;
                        c2 = c2 - b;
                    }
                }
                if (c2 == 0)
                {
                    a2[d] = b;
                    d++;
                }
            }
            if (d == 0)
            {
                Console.WriteLine("未找到");
            }
            else
            {
                Console.WriteLine("找到" + d + "个完数，分别是：");
                for (int i = 0; i < d; i++)
                {
                    Console.Write(a2[i] + " ");
                }
            }


        }
    }
}
