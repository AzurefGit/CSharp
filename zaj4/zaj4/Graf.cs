using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj4
{
    public class Graf
    {
        List<NodeG> nodes = new List<NodeG>();

        public void dodajSasiada(NodeG sasiad1, NodeG sasiad2)
        {
            if (!this.nodes.Contains(sasiad1))
            {
                this.nodes.Add(sasiad1);
            }

            if (!this.nodes.Contains(sasiad2))
            {
                this.nodes.Add(sasiad2);
            }

            if (!sasiad1.sasiedni.Contains(sasiad2))       
            {
                sasiad1.sasiedni.Add(sasiad2);
            }

            if (!sasiad2.sasiedni.Contains(sasiad1))
            {
                sasiad2.sasiedni.Add(sasiad1);
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
        
        public void wezlyOdwiedzone(NodeG start, List<NodeG> visited)
        {
            if (!visited.Contains(start))
            {
                visited.Add(start);
                MessageBox.Show("Odwiedzono: " + start.data);
                foreach (var sasiad in start.sasiedni)
                {
                    wezlyOdwiedzone(sasiad, visited);
                }
            }
        }
    }

}
