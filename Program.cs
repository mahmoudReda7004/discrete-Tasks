using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            bool result =true;
            Console.Write("enter the firt number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("enter the second number: ");

            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The perfect number between " + number1 + " and " + number2 + " is :");

            for (i = number1; i < number2; i++)
            {


                
                int sum = 0;
                for ( j = 1; j < i; j++)
                    if (i % j != 0)
                    {
                       
                    }
                Console.WriteLine();
                if (i%j ==0&& i!=0)
                {
                    sum += j;
                    
                }

                 
                Console.WriteLine(sum == i);

            }
        }
    }
}
