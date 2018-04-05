using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            Add(ref number);
            Console.WriteLine(number);
            Console.ReadKey();
        }
        static void Add(ref int number)
        {
            number = number + 5;
            
        }
      
    }
}
