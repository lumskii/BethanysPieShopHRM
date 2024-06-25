using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int hoursWorked;
        public double wage;
        public double hourlyRate;
        public DateTime birthDay;

        public void PerformWork()
        {
            hoursWorked++;
            Console.WriteLine($"{firstName} {lastName} has worked for {hoursWorked} hour(s)!");
        }

         public void PerformWork(int numOfHours)
        {
            hoursWorked += numOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {hoursWorked} hour(s)!");
        }
    }
}