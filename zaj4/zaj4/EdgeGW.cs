using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj4
{
    internal class EdgeGW
    {
        public NodeGW start;
        public NodeGW end;
        public int weight;

        public EdgeGW(NodeGW start, NodeGW end, int weight)
        {
            this.start = start;
            this.end = end;
            this.weight = weight;
        }
    }
}
