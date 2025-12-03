namespace AdventOfCode.Cmd.Task3
{
    public class Task3A : IAdventTask
    {
        public long Run(IEnumerable<string> data)
        {
            var sum = 0L;
            foreach (var item in data)
            {
                //foreach(var character in item)
                //{

                //}
                //var t = item.Select(i => ((int)i - 60)).ToArray();

                // Dont bother converting to int value until the end, otherwise is just back and forth
                var rowWithoutLast = item[0..^1];
                var largestNumber = rowWithoutLast.OrderByDescending(i => i)
                    .First();
                var largestNumberPos = item.IndexOf(largestNumber);
                //if (largestNumberPos == item.Length)
                //{
                //    throw new Exception("Not handling this yet");
                //}
                var largestafterFirst = item[(largestNumberPos+1)..].OrderByDescending(i => i).First();
                var zeroCharPos = (int)'0';

                var num = ((largestNumber - zeroCharPos) * 10) + largestafterFirst - zeroCharPos;
                sum += num;
            }
            return sum;
        }
    }
}
