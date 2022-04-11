using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    internal class Student : Person
    {
        private int _point;
        public int Id { get; set; }
        public int Point
        {
            get
            {
                return _point;
            }


            set
            {
                if (value > 0 && value < 100)
                {
                    value = _point;
                }
            }
        }



        public Student(int id, int point, string name, string surName, int age) : base(name, surName)
        {
            this.Id = id;
            this.Point = point;
            this.Name = name;
            this.SurName = surName;
            this.Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {SurName},  Point: {Point}, Age: {Age}");
        }




    }





}
