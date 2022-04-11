using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_tekrar.Models
{
    internal class Person
    {
        private int _age;
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0 && value <= 120) _age = value;
            }
        }

        public Person(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        
    }
}
