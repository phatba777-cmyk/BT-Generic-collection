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
            list.Add(Console.ReadLine());

        Console.Write("Nhap ten can kiem tra: ");
        string x = Console.ReadLine();

        if (list.Contains(x))
            Console.WriteLine("Ten nay co ton tai trong danh sach.");
        else
            Console.WriteLine("Ten nay khong ton tai trong danh sach.");
    }
}