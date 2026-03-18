using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("MSV:241505312228 - TenSV: Phat - Lop:225LTC01");

        List<string> list = new List<string>();

        Console.Write("Nhap so luong ten: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap ten thu " + (i + 1) + ": ");
            list.Add(Console.ReadLine());
        }

        Console.Write("Nhap ten can xoa: ");
        string x = Console.ReadLine();

        list.Remove(x);

        Console.WriteLine("Danh sach sau khi xoa phan tu la:");
        foreach (string s in list)
            Console.WriteLine(s);
    }
}