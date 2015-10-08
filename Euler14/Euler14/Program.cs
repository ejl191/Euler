using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler14
{
    class Program
    {
        private static Int64 newBig = 1;


        static void Main(string[] args)
        {
            List<long> numList = new List<Int64>();
            Int64 biggest = 0;
            Int64 winningNum = 0;
            

            for(Int64 x = 1; x <= 1000000; x++)
            {
                newBig = 0;
                
                Int64 number = x;

                Int64 highest = processNumber(number);
                numList.Add(highest);
                if (highest > biggest) {
                    biggest = highest;
                    winningNum = x;
                }
                



            }
            Console.WriteLine(winningNum);
            Console.ReadLine();
        }

        private static Int64 processNumber(Int64 number) {

            if (number % 2 == 0)
            {
                number = number / 2;
            }
            else
            {
                number = (number * 3) + 1;
            }

            if(number != 1)
            {
                newBig++;
                return processNumber(number);
            } else
            {
                newBig++;
                return newBig;
            }
            
        }
    }
}
