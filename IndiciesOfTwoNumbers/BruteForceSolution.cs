using System;
using System.Collections.Generic;
using System.Linq;

namespace IndiciesOfTwoNumbers 
{ 
    public static class BruteForceSolution
    {
        public static void Main(string[] args) {}

        public static int[]? FindTwoPairSum(int[] numbers, int target)
        {
            for(var p1 = 0; p1 < numbers.Length; p1++)
            {
                var numberToFind = target-numbers[p1];
                for (int p2 = p1+1; p2 < numbers.Length; p2++)
                {
                    if (numberToFind == numbers[p2])    
                    {
                        return new[] {p1,p2};
                    }
                }
            }
            return null;
        }
    }
}