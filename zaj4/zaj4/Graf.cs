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

            if (!sasiad.sasiedni.Contains(this.nodes[0]))
            {
                sasiad.sasiedni.Add(this.nodes[0]);
            }
        }
        public override string ToString()
        {
            string wynik = "";
            foreach (var node in nodes)
            {
                wynik += node.ToString() + " ";
            }
            return wynik;
        }
        //to i Huffman//
        public void wezlyOdwiedzone()
        {

        }
    }

}
