using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj4
{
    internal class NodeGW
    {
        public int Id { get; set; }

        public static implicit operator NodeGW(NodeG1 v)
        {
            throw new NotImplementedException();
        }
    }
}
