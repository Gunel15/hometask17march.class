using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace hometask17marchclass
{
    class Student
    { public string Name {  get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
        public float Point { get; set; }
        public bool isGraduated { get; set; }

        public Student(string name, string surname, string group, float point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
        }
        









    }


}
