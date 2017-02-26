using System;
using System.Collections.Generic;
using System.Linq;

namespace Iteration
{
    public class MaxTriplet
    {
        public int solution(int[] A)
        {
            int length = A.Length;
            int maxA = Int32.MinValue;
            int maxB = Int32.MinValue;
            int maxC = Int32.MinValue;
            int minA = Int32.MaxValue;
            int minB = Int32.MaxValue;
            for (int i = 0; i < length; i++)
            {
                if (A[i] > maxA)
                {
                    maxC = maxB;
                    maxB = maxA;
                    maxA = A[i];
                }

                else if (A[i] > maxB)
                {
                    maxC = maxB;
                    maxB = A[i];
                }

                else if (A[i] > maxC)
                {
                    maxC = A[i];
                }

                if (A[i] < minA)
                {
                    minB = minA;
                    minA = A[i];
                }

                else if (A[i] < minB)
                {
                    minB = A[i];
                }
            }

            return Math.Max(minA * minB * maxA, maxA * maxB * maxC);
        }
    }
}