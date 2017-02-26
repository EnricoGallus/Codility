using System;
using System.Linq;

namespace Iteration
{
    public class Solution
    {
        public int solution(int N)
        {
            var binary = Convert.ToString(N, 2).TrimEnd('0');

            return binary.Split('1').Where(x => !x.Contains('1')).Select(s => s.Count()).Max();
        }
    }
}