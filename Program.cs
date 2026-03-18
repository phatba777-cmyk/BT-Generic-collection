using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("MSV:241505312228 - TenSV: Phat - Lop:225LTC01");

        List<int> list = new List<int>();

        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so: ");
            list.Add(int.Parse(Console.ReadLine()));
        }

        var result = list.GroupBy(x => x)
                         .OrderByDescending(g => g.Count())
                         .First();

        Console.WriteLine("\nPhan tu xuat hien nhieu nhat la: " + result.Key);
        Console.WriteLine("So lan xuat hien: " + result.Count());

        Console.ReadKey();
    }
}