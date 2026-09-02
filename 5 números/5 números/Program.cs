int num, soma=0, cont = 0;

while(cont<5)
{
    Console.WriteLine("digite um numero:");
    num=int.Parse(Console.ReadLine());
    soma = soma + num;
    cont++;
}
Console.WriteLine("o resultado final é:" +soma );