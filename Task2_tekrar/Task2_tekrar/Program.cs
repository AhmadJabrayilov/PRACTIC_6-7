using System;
using Task2_tekrar.Models;

namespace Task2_tekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input Teacher's name: ");
            string tName = Console.ReadLine();

            Console.Write("input Teacher's surname: ");
            string tSurname = Console.ReadLine();

            Console.Write("input Teacher's age: ");
            int tAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("input Teacher's experience: ");
            int tExp = Convert.ToInt32(Console.ReadLine());

            Teachers tch1 = new Teachers(tExp, tName, tSurname, tAge);

            Console.Write("input Teacher's name: ");
            string tName2 = Console.ReadLine();

            Console.Write("input Teacher's surname: ");
            string tSurname2 = Console.ReadLine();

            Console.Write("input Teacher's age: ");
            int tAge2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("input Teacher's experience: ");
            int tExp2 = Convert.ToInt32(Console.ReadLine());
            Teachers tch2 = new Teachers(tExp2, tName2, tSurname2, tAge2);

            tch1.ShowInfoTeacher();
            tch2.ShowInfoTeacher();

            Console.WriteLine("♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠♠");

            Console.Write("input Student's name: ");
            string sName = Console.ReadLine();

            Console.Write("input Student's surname: ");
            string sSurname = Console.ReadLine();

            Console.Write("input Student's age: ");
            int sAge = Convert.ToInt32(Console.ReadLine());

            Student std1 = new Student(sName, sSurname, sAge);

            std1.AddLessons("C#");
            std1.AddLessons("MSQL");
            std1.AddLessons("ASP.NET Core");
            std1.AddLessons("HTML5");
            std1.AddLessons("CSS3");
            std1.AddLessons("Bootstrap 4");
            std1.AddLessons("Javascript");

            std1.ShowInfoStudent();





        }
    }
}
