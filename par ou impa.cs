Console.WriteLine("digite um numero para saber se ele é divisivel por 2");
int numero = 1;
numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("par");
}
else
{
    Console.WriteLine("impa");
}