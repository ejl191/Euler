using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler10
{
    class Program
    {
        static Dictionary<int, bool> numbers = new Dictionary<int, bool>();
        static Int64 total = 0;
        static void Main(string[] args)
        {
            for (var x = 0; x <= 2000000; x++)
            {
                numbers.Add(x, false);
            }

            var r = 2;
            setNonPrimes(2);
            while (r < 2000000)
            {
                setNonPrimes(r);
                Console.WriteLine(r);
                r++;
            }

            var test = numbers.Where(x => x.Value == false && x.Key != 1 && x.Key != 0);
           // foreach(var
            Console.WriteLine(test.Count());
            Console.WriteLine(total);
            Console.ReadLine();


        }


        private static void setNonPrimes(int number)
        {
            var x = 2;
            while (number * x <= 2000000)
            {
                numbers[x * number] = true;
                x++;
            }
     
        }
    }
}