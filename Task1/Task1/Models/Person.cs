using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    internal class Person
    {
        private int _age;
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age
        {
            get
            {
                return _age;

            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                   
                    
                }
               
            } 
        }

        public Person(string name,string surName )
        {
            this.Age = _age;
            this.Name = name;
            this.SurName = surName;



        }
    }
}
