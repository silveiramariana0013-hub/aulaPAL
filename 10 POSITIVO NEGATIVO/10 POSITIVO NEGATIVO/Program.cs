int qntpos=0, qntneg=0, num;
for (int i = 1; i <= 10; i++) 
{
    Console.WriteLine("digite um numero:");
    num=int.Parse(Console.ReadLine());
    if (num > 0)
    {
        qntpos++;
    }
    else if(num<0)
    {
        qntneg++;
    }
}
Console.WriteLine("quantidade positiva" + qntpos);
Console.WriteLine("quantidade negativa" + qntneg);