using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Euler13
{
    class Program
    {
        static void Main(string[] args)
        {
            Double total = 0;
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead("numbers.txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    total = total + Double.Parse(line);
                }             

            }
            Console.WriteLine("Total: " + total.ToString("F99"));
            Console.ReadLine();
        }
    }
}
