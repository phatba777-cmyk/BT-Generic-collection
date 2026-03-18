using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("MSV:241505312228 - TenSV: Phat - Lop:225LTC01");

        List<int> list = new List<int>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
            list.Add(int.Parse(Console.ReadLine()));

        int max = list[0];
        foreach (int x in list)
            if (x > max) max = x;

        Console.WriteLine("Max = " + max);
    }
}