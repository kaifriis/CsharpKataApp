using System;
using System.Collections.Generic;
using System.Linq;

namespace IndiciesOfTwoNumbers 
{ 
    public static class EffectiveSolution
    {
       
        public static int[]? FindTwoPairSum(int[] numbers, int target)
        {
            var toFindMap = new Dictionary<int, int>();

            for(var p1 = 0; p1 < numbers.Length; p1++)
            {
                if (toFindMap.TryGetValue(numbers[p1], out int currentValue))
                {
                    return new[] { currentValue, p1 };
                }
                var numberToFind = target-numbers[p1];
                toFindMap.Add(numberToFind, p1);
            }
            return null;
        }
    }
}