double valor, mult, cont = 1;
while(cont<=3)
{
    Console.WriteLine("digite um numero:");
    valor=double.Parse(Console.ReadLine());
    mult = valor * 7;
    cont++;
    Console.WriteLine(valor + "x7=" + mult);

}
