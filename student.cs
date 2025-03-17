using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
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
            isGraduated=point>65;

        }
        //public void GetInfo()

        //{
        //    Student GetInfo = new Student("Gunel", "Shikarova", "Master", 94);


        //    Console.WriteLine($"{GetInfo.Name} {GetInfo.Surname} {GetInfo.Group} {GetInfo.Point} ");

        //}


        //public void CheckGraduation()
        //{ if (isGraduated) 
        //    { Console.WriteLine($"{Name} {Surname} mezun olub"); }
        //   else
        //     Console.WriteLine($"{Name} {Surname} mezun olmayib"); 
        //}

        public void GetDiplomDegree()
        {
            if (Point < 65)
                Console.WriteLine("yoxdur");
            else if (Point < 80 && Point >= 65)
                Console.WriteLine("adi");
            else if (Point < 90 && Point >= 80)
                Console.WriteLine("sheref");
            else Console.WriteLine("yuksek sheref");
        }
    }
}



    

        









 
