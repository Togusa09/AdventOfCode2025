using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Cmd.Task2
{
    public class Task2A : IAdventTask
    {
        public long Run(IEnumerable<string> data)
        {
            var singleLineData = string.Join("", data);
            var ranges = singleLineData.Split(',').Select(r => ParseRange(r));

            var count = 0L;

            foreach(var range in ranges)
            {
                var invalidSerials = GenerateRange(range)
                    .Where(s => !IsValidSerial(s))
                    .ToArray();

                foreach(var ser in invalidSerials)
                {
                    count += ser;
                }
            }

            return count;
        }

        private Range ParseRange(string data)
        {
            var t = data.Split('-');

            return new Range(long.Parse(t[0]), long.Parse(t[1]));
        }

        private record Range(long Start, long End);

        private IEnumerable<long> GenerateRange(Range range)
        {
            for(var s = range.Start; s <= range.End; s++)
            {
                yield return s;
            }
        }

        private bool IsValidSerial(long serial)
        {
            var s = serial.ToString();
            var start = s[..(s.Length / 2)];
            var end = s[(s.Length / 2)..];

            //Console.WriteLine(start, end);

            return start != end;
        }
    }
}
