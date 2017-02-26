using System.Collections.Generic;
using System.Linq;

namespace Iteration
{
    public class MinSlice
    {
        public int solution(int[] A) {
            // calculate prefix sum
            int n = A.Length;
            var slices = new int[n];

            for (int i=0; i < n; i++)
            {
                slices[i] = i == 0 ? 0 : slices[i - 1] + A[i];
            }

            int start = 0;
            int average = int.MaxValue.Max();

            for (int j=0; j < n - 1; j++)
            {
                var twoPieces = slices[j] + A[j + 1] / (2);
                if (twoPieces < average)
                {
                    average = twoPieces;
                    start = j;
                }

                var threePieces = slices[j] + A[j + 1] + (j + 2 > A.Length ? 0 : A[j + 2]);
                if (threePieces < average)
                {
                    average = threePieces;
                    start = j;
                }
            }

            return start;
        }
    }
}