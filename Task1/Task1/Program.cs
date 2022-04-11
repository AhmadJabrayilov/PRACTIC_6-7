using System;
using Task1.Models;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inputAge:
            Console.WriteLine("Age-i daxil edin:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 0)
            {
                Console.WriteLine("menfi age olmaz");
                goto inputAge;
            }

            inputPoint:
            Console.WriteLine("Pointi daxil edin:");
            int point = Convert.ToInt32(Console.ReadLine());
            if (point < 0 || point >100)
            {
                Console.WriteLine("point menfi ola bilmez veya 100den boyuk ola bilmez");
                goto inputPoint;
            }


            Student st1 = new Student(1,point,"Ahmed","Jabrayilov",age);
            st1.ShowInfo();
            //st1.Name = "Lorem";
            //st1.SurName="Ipsum";
            //st1.Point = 50;
            //st1.Id = 1;
            //st1.Point = -55;
            //Console.WriteLine(st1.Point);
            




        }
    }
}
