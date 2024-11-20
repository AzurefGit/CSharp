using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zaj4
{
    public class NodeG
    {
        List<NodeG> sasiedni = new List<NodeG> ();
        public int data;

        public NodeG(int liczba)
        {
            this.data = liczba;
        }

        public override string ToString()
        {
            return this.data.ToString();
        }

        
    }
}
