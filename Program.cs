using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversesWords
{
    static class StringHelper
    {
        /// <summary>
        /// Receives string and returns the string with its letters reversed.
        /// </summary>
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringHelper.ReverseString("The greatest victory is that which requires no battle"));
            Console.ReadLine();
        }
    }
}
