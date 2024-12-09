using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kol1sm
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
            Application.Run(new Form1());

            //var tab = Form1.RandTab(5, 1, 9);
            //var unTab = Form1.PrintTab(tab);
            //Form1.MS(tab, 0, tab.Length - 1);
            //var sTab = Form1.PrintTab(tab);
            //MessageBox.Show(unTab + " --> " + sTab);
        }
    }
}
