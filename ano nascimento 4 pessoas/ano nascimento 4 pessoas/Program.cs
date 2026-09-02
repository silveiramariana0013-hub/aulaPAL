double anonas, anoatu, idade, cont = 1;

while(cont<=4)
{
    Console.WriteLine("digite o ano atual:");
    anoatu=double.Parse(Console.ReadLine());
    Console.WriteLine("digite sua data de nascimento:");
    anonas=double.Parse(Console.ReadLine());
    idade = anoatu - anonas;
    Console.WriteLine("a sua idade é:  " + idade);
    cont++;
}