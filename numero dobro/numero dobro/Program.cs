double num, cont = 1, resu=0;

Console.WriteLine("digite um numero");
num = double.Parse(Console.ReadLine());
while (cont < num)
{
    resu = cont * 2;
    cont++;
    Console.WriteLine("o resultado é:" + resu);
}
