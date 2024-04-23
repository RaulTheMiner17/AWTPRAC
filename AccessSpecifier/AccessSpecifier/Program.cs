using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifier
{
    public class Person
    {
        internal string name;
        public int age;
        public Person(string n, int a)
        {
            name= n;
            age= a;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetName()
        {
            return name;
        }
    }
    class Student:Person
    {
        public int rollno;
        public Student(string n, int a, int r):base(n, a)
        { 
            rollno = r;
            name = n;
        }
    }
    class TestDemo
    {   
        static void Main(string[] args)
        {
           
            Student s1 = new Student("Joshi", 69, 65);
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.age);
            Console.WriteLine(s1.rollno);
            Console.ReadKey();
        }
    }
        
    
}
