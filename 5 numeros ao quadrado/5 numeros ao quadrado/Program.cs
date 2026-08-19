{
    int i;
    double numero, quadrado;

    for (i = 1; i <= 5; i++)
    {
        Console.Write("Digite o " + i + "º número: ");
        numero = double.Parse(Console.ReadLine());

        quadrado = Math.Pow(numero, 2);

        Console.WriteLine("O quadrado de " + numero + " é " + quadrado);
        Console.WriteLine();
    }
}


