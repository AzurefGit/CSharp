using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj2
{
    //lista
    public class Node
    {
        public Node next;
        public Node prev;
        public int data;

        public Node(int data)
        {
            this.data = data;
        }
    }

    //drzewo 

    public class NodeT
    {
        public NodeT lewe;
        public NodeT prawe;
        public NodeT rodzic;
        public int data;

        public NodeT(int data)
        {
            lewe = null;
            prawe = null;
            rodzic = null;
            this.data = data;
        }
    }

}