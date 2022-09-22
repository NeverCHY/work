using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Test3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个0-100的整数成绩:");
            int intValue = Convert.ToInt32(Console.ReadLine());
            string strResult;
            switch (intValue / 10)
            {
                case 6:
                    strResult = "B"; break;
                case7:
                    strResult = "B"; break;
                case 8:
                    strResult = "B"; break;
                case 9:
                case 10:
                    strResult = "A"; break;
                default:
                    strResult = "C"; break;
            }
            Console.WriteLine(strResult);
            Console.ReadKey();
        }
    }
}
