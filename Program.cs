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
            Student s = new Student();

            Console.Write("Nhap ID: ");
            s.Id = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten: ");
            s.Name = Console.ReadLine();

            list.Add(s);
        }

        Console.Write("\nNhap ID can xoa: ");
        int id = int.Parse(Console.ReadLine());

        int before = list.Count;
        list.RemoveAll(s => s.Id == id);

        Console.WriteLine("\nDanh sach sinh vien sau khi xoa la:");
        foreach (var s in list)
            Console.WriteLine("ID: " + s.Id + " - Ten: " + s.Name);

        if (before == list.Count)
            Console.WriteLine("Khong tim thay sinh vien co ID phu hop.");

        Console.ReadKey();
    }
}