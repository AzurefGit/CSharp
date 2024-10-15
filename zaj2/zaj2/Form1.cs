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
        private int[] tab;
        public Form1()
        {
            InitializeComponent();
            tab = new int[10];
        }

        public void RandTab(int n, int a, int b)
        {
            tab = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                tab[i] = rand.Next(a, b);
            }
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        static void InsertSort(int[] tab)
        {
            int temp;
            for (int i = 1; i < tab.Length; i++)
            {
                int j = i;
                while (j > 0 && tab[j - 1] > tab[j])
                {
                 temp = tab[j - 1];
                 tab[j - 1] = tab[j];
                 tab[j] = temp; 
                 j--;
                }
            }
        }

        static void MergeSort(int[] tab, int p, int r)
        {
            if(p < r)
            {
                int q = (p + r) / 2;
                MergeSort(tab, p, q);
                MergeSort(tab, q + 1, r);
                Merge(tab, p, q, r);
            }
            
        }
        static void Merge(int[] tab, int p, int q, int r)
        {

        }

        static string TabToString(int[] tab)
        {
            return string.Join(", ", tab);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandTab(5, 1, 10);
            label1.Text = TabToString(tab);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sTab = (int[])tab.Clone();
            InsertSort(sTab);
            label2.Text = TabToString(sTab);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sTab = (int[])tab.Clone();
            MergeSort(sTab, 0, sTab.Length - 1);
            label3.Text = TabToString(sTab);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        

    }
}
