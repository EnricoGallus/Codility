using System.Linq;

namespace Iteration
{
    public class Distinct
    {
        public int solution(int[] A)
        {
            return A.GroupBy(x => x).Count();
        }
    }
}