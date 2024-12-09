using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kol1sm
{
    public partial class Form1 : Form
    {
        static int[] tab = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public static void RandTab(int n, int a, int b)
        {
            tab = new int[n];
            Random rand = new Random();
            b++;
            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next(a, b);
            }
        }

        public static void BubbleSort(int[] tab)
        {
            int temp;
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
                }
            }
        }

        public static void InsertSort(int[] tab)
        {
            int temp;
            for (int i = 1; i < tab.Length; i++)
            {
                int j = i;
                while(j > 0 && tab[j - 1] > tab[j])
                {
                    temp = tab[j];
                    tab[j] = tab[j - 1];
                    tab[j - 1] = temp;
                    j--;
                }
            }
        }

        public static void MergeSort(int[] tab, int l, int p)
        {
            if(l < p)
            {
                int mid = (l + p) / 2;

                MergeSort(tab, l, mid);
                MergeSort(tab, mid + 1, p);
                Merge(tab, l, p, mid);
            }
        }
        public static void Merge(int[] tab, int l, int p, int mid)
        {
            int lIndex = l, pIndex = mid + 1, mIndex = 0;

            int[] merged = new int[p - l + 1];

            while (lIndex <= mid && pIndex <= p)
            {
                if (tab[lIndex] <= tab[pIndex])
                {
                    merged[mIndex++] = tab[lIndex++];
                }
                else
                {
                    merged[mIndex++] = tab[pIndex++];
                }
            }

            while (lIndex <= mid)
            {
                merged[mIndex++] = tab[lIndex++];
            }

            while (pIndex <= p)
            {
                merged[mIndex++] = tab[pIndex++];
            }

            for(int i = 0; i < merged.Length; i++)
            {
                tab[l + i] = merged[i];
            }

        }

        public static void QuickSort(int[] tab, int l, int p)
        {
            if(l < p)
            {
                int pivot = tab[(l + p) / 2];
                int index = Divide(tab, l, p, pivot);

                QuickSort(tab, l, index - 1);
                QuickSort(tab, index, p);
            }
        }

        public static int Divide(int[] tab, int l, int p, int pivot)
        {
            while(l <= p)
            {
                while (tab[l] < pivot)
                {
                    l++;
                }

                while (tab[p] > pivot)
                {
                    p--;
                }

                if (l <= p)
                {
                    int temp = tab[l];
                    tab[l] = tab[p];
                    tab[p] = temp;

                    l++;
                    p--;
                }
            }
            return l;
        }

        public static void CountingSort(int[] tab)
        {
            int max = tab.Max();
            int[] tab2 = new int[max + 1];

            for (int i = 0; i < tab.Length; i++)
            {
                tab2[tab[i]]++;
            }

            for(int i = 0, j = 0; i <= max; i++)
            {
                while (tab2[i] > 0)
                {
                    tab[j] = i;
                    j++;
                    tab2[i]--;
                }
            }
        }

        public static String PrintTab(int[] tab)
        {
            String s = "";
            for(int i = 0; i < tab.Length; i++)
            {
                s += tab[i] + " ";
            }
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandTab(5, 1, 9);
            label1.Text = PrintTab(tab);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BubbleSort(tab);
            label2.Text = PrintTab(tab);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertSort(tab);
            label3.Text = PrintTab(tab);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MergeSort(tab, 0, tab.Length - 1);
            label4.Text = PrintTab(tab);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuickSort(tab, 0, tab.Length - 1);
            label5.Text = PrintTab(tab);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CountingSort(tab);
            label6.Text = PrintTab(tab);
        }
    }
}
