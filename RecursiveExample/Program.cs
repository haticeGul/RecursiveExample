using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveExample
{
    class Program
    {
        static void Main(string[] args)
        {

            /**Number given on base 2 , if the number is even, divide by 2.. if it is odd , subtract 1 .
             * This process will continue until your number becomes zero. 
             * my solution is tried to find how many steps does program need.
             * For example:
             *my input is '011100'
             * my number is 28...28/2 = 14--> step: 1
             * my number is 14...14/2 = 7 --> step: 2
             * my number is 7 ...7-1 = 6 -->  step: 3
             * my number is 6....6/2 = 3 -->  step: 4
             * my number is 3 ...3-1 = 2 -->  step: 5
             * my number is 2... 2/2 = 1 ---> step: 6
             * my number is 1... 1-1 = 0 ---> step: 7
             * my output is 7
            **/
            //011100 bunun cevabı 7

            int number = Convert.ToInt32("011100", 2);
            int stepCount = 0;

            Console.WriteLine(Calculate(ref number, ref stepCount));
            Console.ReadLine();
        }

        private static int Calculate(ref int number, ref int stepCount)
        {
            if (number == 0)
            {
                return stepCount;
            }

            if (number % 2 == 0)
            {
                number /= 2;
            }
            else
            {
                number--;
            }

            stepCount++;
            return Calculate(ref number, ref stepCount);

        }
    }
}
