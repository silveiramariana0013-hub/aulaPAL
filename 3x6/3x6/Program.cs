double cont = 1, valor, mult;

while(cont<=3)
{
    Console.WriteLine("digite um numero:");
    valor=double.Parse(Console.ReadLine());
    mult = valor * 6;
    cont++;
    Console.WriteLine(valor + "x 6=" + mult);
}
