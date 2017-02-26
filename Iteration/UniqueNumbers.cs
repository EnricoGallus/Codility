using System.Linq;

namespace Iteration
{
    public class Class1
    {
        public int solution(int N) {
            int length = N.ToString().Length;
            var uniqueNumbers = N.ToString().GroupBy(x => x).Distinct().ToList().Select(x => int.Parse(x));

            long divident = 1;
            foreach (var number in uniqueNumbers)
            {
                divident *= Factorial((long)number);
            }

            return (int)(Factorial((long)length) / divident);
        }

        private long Factorial(long n)
        {
            return n == 0 ? 1 : n * Factorial(n - 1);
        }
    }
}