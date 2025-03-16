using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace hometask17marchclass
{

        class Student
        {
            public string Name;
            public string Surname;
            public string Group;
            public float Point;
            public bool isGraduated;

            public Student(string name, string surname, string group, byte point)
            {
                Name = name;
                Surname = surname;
                Group = group;
                Point = point;

            }







            public void GetInfo()

            {
                Student GetInfo = new Student("Gunel", "Shikarova", "Master", 94);


                Console.WriteLine($"{GetInfo.Name} {GetInfo.Surname} {GetInfo.Group} {GetInfo.Point} ");

            }

        }
    }

        









 
