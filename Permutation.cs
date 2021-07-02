using ConsoleApp6;
using System;

namespace ConsoleApp6
{

  public  class Permutation
    {

       public void PermutationFunction(int a, int c)
        {

            c = c - a;

            if (c <= 0)
            {
                Console.Write("No");
                return;
            }

            string strA = a.ToString();

            string strC = c.ToString();

            
            char[] arrA = strA.ToCharArray();
            Array.Sort(arrA);

           
            char[] arrC = strC.ToCharArray();
            Array.Sort(arrC);

           
            if (string.Join("", arrC) == string.Join("", arrA))
            {
                Console.Write("Yes\n" + c);
            }

            
            else
            {
                Console.WriteLine("No");
            }
        }
 
        }
    }

   

public class Program
    {
        static void Main(string[] args)
        {
        int A = 133;
        int C = 446;

        Permutation per = new Permutation();
        per.PermutationFunction(A, C);
    }
    }

