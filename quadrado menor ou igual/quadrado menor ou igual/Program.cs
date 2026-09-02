double num, cont = 0, quad;
Console.WriteLine("digite um numero:");
num=double.Parse(Console.ReadLine());

while(cont <= num)
{
    quad = Math.Pow(cont, 2);
    Console.WriteLine(cont + " Ao quadrado " + quad);
    cont++;
}

