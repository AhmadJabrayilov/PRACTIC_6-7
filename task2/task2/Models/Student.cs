using System;
using System.Collections.Generic;
using System.Text;

namespace task2.Models
{
    internal class Student:Person
    {
       private int  _id;
        public int Id { get;  }

        public string[] Lessons { get; set; }
        public Student( int age, string name, string surname/*, string[] lesson*/) :base(age,name,surname)
        {
            Id = _id;
            Id++;
           // Lessons = lesson;
        }

        public void ShowInfoStudent()
        {
            Console.WriteLine($"ID: {Id}\nName: {Name}\nSurname: {Surname}\nAge: {Age}\nLessons: - - - - ");
        }
    }
}
