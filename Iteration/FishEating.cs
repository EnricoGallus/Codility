namespace Iteration
{
    public class FishEating
    {
        public int solution(int[] A, int[] B)
        {
            int count = 0;
            var length = A.Length;
            int? downSwimmingP = null;
            for (int q = 0; q < length; q++)
            {
                if (downSwimmingP.HasValue)
                {
                    if (A[downSwimmingP.Value] > A[q])
                    {
                    }
                    else if (A[q] > A[downSwimmingP.Value])
                    {
                        count++;
                        downSwimmingP = null;
                    }

                    continue;
                }

                if (B[q] == 1)
                {
                    downSwimmingP = q;
                }
                else if (B[q] == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}