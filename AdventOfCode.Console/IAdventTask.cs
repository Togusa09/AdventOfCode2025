using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Cmd
{
    public interface IAdventTask
    {
        long Run(IEnumerable<string> data);
    }
}
