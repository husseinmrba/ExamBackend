using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention
{
    internal static class Extend
    {
        public static void print(this string message)
        {
            Console.WriteLine("the message is: {0}",message);
        }

        public static int sum(this int num1 , int num2)
        {
            return num1 + num2;
        }
    }
}
