
{
    int numeroDaTabuada, multiplicador;
    double resultado;

    Console.Write("Digite o número da tabuada que deseja calcular: ");
    numeroDaTabuada = int.Parse(Console.ReadLine());

    Console.WriteLine("Tabuada do {numeroDaTabuada}:");

    for (multiplicador = 1; multiplicador <= 10; multiplicador++)
    {
        resultado = Math.Pow(numeroDaTabuada, 1) * multiplicador;

        Console.WriteLine("{numeroDaTabuada} x {multiplicador} = {resultado}");
    }
}