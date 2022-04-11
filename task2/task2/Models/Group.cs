using System;
using System.Collections.Generic;
using System.Text;

namespace task2.Models
{
    internal class Group
    {
       public string[] studentFullNames = new string[0];
       public student[] students = new student[0];
        int Groupno;


       
        public void AddStudent(string fullName)
        {
            
            Array.Resize(ref studentFullNames, studentFullNames.Length + 1);
            studentFullNames[studentFullNames.Length - 1] = fullName;
          
        }

        public void AddStudent(Student student)
        {

            Array.Resize(ref studentFullNames, studentFullNames.Length + 1);
            studentFullNames[studentFullNames.Length - 1] = fullName;

        }




    }
}
