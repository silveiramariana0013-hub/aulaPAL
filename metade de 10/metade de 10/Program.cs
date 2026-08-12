double num, met;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("digite um numero:");
    num=double.Parse(Console.ReadLine());
    met = num / 2;
    Console.WriteLine("a metade é:" + met);
}
