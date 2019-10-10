using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a beginning number");
            int beginning_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Write an ending number");
            int ending_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Write your number");
            int your_number = int.Parse(Console.ReadLine());
            for(int number=beginning_number; number<=ending_number; number++)
            {
                if (number == your_number)
                {
                    Console.WriteLine("In Range");
                }
                Console.WriteLine("Out of range");
            }
        }
    }
}
