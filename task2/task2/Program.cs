using System;
using task2.Models;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age;
            //int exp;
           
            //int age1;
            
            
            //Console.Write("enter name: ");
            //string name = Console.ReadLine();

            //Console.Write("enter surname: ");
            //string surname = Console.ReadLine();

            //do
            //{
            //    Console.WriteLine("Inpunt experience: ");
            //    exp = Convert.ToInt32(Console.ReadLine());

            //} while (exp < 1 || exp >80 );

            //do
            //{
            //    Console.WriteLine("Inpunt age: ");
            //    age = Convert.ToInt32(Console.ReadLine());

            //} while (age<0 || age>120);



            //Teacher tch1 = new Teacher(exp,age,name,surname);

            //tch1.ShowInfoTeacher();

            //Console.WriteLine("---------------------------");


            //Console.Write("enter Student name: ");
            //string studentName = Console.ReadLine();

            //Console.Write("enter Student surname: ");
            //string studentSurname = Console.ReadLine();

            ////do
            ////{
            ////    Console.WriteLine("Inpunt experience: ");
            ////    exp1 = Convert.ToInt32(Console.ReadLine());

            ////} while (exp < 1 || exp > 80);

            //do
            //{
            //    Console.Write("Inpunt  age: ");
            //    age1 = Convert.ToInt32(Console.ReadLine());

            //} while (age < 0 || age > 120);

            //Student std1 = new Student(age1, studentName, studentSurname);
            //std1.ShowInfoStudent();


            Console.WriteLine("_________________________________");




            Group gp1 = new Group();
            gp1.AddStudent("Ilkin");
            gp1.AddStudent("ahmed");
            gp1.AddStudent("ali");
            gp1.AddStudent("asdasds");


            foreach (var item in gp1.studentFullNames)
            {
                Console.WriteLine(item);
            }




        }
    }
}
