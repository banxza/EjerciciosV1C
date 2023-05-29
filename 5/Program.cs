using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());

        double perimetro = 2 * Math.PI * radio;
        double area = Math.PI * Math.Pow(radio, 2);

        Console.WriteLine("El perímetro del círculo es: " + perimetro);
        Console.WriteLine("El área del círculo es: " + area);
    }
}
