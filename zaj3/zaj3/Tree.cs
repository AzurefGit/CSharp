using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zaj3
{
    public class Tree
    {
        NodeT root;


        public NodeT ZnajdzRodzica(NodeT dziecko)
        {
            var temp = this.root;
            while (true)
            {
                if (dziecko.data < temp.data)
                {
                    if (temp.left == null)
                    {
                        return temp;
                    }
                    else
                    {
                        temp = temp.left;
                    }
                }
                else
                {
                    if (temp.right == null)
                    {
                        return temp;
                    }
                    else
                    {
                        temp = temp.right;
                    }
                }
            }
        }

        public NodeT Add(int num)
        {
            var dziecko = new NodeT(num);
            if(this.root == null)
            {
                this.root = dziecko; 
            }
            else
            {
                var rodzic = this.ZnajdzRodzica(dziecko);
                if (dziecko.data < rodzic.data)
                {
                    rodzic.PolaczLewe(dziecko);
                }
                else
                {
                    rodzic.PolaczPrawe(dziecko);
                }
            }
            return dziecko;
        }

        public void InOrder(NodeT node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                InOrder(node.left);
                MessageBox.Show(node.data + " ");
                InOrder(node.right);
            }
        }

        public void InOrder()
        {
            InOrder(root);
        }

        public void Delete(int num)
        {
            NodeT current = root;
            NodeT rodzic = null;

            //Szukanie węzła
            while(current.data != num && current != null)
            {
                rodzic = current;
                if (num < current.data)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }
            }

            if(current == null)
            {
                MessageBox.Show("Nic tu nie ma");
                return;
            }

            //Bez dziecka
            if(current.left == null && current.right == null)
            {
                if(current == null)
                {
                    root = null;
                }
                else if(rodzic.left == current)
                {
                    rodzic.left = null;
                }
                else
                {
                    rodzic.right = null;
                }
            }

            //Z 1 dzieckiem
            else if(current.left == null || current.right == null)
            {
                var dziecko = new NodeT(num);
                if (current == root)
                {
                    root = dziecko;
                }
                else if(rodzic.left == current)
                {
                    rodzic.PolaczLewe(dziecko);
                }
                else
                {
                    rodzic.PolaczPrawe(dziecko);
                }
            }

            //2 dzieci
            else
            {
                NodeT nastepcaRodzica = current;
                NodeT nastepca = current.right;

                while(nastepca.left != null)
                {
                    nastepcaRodzica = nastepca;
                    nastepca = nastepca.left;
                }

                current.data = nastepca.data;

                if (nastepcaRodzica.left == nastepca)
                {
                    nastepcaRodzica.left = nastepca.right;
                }
                else
                {
                    nastepcaRodzica.right = nastepca.right;
                }
            }
        }

        private void RemoveElementO(NodeT n)
        {
            if(this.root == n)
                this.root = null;
            else
            {
                var rodzic = n.rodzic;

                if(rodzic.left == n)
                    rodzic.left = null;

                else if(rodzic.right == n)
                    rodzic.right = null;

                n.rodzic = null;
            }
        }

        private void RemoveElement1(NodeT n)
        {
            NodeT dziecko = null;
            if(n.left != null)
            {
                dziecko = n.left;
            }
            else
            {
                dziecko = n.right;
            }

            this.RemoveElementO(dziecko);

            var rodzic = n.rodzic;
            this.RemoveElementO(n);

            dziecko.rodzic = rodzic;

            if(rodzic != null)
            { 
                if(rodzic.data > dziecko.data)
                {
                    rodzic.left = dziecko;
                }
                else
                {
                    rodzic.right = dziecko;
                }
            }

            else
            {
                this.root = dziecko;
            }
        }

        NodeT Min(NodeT n)
        {
            var wynik = n;
            while (wynik.left != null)
            {
                wynik = wynik.left;
            }
            return wynik;
        }

        private void RemoveElement(NodeT n)
        {
            switch (n.GetLiczbaDzieci)
            {
                case 0:
                    this.RemoveElementO(n);
                    break;
                
                case 1:
                    this.RemoveElement1(n);
                    break;

                case 2:
                    var k = this.Min(n.right);
                    this.RemoveElement(k);

                    k.left = n.left;
                    n.left = null;
                    k.right = n.right;
                    n.right = null;
                    k.rodzic = n.rodzic;
                    n.rodzic = null;

                    break;
            }
        }
    }

    class classMain
    {
        static void Main()
        {
            Tree t = new Tree();

            t.Add(5);
            t.Add(6);
            t.Add(4);
            t.Add(7);
            t.Add(3);

            t.InOrder();

           
            t.Delete(5);
            t.InOrder();
        }
    }
}