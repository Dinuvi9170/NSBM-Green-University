using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your employee ID:");
            String id = Console.ReadLine();
            Console.WriteLine("Enter your employee designation:");
            String designation = Console.ReadLine();


            Employee obj = new Employee();
            obj.setid(id );
            obj.setname(name);
            obj.setdesignation(designation);
            Console.WriteLine("Your name is " + obj.getname());
            Console.WriteLine("Your employee ID is " + obj.getid());
            Console.WriteLine("Your designation is " + obj.getdesignation());

            Console.ReadKey();
        }
    }
}
