using AdventOfCode.Cmd.Task3;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Tests
{
    internal class Task3ATests
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

            var task = new Task3A();
            var result = task.Run(testContent);

            result.ShouldBe(357);
        }
    }
}
