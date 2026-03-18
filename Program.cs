using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("MSV:241505312228 - TenSV: Phat - Lop:225LTC01");

        List<int> list = new List<int>();

        Console.Write("Nhap so luong: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
            list.Add(int.Parse(Console.ReadLine()));

        list.Reverse();

        Console.WriteLine("Danh sach sau khi dao nguoc la:");
        foreach (int x in list)
            Console.Write(x + " ");
    }
}