using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("¿Desea ingresar las coordenadas del rectángulo? (S/N):");
        string opcion = Console.ReadLine();

        int x1, y1, x2, y2;

        if (opcion.ToUpper() == "S")
        {
            Console.Write("Coordenada x1: ");
            x1 = int.Parse(Console.ReadLine());

            Console.Write("Coordenada y1: ");
            y1 = int.Parse(Console.ReadLine());

            Console.Write("Coordenada x2: ");
            x2 = int.Parse(Console.ReadLine());

            Console.Write("Coordenada y2: ");
            y2 = int.Parse(Console.ReadLine());
        }
        else
        {
            // Valores predeterminados
            x1 = 1;
            y1 = 3;
            x2 = 5;
            y2 = 9;
        }

        int area = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);

        Console.WriteLine("El área del rectángulo es: {0}", area);
    }
}
