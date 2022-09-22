class Program
{
    static void Main(string[] args)
    {
        for (int num = 100; num <= 999; num++)
        {
            int i = num % 10;  
            int j = (num / 10) % 10;  
            int k = num / 100;  
            if (i * i * i + j * j * j + k * k * k == num)
            {
                Console.WriteLine(num);
            }
        }
        Console.ReadKey();
    }
}