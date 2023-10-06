using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite outro numero: ");
        double2 num2 = Convert.ToDouble(Console.ReadLine());

        double  resultado = num1 * num2;

        Console.WriteLine($"O resultado da multiplicação é :  { resultado}");

        Console.ReadKey();

        Console.WriteLine("HelLO Word!");
    }
}