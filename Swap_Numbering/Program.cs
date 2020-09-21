using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Numbering
{
    class Program
    {
        static void Main(string[] argms)
        {
            int x = 20;
            int y = 30;
            Console.WriteLine("Numbers before swapping");
            Console.WriteLine(" number x is " + x);
            Console.WriteLine("number y is " + y);
            // Swapping numbers
            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine("Numbers after swapping");
            Console.WriteLine("number x is" + x);
            Console.WriteLine("number y is " + y); 
            Console.ReadKey();

           
        }
    }
}
