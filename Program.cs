using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Person person = new Person() { FirstName = "Nikolai", LastName = "Petrenkov" };
            ClassLibrary1.Class1.PrintInfo(person);
            Constances constances = new Constances();
            Console.WriteLine(constances.GetInt());
            Console.WriteLine(constances.GetString());
            Console.ReadLine();
        }
    }
}
