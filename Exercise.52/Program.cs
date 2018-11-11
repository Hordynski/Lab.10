using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._52
{
    class Program
    {
        static void Main(string[] args)
        {
            var doAgain = true;
            int circleBuilds = 0;

            while (doAgain)
            {
                Console.Write("Please enter a radius: ");
                var userEntry = Console.ReadLine();
                var validatedEntry = Validator.ValidatingEntry(userEntry);
                var doubleUserEntry = Convert.ToDouble(validatedEntry);
                var newCircle = new Circle(doubleUserEntry);

                Console.WriteLine($"This is the area of your circle: {newCircle.FormatCalculatedArea()}");
                Console.WriteLine($"This is the circumference of your circle: {newCircle.FormatCalculatedCircumference()}");

                Console.Write("Would you like to build another circle? Y or N: ");
                var userRepeat = Console.ReadLine();

                if (userRepeat.StartsWith("Y", StringComparison.OrdinalIgnoreCase))
                {
                    doAgain = true;
                    circleBuilds++;
                    Console.WriteLine($"You have built {circleBuilds} circles.");
                }

                else
                {
                    doAgain = false;
                    circleBuilds++;
                    Console.WriteLine($"You have built {circleBuilds} circles.");
                }
            }
            Console.WriteLine("Goodbye!");
            Console.ReadKey();


        }
    }
}
