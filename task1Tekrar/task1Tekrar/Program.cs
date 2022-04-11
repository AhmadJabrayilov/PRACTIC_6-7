using System;
using task1Tekrar.Models;

namespace task1Tekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            double point;

            Console.Write("Input name: ");
            string name = Console.ReadLine();

            Console.Write("Input surname: ");
            string surname = Console.ReadLine();

            do
            {
                Console.WriteLine("Input age:");
                age = Convert.ToInt32(Console.ReadLine());

            } while (age < 0);

            do
            {
                Console.WriteLine("Input point: ");
                point = Convert.ToInt32(Console.ReadLine());

            } while (point < 0 || point > 100);


            Student std1 = new Student(point, name, surname, age);

            std1.ShowInfo();

            std1.Point = -65;
            Console.WriteLine(std1.Point);

        }
    }
}
