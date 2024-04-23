using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inher
{
    public class Person
    {
        public string name;
        public Person(string n)
        {
            name = n;
        }
        public void GetName()
        {
            Console.WriteLine(name);
        }
        static void Main(string[] args)
        {
            Person p1 = new Person(" raul ");
            p1.GetName();
        }
    }
}
