/*
Patrick Cousineau
9/27/2020
Array build

*/
using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {

            //this is the manual 25 element array
            int[] Numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25};


            //This will list every value in the array
            foreach (int i in Numbers)
            {
                //this will write the value of the arrays
                Console.WriteLine("Element Value " + i);
            }
            
        }
    }
}
