/*
SMALLEST MULTIPLE (PROJECT EULER 5) (UNFINISHED)
This program finds the smallest number that is a 
multiple of all numbers between 1 and 20

ALGORITHM
NOTE: the only numbers that need to be checked is
11 through 20, since the other numbers will be 
divisors if these numbers are

1) Start with all numbers from 1 to 20 multiplied together.
    -This is the upper bound for the smallest number that all
     numbers between 1 and 20 divide into
2) 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCCSTools;



namespace SmallestMultiple
{
    class SmallestMultiple
    {
        static void Main(string[] args)
        {
            JCCSTools.Tools.printw("Getting al numbers that can be divided by all numbers between 1 and 20...");
            List<Int64> nums = SmallestMultiple.GetSmallestMultiple();
            JCCSTools.Tools.printw("The smallest number that can be divided by all numbers 1-20 is: " + nums.Min());


        }

        private static List<Int64> GetSmallestMultiple()
        {
            List<Int64> r = new List<Int64>();
            Int64 t = 0;
            for (int i = 20; i > 10; i--)
            {
                for (int k = 0; k < i; k--)
                {
                    t = i * k;
                    if (CheckNum(t))
                    {
                        r.Add(t);
                        JCCSTools.Tools.printw("ADDING: " + t);
                    }
                }
            }
            return r;
        }

        private static Boolean CheckNum(Int64 t)
        {
            for (int i = 1; i < 20; i++)
            {
                if (t % i != 0)
                {
                    return false;
                }
            }
            return true;
        }


        //public static List<int> GetDivisorIntersection()
        //{
        //    List<int> r = new List<int>();
        //    Dictionary<int, List<int>> d = new Dictionary<int, List<int>>();
        //    Int64 upperBound = JCCSTools.Tools.factorial(20);
        //    JCCSTools.Tools.printw("20 factorial is " + upperBound);
        //    for(int i = 1;i<20;++i)
        //    {
        //        d.Add(i,new List<int>(0));
        //        for (int j = 1; j<=i; j++)
        //        {
        //            d[i].Add(j*i);

        //        }
        //    } 
        //    return r;
        //}
    }
}
