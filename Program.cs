using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("MSV:241505312228 - TenSV: Phat - Lop:225LTC01");

        List<Student> list = new List<Student>();

        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhap thong tin sinh vien thu {i + 1}:");

            Student s = new Student();

            Console.Write("Nhap ID: ");
            s.Id = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten: ");
            s.Name = Console.ReadLine();

            list.Add(s);
        }
        Console.Write("\nNhap ten sinh vien can tim: ");
        string name = Console.ReadLine();

        bool found = false;

        Console.WriteLine("\nKet qua tim kiem la:");
        foreach (var s in list)
        {
            if (s.Name.ToLower() == name.ToLower()) 
            {
                Console.WriteLine("ID: " + s.Id + " - Ten: " + s.Name);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong tim thay sinh vien nao phu hop.");
        }

        Console.WriteLine("\nNhan phim bat ky de ket thuc...");
        Console.ReadKey();
    }
}