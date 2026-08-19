int num;
for(int i = 1;i<=10;i++)
{
    Console.WriteLine("digite um numero:");
    num=int.Parse(Console.ReadLine());
    if(num %4==0)
    {
        Console.WriteLine("e multiplo de 4:" + num);
    }
}
