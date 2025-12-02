using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Cmd.Task2
{
    public class Task2B : IAdventTask
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
                    Console.WriteLine(ser);
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
            var length = s.Length;
            var halfLength = length / 2;

            for(var i = 1; i <= halfLength; i++)
            {
                if (length % i != 0) continue;
                var possibleRepeats = length / i;

                var start = s[0..i];

                var fullRepeat = string.Concat(Enumerable.Repeat(start, possibleRepeats));
                if (fullRepeat == s) return false;
            }

            return true;
        }
    }
}
