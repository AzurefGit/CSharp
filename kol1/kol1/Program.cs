using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kol1
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());


            int[] tab = Form1.RandTab(9, 1, 5);
            var unsortedTab = Form1.PrintTab();
            String n = "MS";
            switch (n)
            {
                case "BS":
                    Form1.BubbleSort(tab);
                    var bSTab = Form1.PrintTab();
                    MessageBox.Show(unsortedTab + " -> " + bSTab);
                    break;

                case "IS":
                    Form1.InsertSort(tab);
                    var iSTab = Form1.PrintTab();
                    MessageBox.Show(unsortedTab + " -> " + iSTab);
                    break;

                case "QS":
                    Form1.QuickSort(tab, 0, tab.Length - 1);
                    var qSTab = Form1.PrintTab();
                    MessageBox.Show(unsortedTab + " -> " + qSTab);
                    break;

                case "MS":
                    Form1.MergeSort(tab, 0, tab.Length - 1);
                    var mSTab = Form1.PrintTab();
                    MessageBox.Show(unsortedTab + " -> " + mSTab);
                    break;

                case "CS":
                    Form1.CountingSort(tab);
                    var cSTab = Form1.PrintTab();
                    MessageBox.Show(unsortedTab + " -> " + cSTab);
                    break;
            }


            
        }
    }
}
