using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {

        }
        public FizzBuzz(int startRange, int endRange)
        {

        }
        public string DivisibilityByThree(double value)
        {
            if(value % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return "NotFizz";
            }
        }
        public string DivisibilityByFive(double value)
        {
            if (value % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return "NotBuzz";
            }
        }
        public string DivisibilityByThreeAndFive(double value)
        {
            if ((value % 3 == 0) && (value % 5 ==0))
            {
                return "FizzBuzz";
            }
            else
            {
                return "NotFizzBuzz";
            }
        }
    }
}
