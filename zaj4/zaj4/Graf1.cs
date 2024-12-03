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
            int newNodesCount = 0;
            if (!nodes.Contains(k.start))
            {
                newNodesCount++;
            }


            if (!nodes.Contains(k.end))
            {
                newNodesCount++;
            }

            return newNodesCount;
        }

        public void Add(Edge k)
        {
            if (!nodes.Contains(k.start))
            {
                nodes.Add(k.start);
            }

            
            if (!nodes.Contains(k.end))
            {
                nodes.Add(k.end);
            }

           
            edges.Add(k);
        }

        public void Join(Graf1 g1)
        {
            for(int i = 0; i < g1.edges.Count; i++)
            {
                this.Add(g1.edges[i]);
            }

        }
    }
}
