using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj3
{
    public class List
    {
        public Node head;
        public Node tail;
        public int counter;

        public void Add(int num)
        {
            Node n = new Node(num);
            if(tail == null)
            {
                tail = n;
                head = n;
            }
            else
            {
                head.prev = n;
                n.next = head;
                head = n;
            }
            counter++;
        }

        public void AddLast(int num)
        {
            Node n = new Node(num);
            if (tail == null)
            {
                tail = n;
                head = n;
            }
            else
            {
                tail.next = n;
                n.prev = tail;
                tail = n;
            }
            counter++;
        }
        public void DelFirst()
        {
            if (head == tail)
            {
                tail = null;
                head = null;
            }
            else
            {
                head = head.next;
                head.prev = null;
            }
            counter--;
        }

        public void DelLast()
        {
            if (head == tail)
            {
                tail = null;
                head = null;
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
            }
            counter--;
        }

        public void PrintAllElements()
        {
            Node current = head;
            string lista = null;
            while(current != null)
            {
                lista += current.data.ToString();
                current = current.next;
            }
            MessageBox.Show(lista);
        }

        public int Get(int num)
        {
            Node current = head;
            int index = 0;

            while (current != null)
            {
                if (index == num)
                {
                    return current.data;
                }
                current = current.next;
                index++;
            }
            return current.data;
        }
    

    //class classMain
    //{
    //        static void Main()
    //        {
    //            List l1 = new List();
    //            l1.Add(5);
    //            l1.Add(5);
    //            l1.AddLast(2);
    //            l1.AddLast(1);
    //            l1.AddLast(1);
    //            l1.AddLast(5);
                

    //            //l1.DelLast();
    //            //l1.DelFirst();
    //            //l1.PrintAllElements();
    //            MessageBox.Show(l1.Get(3).ToString());
    //        }
    //    }
    }
}
