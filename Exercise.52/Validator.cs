using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._10
{
    class Validator
    {
        public static double ValidatingEntry(string entry)
        {
            var verification = true;
            double verifiedEntry = 0;
            while (verification)
            {
                verification = double.TryParse(entry, out verifiedEntry);

                if(verification != true)
                {
                    Console.Write("I'm sorry that is not a valid input, please try again: ");
                    entry = Console.ReadLine();
                    verification = true;
                }

                else
                {
                    verification = false;
                }
            }
            return verifiedEntry;
        }
    }
}
