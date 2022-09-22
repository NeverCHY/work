class Program
{
    //
    static void Main(string[] args)
    {
        bool yes = false;
        Console.Write("输入需要计算素数的范围：");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 101; i <= num; i++)
        {
            

            for (int j = 2; j < i; j++)
            {
                

                if (i % j == 0)
                {
                    
                    yes = true;
                    break;
                }
            }
            if (yes == false)
            {
                
                Console.WriteLine(i);

            }
            yes = false;
        }
        Console.ReadKey();
    }
}
