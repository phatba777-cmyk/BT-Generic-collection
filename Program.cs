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
        Console.WriteLine("MSV:241505312228 - TenSV: Phat - Lop:225LTC01");

        List<Student> list = new List<Student>();

        Console.Write("Nhap so sinh vien: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student s = new Student();

            Console.Write("Nhap ID: ");
            s.Id = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten: ");
            s.Name = Console.ReadLine();

            list.Add(s);
        }

        Console.WriteLine("Danh sach sinh vien la:");
        foreach (var s in list)
            Console.WriteLine(s.Id + " - " + s.Name);
    }
}