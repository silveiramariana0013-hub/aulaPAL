int qnt = 0,num;

for (int i = 1; i <= 15; i++)
{
    Console.Write("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.WriteLine("Número par: " + num);
        qnt++;
    }
    { 

Console.WriteLine("Quantidade de números pares: " + qnt);
    }
}
