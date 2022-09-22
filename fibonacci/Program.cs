class Program
{
    
    static void Main(string[] args)
    {
        int month = 0;  //定义月份
        Console.Write("输入月份：");  
        month = Convert.ToInt32(Console.ReadLine());  
        int temp1 = 1;  
        int temp2 = 1;  

        for (int i = 1; i <= month; i++)
        {
            if (i == 1)
            {
                
                Console.WriteLine("第" + i + "月兔子数量为：1");
            }
            else if (i == 2)
            {
                
                Console.WriteLine("第" + i + "月兔子数量为：1");
            }
            else
            {
                
                int total = 0;
                total = temp1 + temp2;
                temp1 = temp2;
                temp2 = total;
                Console.Write("第" + i + "月兔子数量为：");
                Console.WriteLine(total);
            }
        }
        Console.ReadKey();


    }
}
