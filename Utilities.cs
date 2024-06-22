using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Utilities
    {
        public static int CalculatorYearlyWage(int monthlyWage, int numOfMonthsWorked)
        {
            //Console.WriteLine($"Yearly wage: {monthlyWage * numOfMonthsWorked}");
            // return monthlyWage * numOfMonthsWorked;

            if (numOfMonthsWorked == 12)
            {
                return monthlyWage * (numOfMonthsWorked + 1);
            }
            else
            {
                return monthlyWage * numOfMonthsWorked;
            }
        }

        public static int CalculatorYearlyWage(int monthlyWage, int numOfMonthsWorked, 
        int bonus)
        {
            Console.WriteLine($"The yearly wage is: {monthlyWage * numOfMonthsWorked + 
            bonus}");
            return monthlyWage * numOfMonthsWorked + bonus;
        }
    }
}