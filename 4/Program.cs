using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        for (int i = 0; i < 1000; i++)
        {
            Console.Write(palabra + " ");
        }
    }
}
