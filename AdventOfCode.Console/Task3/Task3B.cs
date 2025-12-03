
namespace AdventOfCode.Cmd.Task3
{
    public class Task3B : IAdventTask
    {
        public long Run(IEnumerable<string> data)
        {
            var zeroCharPos = (int)'0';
            var sum = 0L;
            foreach (var item in data)
            {
                var lastNumberIndex = -1;
                var rowTotal = 0L;
                for (var battery = 12; battery >0; battery--)
                {
                    // Dont bother converting to int value until the end, otherwise is just back and forth
                    var rowWithoutLast = item[(lastNumberIndex + 1)..^(battery - 1)];
                    var largestNumber = rowWithoutLast.OrderByDescending(i => i)
                        .First();
                    lastNumberIndex = item.IndexOf(largestNumber, lastNumberIndex + 1);
                    rowTotal += ((largestNumber - zeroCharPos) * (long)Math.Pow(10, battery - 1));
                }
                Console.WriteLine(rowTotal);
                sum += rowTotal;

            }
            return sum;
        }
    }
}
