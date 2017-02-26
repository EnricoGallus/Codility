using System.Linq;

namespace Iteration
{
    public class Solution2
    {
        public int solution(int[] A)
        {
            return A.GroupBy(x => x).First(x => x.Count() % 2 == 1).First();
        }
    }
}