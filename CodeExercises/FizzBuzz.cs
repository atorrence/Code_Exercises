using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercises
{
    public class FizzBuzz
    {
        public string GetFizzBuzz(int n)
        {
            string result =" ";
            if (n % 3 == 0)
            {
                result = "Fizz";
            }

            return result;
        }

    }
}
