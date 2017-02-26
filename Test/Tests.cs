using Iteration;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Tests
    {
        [TestCase(9, 2)]
        [TestCase(529, 4)]
        [TestCase(20, 1)]
        [TestCase(15, 0)]
        public void Iteration_9(int number, int result)
        {
            Assert.That(result, Is.EqualTo(new Solution().solution(number)));
        }

        [Test]
        public void OddNumber()
        {
            var test = new int[] {9, 3, 9, 3, 9, 7, 9};
            Assert.That(7, Is.EqualTo(new Solution2().solution(test)));
        }

        [Test]
        public void CopyArray()
        {
            var test = new int[] {3, 8, 9, 7, 6};
            var result = new Solution3().solution(test, 3);
            Assert.That(result, Is.EquivalentTo(new [] { 9, 7, 6, 3, 8 }));
        }

        [Test]
        public void CopyArray2()
        {
            var test = new int[] {3, 8, 9, 7, 6};
            var result = new Solution3().solution(test, 6);
            Assert.That(result, Is.EquivalentTo(new [] { 9, 7, 6, 3, 8 }));
        }
    }
}