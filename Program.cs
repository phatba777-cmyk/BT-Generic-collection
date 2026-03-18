using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("MSV:241505312228 - TenSV: Phat - Lop:225LTC01");

        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        Dictionary<char, int> count = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (count.ContainsKey(c))
                count[c]++;
            else
                count[c] = 1;
        }

        Console.WriteLine("\nSo lan xuat hien cua tung ky tu la:");
        foreach (var x in count)
            Console.WriteLine(x.Key + " : " + x.Value);

        Console.ReadKey();
    }
}