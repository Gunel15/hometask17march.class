using System.Drawing;

namespace hometask17marchclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student GetInfo = new Student("Gunel", "Shikarova", "Master", 94);
            
           
            Console.WriteLine($"{GetInfo.Name} {GetInfo.Surname} {GetInfo.Group} {GetInfo.Point} ");
           
        }
    }
}
