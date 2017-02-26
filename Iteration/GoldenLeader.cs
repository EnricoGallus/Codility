namespace Iteration
{
    public class GoldenLeader
    {
        public int execute(int[] A)
        {
            var n = A.Length;
            int size = 0;
            int value = 0;

            for (int i = 0; i < n; i++)
            {
                if (size == 0)
                {
                    size += 1;
                    value = A[i];
                }
                else
                {
                    if (value != A[i])
                    {
                        size -= 1;
                    }
                    else
                    {
                        size += 1;
                    }
                }
            }

            var candidate = -1;
            if (size > 0)
            {
                candidate = value;
            }

            var leader = -1;
            var count = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] == candidate)
                {
                    count += 1;
                }

                if (count > n / 2)
                {
                    leader = candidate;
                }
            }

            return leader;
        }
    }
}