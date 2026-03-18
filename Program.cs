using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name;
    public double Score;
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("MSV:241505312228 - TenSV: Phat - Lop:225LTC01");

        List<Student> list = new List<Student>();

        Console.Write("Nhap so sinh vien: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhap sinh vien thu {i + 1}:");

            Student s = new Student();

            Console.Write("Nhap ten: ");
            s.Name = Console.ReadLine();

            Console.Write("Nhap diem: ");
            s.Score = double.Parse(Console.ReadLine());

            list.Add(s);
        }

        var max = list.OrderByDescending(x => x.Score).First();

        Console.WriteLine("\nSinh vien co diem cao nhat la: " + max.Name);
        Console.WriteLine("Diem: " + max.Score);

        Console.ReadKey();
    }
}