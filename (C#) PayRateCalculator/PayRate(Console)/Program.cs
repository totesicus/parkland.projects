using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRate_Console_
{
    class Program
    {
        static void Main(string[] args)
        {
            String hoursIn, payRateIn, taxIn, response;
            double hours, payRate, payRateResult, tax, taxResult, result;
            Boolean loop = true;

            do
            {
                Console.Out.WriteLine("Welcome!\n");
                Console.Out.WriteLine("Hours worked:");

                hoursIn = Console.ReadLine();
                hours = double.Parse(hoursIn);

                Console.Out.WriteLine("\nPay rate:");

                payRateIn = Console.ReadLine();
                payRate = double.Parse(payRateIn);

                Console.Out.WriteLine("\nTax rate:");

                taxIn = Console.ReadLine();
                tax = double.Parse(taxIn);

                taxResult = tax * payRate;
                payRateResult = payRate - taxResult;
                result = hours * payRateResult;

                Console.Out.WriteLine("\nYour paycheck for the week will be (approx): " +
                            result.ToString("C"));

                Console.Out.WriteLine("Make another calculation? (y/n)");
                response = Console.ReadLine();

                if (response.Equals("y"))
                {
                    Console.Out.WriteLine("\n");
                    continue;

                } else if (response.Equals("n"))
                {
                    loop = false;
                }

            } while (loop == true);
        }
    }
}
