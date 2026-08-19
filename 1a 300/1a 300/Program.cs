double resto;
int qnt = 0,num;
for(int i=1;i<=300;i++)
{
    resto = i % 3;
    if (resto == 0)
    {
        Console.WriteLine(i + "é multiplo de 3");
    }
    else if(resto>0)
    {
        Console.WriteLine(i + "não é multiplo de 3");
    }
}