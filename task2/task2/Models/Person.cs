using System;
using System.Collections.Generic;
using System.Text;

namespace task2.Models
{
    internal class Person
    {
        private int _age;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    _age = value;
                }
            }
        }

        public Person(int age,string name,string surname)
        {
            Age = age;
            Name = name;
            Surname = surname;
        }




    }
}
