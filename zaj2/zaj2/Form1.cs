using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zaj2
{
    public partial class Form1 : Form
    {
        int[] tab = {3,2,1,4};
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //[3,2]
        }

        static void InsertSort(int[] tab)
        {
            int temp;
            for (int i = 1; i < tab.Length; i++)
            {
                int j = i;
                while (j > 1 && tab[j - 1] > tab[j])
                {
                    if (tab[j] < tab[j - 1])
                    {
                        temp = tab[j - 1];
                        tab[j - 1] = tab[j];
                        tab[j] = temp;
                        
                    }
                    j--;
                }
            }
        }

        static string TabToString(int[] tab)
        {
            string lista = "";
            for(int i = 0; i < tab.Length; i++)
            {
                lista += tab[i] + ", ";
            }
            return lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = TabToString(tab);
            InsertSort(tab);
            label2.Text = TabToString(tab);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
