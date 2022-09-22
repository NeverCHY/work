int n;
double l = 100;
double keep = 100;
double m = 50;
Console.WriteLine("请输入第n次落地时n的值：");
n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if (i > 1)
    {
        m = l / 2;
        l = m;
        keep += m;
    }
    else
    {
        keep = 100;
        m = 50;
    }
}
Console.WriteLine("第{0}次落地时，共经过{1}米，第{0}次反弹的高度为{2}米。", n, keep, m / 2);
Console.ReadKey();
