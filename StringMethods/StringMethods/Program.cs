using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str1 = "Raul ";
            Console.WriteLine("str = " + str1);
            Console.WriteLine("lenght = "+ str1.Length);

            String str2 = "Fernandes";
            String str3 = String.Concat(str1, str2);
            Console.WriteLine("Concat= " + str3);

            char[] ch = { 'a', 'b', 'c' };
            String str4 = new string(ch);
            Console.WriteLine(str4);

            Boolean result1 = str1.Equals(str2);
            Console.WriteLine(result1);

            int a =str1.CompareTo(str2);
            Console.WriteLine(a);

            String name = "RAUL";
            int id = name.IndexOf('L');
            Console.WriteLine(id);

            String str5= String.Join("",str1, str2);
            Console.WriteLine(str5);

            String str = "Welcome to C# Programming World";
            String[] separator = {" "};
            Int32 count = 3;
            String[] strlist = str.Split(separator, count, StringSplitOptions.RemoveEmptyEntries);
            foreach (String s in strlist)
               {
                Console.WriteLine( s+ "\n");
            }



        }
    }
}
