using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzbuzzRandori
{
    public class FizzBuzz
    {
        public int GetNumberQty()
        {
            return 100;
        }

        public string[] GetMessagesToShow()
        {
            var msgs = new string[100];

            for (int i = 1; i <= 100; i++)
            {
                if (i%3 == 0)
                {
                    msgs[i - 1] = "Fizz";
                }
                else
                {
                    msgs[i - 1] = (i).ToString();
                }
            }

            return msgs;
        }
    }
}
