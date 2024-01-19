using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Primedemo
    {
        int n1, n2;
        public void Getdetails() 
        {
            Console.WriteLine("Enter first number:");
            n1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            n2= Convert.ToInt32(Console.ReadLine());
        }
        public bool Checkprime(int num)
        {
            for(int i = n1; i <= n2; i++)
            {
                if (i % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void Displaydetails()
        {
            if (Checkprime(num))
            {
                Console.WriteLine($"{num} is a prime number");
            }
            
        }
            
    }
}
