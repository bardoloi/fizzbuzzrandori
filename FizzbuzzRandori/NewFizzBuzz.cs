using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzbuzzRandori
{
    public class NewFizzBuzz
    {
        public string Render(int i)
        {
            var result = new StringBuilder();

            if (i % 3 == 0)
                result.Append("Fizz");

            if (i % 5 == 0)
                result.Append("Buzz");

            if (result.Length == 0)
                result.Append(i.ToString());

            return result.ToString();
        }
    }
}
