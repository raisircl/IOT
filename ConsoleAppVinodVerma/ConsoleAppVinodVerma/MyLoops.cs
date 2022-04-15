using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVinodVerma
{
    class MyLoops
    {
        static void Main()
        {
            int i;
            int num;
            //for loop
            Console.WriteLine("Enter a Num");
            num = Convert.ToInt32(Console.ReadLine());
            //for(i=1;i<=10;i++)
            //{
            //    Console.WriteLine($"{num}x{i}={num*i}");
            //}
            //for (int j = 0; j < 10; j++)
            //{
            //    for (int k = 0; k < j; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}
            // while loop
            int x = 0;
            int y = 0;
            int z = 0;
            while(num>0)
            {
                x = x + 1;
                y = y + num % 10;
                z = z * 10 + num % 10;
                num = num / 10;
            }
            Console.WriteLine($"Digits={x}");
            Console.WriteLine($"Sum of Digits={y}");
            Console.WriteLine($"Reverse of Digits={z}");
            // do while
            int n1, n2, r;
            string choice="";
            do
            {
                Console.WriteLine("Enter N1");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter N2");
                n2 = Convert.ToInt32(Console.ReadLine());
                r = n1 + n2;
                Console.WriteLine($"The sum is {r}");
                Console.WriteLine("Do you want to continue(Yes/No)");
                choice = Console.ReadLine();
            } while (choice=="yes");
        }
    }
}
