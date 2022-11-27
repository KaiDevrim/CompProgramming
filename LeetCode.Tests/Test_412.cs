using NUnit.Framework;

namespace LeetCode.Tests;

using Solutions.Solutions;

[TestFixture]
public class Test_412
{
    private FizzBuzzSolution _solution;

    [SetUp]
    public void Setup()
    {
        _solution = new FizzBuzzSolution();
    }

    [Test]
    public void Test1()
    {
        IList<string> fizzArray = new List<string>() {"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"};
        Assert.That(_solution.FizzBuzz(15), Is.EqualTo(fizzArray));
    }
}