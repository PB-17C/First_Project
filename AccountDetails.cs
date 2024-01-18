using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class AccountDetails
    {
        public void GetData()
        {
            Console.WriteLine("enter your balance");
            double balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter your account type");
            string accountType = Console.ReadLine();
            Console.WriteLine("enter your deposit amount");
            double amount = Convert.ToDouble(Console.ReadLine());
            balance += amount;
            Console.WriteLine($"new balance is :{balance}");
        }
    }
}
