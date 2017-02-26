using System;

namespace Iteration
{
    public class Solution3 {
        public int[] solution(int[] A, int K) {
            // secure that K does not exceed A length
            int correctedK = K % A.Length;

            int[] destination = new int[A.Length];

            //Console.WriteLine(correctedK);

            // copy after K
            Array.Copy(A, A.Length - correctedK, destination, 0, correctedK);
            // copy before K
            Array.Copy(A, 0, destination, correctedK, A.Length - correctedK);

            return destination;
        }
    }
}