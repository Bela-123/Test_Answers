using System;
using System.Text.RegularExpressions;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)

        {
            string palin = "SE#$^ #@!# EEEEES";
            string rev = string.Empty;
            string strTrim = (palin.Substring(2, 9));

            

            string strRemove = palin.Remove(2,9);
            Console.WriteLine(strRemove);

            int strlength = strRemove.Length - 1;
           
            while (strlength >= 0)
            {
                rev = rev + strRemove[strlength];
                Console.WriteLine(rev);
                strlength--;
            }
           if (strRemove == rev)
            {
                Console.WriteLine("Palindrome");

            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

        }
    }
}
