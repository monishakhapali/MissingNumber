using System;
using System.Collections.Generic;

namespace FindTheMissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /* Given an array nums containing n distinct numbers in the range [0, n], 
             * return the only number in the range that is missing from the array.
             */
            int[] a = {0,1};
            //Array.Sort(a);
            Console.WriteLine(MissingElement(a));
            Console.ReadLine();
        }
        public static int MissingElement(int[] a)
        {
            HashSet<int> numset = new HashSet<int>();
            for(int i=0;i<a.Length;i++)
            {
                numset.Add(a[i]);
            }
            int length = a.Length + 1;
            for(int i=0;i<length;i++)
            {
                if(!numset.Contains(i))
                {
                    return i;
                }
            }
            
            return -1;
        }
    }
}
