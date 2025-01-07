using System.Xml.Linq;

namespace Zaj5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }

    public class NodeT
    {
        public NodeT lewe;
        public NodeT prawe;
        public NodeT rodzic;
        public int czestosc;

        public NodeT(int czestosc)
        {
            this.czestosc = czestosc;
        }
    }
    public class NodeTS : NodeT
    {
        public char symbol;

        public NodeTS(char symbol, int czestosc) : base(czestosc)
        {
            this.symbol = symbol;
        }
    }

    public class Program2
    {
        public static void Main()
        {
            string tekst = "AABCBAD";


            var czestotliwosci = tekst.GroupBy(c => c)
                                      .Select(g => new NodeTS(g.Key, g.Count()))
                                      .ToList();

            var minHeap = new PriorityQueue<NodeT, int>();
            foreach (var node in czestotliwosci)
            {
                minHeap.Enqueue(node, node.czestosc);
            }

            while (minHeap.Count > 1)
            {
                var lewe = minHeap.Dequeue();
                var prawe = minHeap.Dequeue();

                var nowyWêze³ = new NodeT(lewe.czestosc + prawe.czestosc)
                {
                    lewe = lewe,
                    prawe = prawe
                };

                minHeap.Enqueue(nowyWêze³, nowyWêze³.czestosc);
            }

            var korzen = minHeap.Dequeue();
            var kodyHuffmana = new Dictionary<char, string>();
            GenerujKody(korzen, "", kodyHuffmana);
            MessageBox.Show("Kody Huffmana:");
            foreach (var par in kodyHuffmana)
            {
                MessageBox.Show($"{par.Key}: {par.Value}");
            }

        }

        
        public static void GenerujKody(NodeT node, string kod, Dictionary<char, string> kodyHuffmana)
        {
            if (node is NodeTS leafNode)
            {
                kodyHuffmana[leafNode.symbol] = kod;
            }
            else
            {
                if (node.lewe != null)
                    GenerujKody(node.lewe, kod + "0", kodyHuffmana);
                if (node.prawe != null)
                    GenerujKody(node.prawe, kod + "1", kodyHuffmana);
            }
        }

    }

}
