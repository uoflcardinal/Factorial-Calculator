using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                long myNum;

                Console.WriteLine("Please enter an integer between 1 and 10: ");

                if (!long.TryParse(Console.ReadLine(), out myNum))

                {
                    Console.WriteLine("You did not enter a number!");
                    continue;
                }
                else if (myNum > 10 || myNum < 1)
                {
                    Console.WriteLine("You did not enter a number between 1 and 10!");
                    continue;
                }
                else
                {
                    long i = myNum - 1;
                    long myFact = myNum;

                    for (i = myNum - 1; i >= 1; i--)
                    {
                        myFact = myFact * i;
                    }
                    Console.WriteLine("The Factorial of your entered number {0} is {1}", myNum, myFact);
                }

            } while (true);
        }
    }
}
