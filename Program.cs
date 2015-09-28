using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace euler10
{
    class Program
    {
        static Dictionary<int, bool> numbers = new Dictionary<int, bool>();
        static void Main(string[] args)
        {
            Int64 total = 2;
            for (var x = 2; x < 2000000; x++)
            {
                numbers.Add(x,false);
            }

            var r = 2;
            setNonPrimes(2);
            while (r < 2000000)
            {
                setNonPrimes(r);
                r = numbers.FirstOrDefault(x => x.Value == false && x.Key != r && x.Key > r).Key;
                total = total + r;
            }


            Console.WriteLine(total);
            Console.ReadLine();


        }


        private static void setNonPrimes(int number)
        {
            for (var a = number; a < numbers.Count / number; a++)
            {
                numbers[a * number] = true;
            }
        }
    }
}
