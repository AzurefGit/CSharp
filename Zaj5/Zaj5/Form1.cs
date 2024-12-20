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
        char symbol;

        public NodeTS(char symbol, int czestosc) : base(czestosc)
        {
            this.symbol = symbol;
        }
    }

    public class Program
    {
        public static void Main()
        {
            var lista = new List<NodeT>();
            lista = lista.OrderBy(n => n.czestosc).ToList();

        }
        
    }
}
