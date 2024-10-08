using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "2, 5, 1, 2, -1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] tab = {2, 5, 1, 2, -1};
            label1.Text += "   ||   ";
            int temp;
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        temp = tab[j + 1];
                        tab[j + 1] = tab[j];
                        tab[j] = temp;
                    }
                }
            }
            for (int i = 0; i < tab.Length; i++)
            {
                label1.Text += tab[i] + ", ";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
