using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_tekrar.Models
{
    internal class Teachers : Person
    {
        static private int _id;
        private int _experience;
        public int Id { get; }
        public int Experience
        {
            get => _experience;
            set
            {
                if (value > 0 && value <= 80) _experience = value;
            }
        }

        public Teachers(int exp,string name,string surname,int age):base(name,surname,age)
        {
            _id++;
            Id = _id;
            Experience = exp;
        }

        public void ShowInfoTeacher()
        {
            Console.WriteLine($"ID : {Id}\nName : {Name}\nSurname : {Surname}\nAge : {Age}\nExperience : {Experience}");
        }


    }
}
