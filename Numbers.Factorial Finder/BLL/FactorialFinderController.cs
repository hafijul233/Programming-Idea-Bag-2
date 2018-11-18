using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.Factorial_Finder.BLL
{
    public class FactorialFinderController
    {
        public string StringValidation(string value)
        {
            if (value != String.Empty)
            {
                foreach (char c in value)
                {
                    if (Char.IsDigit(c) == false)
                    {
                        return "Only Integer Number are Allowed.";
                    }
                }

                if (value.Length > 2)
                {
                    return "Input Is Too Big Too Calculate.";
                }

                else if (value.Length <= 2)
                {
                    int numbervalue = Convert.ToInt32(value);

                    if (numbervalue > 27)
                    {
                        return "Calculation Range is 1 to 27(max).";
                    }

                    return "NULL";
                }

                return "NULL";
            }

            return "NULL";
        }

        public string getFactorial(int number)
        {
            if (number == 0)
            {
                return "0 Cannot be Factorized.";
            }

                ulong resultNumber = 1;

                while (number >= 1)
                {
                    resultNumber = (resultNumber * (ulong)number);
                    number = number - 1;
                }

            return resultNumber.ToString();
        }
    }
}
