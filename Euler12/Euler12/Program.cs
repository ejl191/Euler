using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler12
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool fincheck = false;
            int divcheck = 0;
            int tri = 0;
            for(var x = 0; fincheck == false; x++)
            {
                tri = tri + x;
                int divis = getDivisorCount(tri);
                if(divis > divcheck)
                {
                    divcheck = divis;
                }
               
                if (divis >= 500)
                {
                    Console.WriteLine(tri + " - " + divis);
                    fincheck = true;
                }                
            }
            Console.ReadLine();
        }


        private static int getDivisorCount(int num)
        {
            var divCount = 1;
            for (var x = 1; x <= (int)Math.Sqrt(num); x++)
            {
                if(num%x == 0)
                {
                    //Console.WriteLine(num + " % " + x + " = " + num % x);
                    divCount+=2;                    
                }
            }

            return divCount;
        }


    }
}
