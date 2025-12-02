using AdventOfCode.Cmd.Task1;
using Shouldly;

namespace AdventOfCode.Tests
{
    public class Task1ATests
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

            var task = new Task1A();
            var result = task.Run(testContent);

            result.ShouldBe(3);
        }
    }
}