namespace Homework;
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var a = File.ReadAllLines("17.txt")
                    .Where(line => !string.IsNullOrWhiteSpace(line))
                    .Select(int.Parse)
                    .ToArray();

        int count = 0;

        for (int i = 0; i < a.Length - 1; i++)
        {
            if ((a[i] > 0 && a[i + 1] > 0) || (a[i] < 0 && a[i + 1] < 0))
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}