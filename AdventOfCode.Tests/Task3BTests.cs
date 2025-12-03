using AdventOfCode.Cmd.Task3;
using Shouldly;

namespace AdventOfCode.Tests
{
    internal class Task3BTests
    {
        [Test]
        public void Test1()
        {
            var testContent = """
                987654321111111
                811111111111119
                234234234234278
                818181911112111
                """.Split(Environment.NewLine);

            var task = new Task3B();
            var result = task.Run(testContent);

            result.ShouldBe(3121910778619);
        }
    }
}
