using System;
using System.Xml.XPath;
namespace taxcalc
{
    internal class Program{
        static void Main(string[] args)
        {
            decimal result=NettoIncome(300000,0.3m);
            Console.WriteLine(result);
            
        }

        public static decimal NettoIncome(decimal personMonthIncome,decimal taxRate)
        {
            return personMonthIncome*(1-taxRate);
        }
    }
}