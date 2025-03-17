using System.ComponentModel.Design;
using System.Drawing;
using System.Threading.Channels;

namespace hometask17marchclass
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Student student = new Student("Gunel", "Shikarova", "Master", 94);



        //    student.GetInfo();

        //}

        static void Main()
       { Student student = new Student("Gunel", "Shikarova", "Master", 94);
        student.CheckGraduation();}
        
    }
}
