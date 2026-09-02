int cont = 1, anonas, anoatu, sub;

    Console.WriteLine("digite o ano atual");
anoatu = int.Parse(Console.ReadLine());

while(cont<=5)
{
    Console.WriteLine("digite o ano que voce nasceu:");
    anonas=int.Parse (Console.ReadLine());

    sub = anoatu - anonas;
    Console.WriteLine("voce nasceu no ano " + anonas + "voce tem" + sub + "anos");
    cont++;
}