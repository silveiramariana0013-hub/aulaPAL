double n, soma=0;
for (int i = 1; i <=10; i++)
{
    Console.WriteLine("digite um numero:");
    n=double.Parse(Console.ReadLine());
    soma = n +soma ;
    Console.WriteLine("o total é:" + soma);
}

