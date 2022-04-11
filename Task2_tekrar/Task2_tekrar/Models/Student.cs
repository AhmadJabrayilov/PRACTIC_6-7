using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_tekrar.Models
{
    internal class Student : Person
    {
        private int _id;
        public string[] Lessons = new string[0];
        public int Id { get; }

        public Student(string name, string surname, int age) : base(name, surname, age)
        {
            _id++;
            Id = _id;
        }



        public void AddLessons(string lsn)
        {
            Array.Resize(ref Lessons, Lessons.Length + 1);
            Lessons[Lessons.Length - 1] = lsn;
        }

        public void ShowInfoStudent()
        {
            Console.WriteLine($"ID : {Id}\nName : {Name}\nSurname : {Surname}\nAge : {Age}\nLessons : --- {Lessons} ---");

            Console.WriteLine("Lesson contect");
            foreach (string item in Lessons)
            {

                Console.WriteLine("--" + item);
            }


        }


    }
}
