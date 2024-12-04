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
            int counter = 0;
            if (!nodes.Contains(k.start))
            {
                counter++;
            }

            if (!nodes.Contains(k.end))
            {
                counter++;
            }

            return counter;
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

        public Graf1 AlgorytmKruskala()
        {
            
            var krawedzie = this.edges.OrderBy(k->k.weight).ToList;
            var grafy = new List<Graf1>() { new Graf1(krawedzie)[0] };

            for (int i = 1; i < krawedzie.Count; i++)
            {
                var k = krawedzie[i];
                var l = -1;
                for (int j = 0; j < grafy.Count; j++)
                {
                    var g = grafy[j];
                    switch (g.IleNowychWezlow(k))
                    {
                        case 2:
                            grafy.Add(new Graf1(k));
                            j = grafy.Count;
                            break;

                        case 0:
                            j = grafy.Count;
                            break;

                        case 1:
                            if(l == -1)
                            {
                                g.Add(k);
                                l = j;
                            }
                            else
                            {
                                grafy[l].Join(g);
                                grafy.RemoveAt(j);
                                j = grafy.Count;
                            }
                            break;
                    }
                }  
            }

            return grafy[0];
        }
    }
}
