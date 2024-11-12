using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj3
{
    public class NodeT
    {
        public NodeT left;
        public NodeT right;
        public NodeT rodzic;
        public int data;

        public NodeT(int data)
        {
            this.left = null;
            this.right = null;
            this.rodzic = null;

            this.data = data;
        }

        public void PolaczLewe(NodeT dziecko)
        {
            this.left = dziecko;
            if (dziecko != null)
            {
                dziecko.rodzic = left;
            }
        }

        public void PolaczPrawe(NodeT dziecko)
        {
            this.right = dziecko;
            if (dziecko != null)
            {
                dziecko.rodzic = right;
            }
        }
    }
}
