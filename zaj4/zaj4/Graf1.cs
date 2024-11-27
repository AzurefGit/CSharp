using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj4
{
    internal class Graf1
    {
        public List<NodeG1> nodes = new List<NodeG1>();
        public List<Edge> edges = new List<Edge>();
        public Graf1(Edge k)
        {
            Add(k);
        }

        public int IleNowychWezlow(Edge k)
        {
            //dopisac podobne do Add
        }

        public void Add(Edge k)
        {
            //dopisac i zrobic main
        }

        public void Join(Graf1 g1)
        {
            for(int i = 0; i < nodes.Count; i++)
            {
                this.Add(g1.edges[i]);
            }

        }
    }
}
