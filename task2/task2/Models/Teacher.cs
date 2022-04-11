using System;
using System.Collections.Generic;
using System.Text;

namespace task2.Models
{
    internal class Teacher : Person
    {
        static private int _id = 0;
        private int _experience;
        public int Id { get; }

        public int Experience
        {
            get { return _experience; }
            set
            {
                if (value > 0 && value <= 80)
                {
                    _experience = value;
                }
            }
        }


        public Teacher(int experience, int age, string name, string surname) : base(age, name, surname)
        {
            Id = _id;
            _id++;
            Experience = experience;

        }
        public void ShowInfoTeacher()
        {
            Console.WriteLine($"ID: {Id}\nName: {Name}\nSurname: {Surname}\nAge: {Age}\nExperience: {Experience} ");
        }





    }
}
