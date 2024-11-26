using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace zaj2
{
    public partial class Form1 : Form
    {
        int[] tab = null;
        int[] Tab
        {
            get 
            { 
                return tab;
            }
            set 
            {
                tab = value;
                bool isTabEmpty = tab == null || tab.Length == 0;
                button3.Enabled = !isTabEmpty;
                button4.Enabled = !isTabEmpty;
                button5.Enabled = !isTabEmpty;
                button6.Enabled = !isTabEmpty;
                button7.Enabled = !isTabEmpty;
            }
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        public void RandTab(int n, int a, int b)
        {
            Tab = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                tab[i] = rand.Next(a, b);
            }
        }

        public void Convert()
        {
            string input = textBox1.Text;
            Tab = input.Split(',', ' ').Select(int.Parse).ToArray();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tab = new int[0];
        }

        static void BubbleSort(int[] tab)
        {
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
            if (p < r)
            {
                int q = (p + r) / 2;
                MergeSort(tab, p, q);
                MergeSort(tab, q + 1, r);
                Merge(tab, p, q, r);
            }
        }

        static void Merge(int[] tab, int p, int q, int r)
        {
            int lIndex = p;
            int rIndex = q + 1;

            int[] merged = new int[r - p + 1];
            int mergedIndex = 0;

            while (lIndex <= q && rIndex <= r)
            {
                if (tab[lIndex] <= tab[rIndex])
                {
                    merged[mergedIndex++] = tab[lIndex++];
                }
                else
                {
                    merged[mergedIndex++] = tab[rIndex++];
                }
            }

            while (lIndex <= q)
            {
                merged[mergedIndex++] = tab[lIndex++];
            }

            while (rIndex <= r)
            {
                merged[mergedIndex++] = tab[rIndex++];
            }

            for (int i = 0; i < merged.Length; i++)
            {
                tab[p + i] = merged[i];
            }
        }

        static void QuickSort(int[] tab, int l, int p)
        {
            if (l < p)
            {
                int pivot = tab[(l + p) / 2];
                int index = Podzial(tab, l, p, pivot);

                QuickSort(tab, l, index - 1);
                QuickSort(tab, index, p);
            }

        }

        static int Podzial(int[] tab, int l, int p, int pivot)
        {
            while (l <= p)
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

        static void CountingSort(int[] tab)
        {
            int max = tab.Max();
            int[] tab2 = new int[max + 1];

            for(int i = 0; i < tab.Length; i++)
            {
                tab2[tab[i]]++;
            }

            for (int i = 0, j = 0; i <= max; i++)
            {
                while (tab2[i] > 0)
                {
                    tab[j] = i;
                    j++;
                    tab2[i]--;
                }
            }
        }


        static string TabToString(int[] tab, System.Windows.Forms.Label label)
        {
            string text = string.Join(", ", tab);
            Size textSize = TextRenderer.MeasureText(text, label.Font);

            if (textSize.Width > label.Width)
            {
                string shortText = text;
                while (textSize.Width > label.Width && shortText.Length > 0)
                {
                    shortText = shortText.Substring(0, shortText.Length - 1);
                    textSize = TextRenderer.MeasureText(shortText + "...", label.Font);
                }
                return shortText + "...";
            }
            return text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandTab((int)numericUpDown1.Value, 0, 500);
            label1.Text = TabToString(tab, label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Convert();
            label2.Text = TabToString(tab, label2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sTab = (int[])Tab.Clone();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            BubbleSort(sTab);
            watch.Stop();
            label5.Text = TabToString(sTab, label5);
            label4.Text = watch.Elapsed.TotalMilliseconds.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int[] sTab = (int[])Tab.Clone();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            InsertSort(sTab);
            watch.Stop();
            label5.Text = TabToString(sTab, label5);
            label4.Text = watch.Elapsed.TotalMilliseconds.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int[] sTab = (int[])Tab.Clone();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            MergeSort(sTab, 0, sTab.Length - 1);
            watch.Stop();
            label5.Text = TabToString(sTab, label5);
            label4.Text = watch.Elapsed.TotalMilliseconds.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] sTab = (int[])Tab.Clone();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            QuickSort(sTab, 0, sTab.Length - 1);
            watch.Stop();
            label5.Text = TabToString(sTab, label5);
            label4.Text = watch.Elapsed.TotalMilliseconds.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] sTab = (int[])Tab.Clone();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            CountingSort(sTab);
            watch.Stop();
            label5.Text = TabToString(sTab, label5);
            label4.Text = watch.Elapsed.TotalMilliseconds.ToString();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
