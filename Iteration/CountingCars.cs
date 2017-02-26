using System.Linq;

namespace Iteration
{
    public class CountingCars
    {
        public int solution(int[] A)
        {
            long passingCars = 0;
            long westraveling = A.Sum();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 1)
                {
                    westraveling--;
                    continue;
                }

                passingCars += westraveling;

                if (passingCars > 1000000000)
                {
                    return -1;
                }
            }

            return (int)passingCars;
        }
    }
}