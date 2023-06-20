using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for addition");
            Console.WriteLine("Enter 2 for substraction");
            Console.WriteLine("Enter 3 for multipication");
            Console.WriteLine("Enter 4 for division");

            Console.Write("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 1:");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter number 2:");
            double num2 = double.Parse(Console.ReadLine());
            CalculateValues obj = new CalculateValues();
            
            double add = obj.addition(num1, num2);
            double sub = obj.substraction(num1, num2);
            double mul = obj.multipication(num1, num2);
            double div = obj.division(num1, num2);
            if (choice == 1)
                Console.Write("the addition :" + add);
            else if (choice == 2)
                Console.Write("the substraction :" + sub);

            else if (choice == 3)
                Console.Write("the multipication :" + mul);
            else if (choice == 4)
                if (num2 != 0)
                    Console.Write("the division :" + div);
                else
                    Console.Write("Not defined");
            else
                Console.Write("enter a valid choice");

           Console.ReadLine();
        }
    }
}
