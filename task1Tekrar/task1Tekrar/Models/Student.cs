using System;
using System.Collections.Generic;
using System.Text;

namespace task1Tekrar.Models
{
    internal class Student : Person
    {
        private double _point;
        public int StudentId { get; set; }
        public double Point
        {
            get
            {
                return _point;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _point = value;
                }
            }
        }

        public Student(double point,string name,string surname, int age):base(name,surname,age)
        {
           
            Point = point;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} - Surname: {SurName} - Age: {Age} - Point: {Point}");
        }
    }
}
