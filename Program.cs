using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("MSV:241505312228 - TenSV: Phat - Lop:225LTC01");

        List<int> list = new List<int>();

        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so: ");
            list.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Danh sach:");
        foreach (int x in list)
            Console.Write(x + " ");
    }
}
