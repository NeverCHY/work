using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day020_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int count = 0;
            for (int i = 1; i <= 4; i++) 
            {
                int bw = i;
                for (int j = 1; j <= 4; j++)
                {
                    int sw = j;
                    if (bw != sw)
                    {
                        for (int k = 1; k <= 4; k++)
                        {
                            int gw = k;
                            if (gw != bw && gw != sw)
                            {
                                count++;
                                Console.WriteLine("{0}{1}{2}", bw, sw, gw);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("一共有：" + count + "个");
            Console.Read();
        }
    }
}
