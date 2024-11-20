using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj4
{
    public class Graf
    {
        List<NodeG> nodes = new List<NodeG>();

        public void dodajSasiada(NodeG sasiad)
        {
            if (!this.nodes.Contains(sasiad))
            {
                this.nodes.Add(sasiad);
            }
        }
        //to i Huffman
        public void wezlyOdwiedzone()
        {

        }
    }

}
