using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessSpecifier;
namespace Assembly2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("RAUL", 55);
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.age);
            Console.ReadKey();
        }
    }
}
