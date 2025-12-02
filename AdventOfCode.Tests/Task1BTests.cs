using AdventOfCode.Cmd.Task1;
using NUnit.Framework;
using Shouldly;

namespace AdventOfCode.Tests
{
    public class Task1BTests
    {
        [Test]
        public void Test1()
        {
            var testContent = """
                L68
                L30
                R48
                L5
                R60
                L55
                L1
                L99
                R14
                L82
                """.Split(Environment.NewLine);

            var task = new Task1B();
            var result = task.Run(testContent);

            result.ShouldBe(6);
        }

        
        [TestCase("L50", 1)]
        [TestCase("R50", 1)]
        [TestCase("L51", 1)]
        [TestCase("R51", 1)]
        [TestCase("L151", 2)]
        [TestCase("R151", 2)]
        public void Test2(string data, int expectedCount)
        {
            var testContent = data.Split(Environment.NewLine);

            var task = new Task1B();
            var result = task.Run(testContent);

            result.ShouldBe(expectedCount);
        }
    }
}