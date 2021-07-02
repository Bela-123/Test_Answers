using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Bengaluru is the capital of India's southern Karnataka";
            char strChar = ' ';
            int[] strCharCount = new int[256];
            int strlength = str.Length;
            for (int i = 0; i < strlength; i++)
            {
                strCharCount[str[i]]++;
            }
           
            for (int i = 0; i < strlength; i++)
            {
                strChar = str[i];
               
            }
          
            Console.WriteLine("The highest occurring character in the above string is: " + strChar);
         
        }
    }
}
