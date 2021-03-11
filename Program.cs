using System;

namespace fizzB_w2
{
    // defining global variables
    //int sweet = 0;
    class Program
    {
        static void Main(string[] args)
        {
            // creating an array of integers 
            int [] a = new int [1000];
            for (int i =0; i < a.Length; i+=1)
            {   // assing value to the array
                a[i] = i+1;
               
            }
            // print the array
            for (int j = 0; j<a.Length; j+=1)
            {
                Console.Write(a[j] + ((a[j] % 10 == 0) ? "\n" : "   "));
            }

            // define variables
            int sweet = 0;
            int salty = 0;
            int sns = 0;
            int k = 0;
            // conting the divisibles
            for (k = 0; k < 1001; k++)
            {
            if (k % 3 == 0)
                {
                 sweet = sweet +1 ;
                }

            if (k % 5 == 0)
                {
                 salty = salty + 1;
                }
            if (k % 3 == 0  && k % 5 == 0 )
               {
                sns = sns + 1;
               }           
            
            }

            Console.WriteLine();
            Console.Write("sweet = "+ sweet + "  " +  "salty = " + salty + " sweet\"nsalty = " + " " + sns);
        }
    }        
}
    
