﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj2
{
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

}