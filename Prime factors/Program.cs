class Program
{
    static void Main(string[] args)
    {
        Console.Write("请输入一个正整数：");
        int num = Convert.ToInt32(Console.ReadLine());
        int temp = num;  
        string str = "分解质因数：" + num.ToString() + "=";
        for (int i = 2; i <= num; i++)
        {
            if (temp % i == 0)
            {
                temp = temp / i;
                
                str = str + i.ToString() + "*";  
                i--;  
            }

        }
        Console.WriteLine(str.Substring(0, str.Length - 1)); 
        Console.ReadKey();
    }
}
