using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("MSV:241505312228 - TenSV: Phat - Lop:225LTC01");

        Dictionary<string, string> dict = new Dictionary<string, string>();

        dict["hello"] = "xin chao";
        dict["book"] = "sach";
        dict["student"] = "sinh vien";

        Console.Write("Nhap tu tieng Anh can tra: ");
        string key = Console.ReadLine();

        if (dict.ContainsKey(key))
            Console.WriteLine("Nghia cua tu la: " + dict[key]);
        else
            Console.WriteLine("Khong tim thay tu trong tu dien.");

        Console.ReadKey();
    }
}