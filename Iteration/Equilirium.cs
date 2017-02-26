using System;
using System.Collections.Generic;
using System.Linq;

namespace Iteration
{
    public class Test
    {
        public int solution(int N, int[] A) {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
//            if (A.Length == 0)
//            {
//                return -1;
//            }
//
//            var list = A.Select(Convert.ToInt64).ToArray();
//            var right = list.Sum(x => x) - A.First();
//            var left = 0;
//
//            for (int i = 0; i < list.Length; i++)
//            {
//                left += A[i];
//                right -= A[i];
//
//                if ((i == 0 || i == A.Length) && left == 0)
//                {
//                    return 0;
//                }
//
//                var equilirium = left == right;
//                if (equilirium && i > 0 && i < A.Length)
//                {
//                    return i;
//                }
//            }
//
//            return -1;
            var counters = new int[N];
            for (int k = 0; k < A.Length; k++)
            {
                var x = A[k];
                if (x == N + 1)
                {
                    var maxCountGroups = counters.GroupBy(counter => counter);
                    if (maxCountGroups.Count() != 1)
                    {
                        counters = Enumerable.Repeat(maxCountGroups.Select(s => s.Max()).First(), N).ToArray();
                    }
                }
                else if (x >= 1 && x <= N)
                {
                    counters[x - 1]++;
                }
            }

            return counters;


        }

    }
}