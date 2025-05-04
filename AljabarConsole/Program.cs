using System;
using AljabarLibraries;

class Program
{
    static void Main(string[] args)
    {
        double[] akar = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
        Console.WriteLine("Akar-akar persamaan kuadrat:");
        foreach (double a in akar)
        {
            Console.WriteLine(a);
        }

        double[] hasilKuadrat = Aljabar.HasilKuadrat(new double[] { 2, -3 });
        Console.WriteLine("\nHasil kuadrat dari 2x - 3:");
        foreach (double h in hasilKuadrat)
        {
            Console.WriteLine(h);
        }

        Console.ReadLine();
    }
}
