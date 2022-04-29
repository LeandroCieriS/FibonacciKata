using System.Reflection.Metadata.Ecma335;
using NUnit.Framework;

namespace FibonacciKata
{
    public class FibonacciShould
    {
        [Test]
        [TestCase(0,0)]
        [TestCase(1,1)]
        [TestCase(1,2)]
        [TestCase(2,3)]
        [TestCase(3,4)]
        [TestCase(5,5)]
        [TestCase(8,6)]
        [TestCase(34,9)]
        public void return_expected_when_input_is_introduced(int expected, int input)
        {
            Assert.AreEqual(expected, Fibonacci.Calculate(input));
        }
        
    }

    public class Fibonacci
    {
        public static int Calculate(int input)
        {
            if (input > 2) return Calculate(input-1) + Calculate(input-2);
            if (input is 1 or 2) return 1;
            return 0;
        }
    }
}