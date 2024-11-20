namespace zaj4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Graf g1 = new Graf();
            NodeG ng1 = new NodeG(1);

            g1.dodajSasiada(ng1);

//            ApplicationConfiguration.Initialize();
//            Application.Run(new Form1());
        }
    }
}