using System.Diagnostics;

namespace AdventOfCode.Cmd.Task1
{
    public class Task1A
    {
        public int Run(IEnumerable<string> data)
        {
            var movements = data
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .Select(l => ParseLine(l))
                .ToArray();

            var pos = 50;
            var count = 0;

            foreach(var movement in movements)
            {
                pos += movement.DirectionInt;

                while(pos >= 100) { pos -= 100; }
                while(pos < 0) { pos += 100; }

                if (pos == 0)
                {
                    count++;
                }
            }

            return count;
        }

        enum Direction
        {
            Left,
            Right
        };

        private record Movement(Direction Direction, int Distance)
        {
            public int DirectionInt
            {
                get
                {
                    if (Direction == Direction.Right) return Distance;
                    else return -Distance;
                }
            }
        }

        private static Movement ParseLine(string line)
        {
            var dir = line[0] == 'L' ? Direction.Left : Direction.Right;
            var distance = int.Parse(line[1..]);
            return new Movement(dir, distance);
        }
    }
}
