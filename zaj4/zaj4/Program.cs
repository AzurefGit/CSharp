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
            //Graf g1 = new Graf();

            //NodeG ng1 = new NodeG(1);
            //NodeG ng2 = new NodeG(2);
            //NodeG ng3 = new NodeG(3);

            //g1.dodajSasiada(ng1, ng2);
            //g1.dodajSasiada(ng2, ng3);
            //g1.dodajSasiada(ng3, ng3);

            //MessageBox.Show(g1.ToString());

            //-----------------------------------

            NodeG1 node1 = new NodeG1(1);
            NodeG1 node2 = new NodeG1(2);
            NodeG1 node3 = new NodeG1(3);
            NodeG1 node4 = new NodeG1(4);

            Edge edge1 = new Edge(node1, node2, 4);
            Edge edge2 = new Edge(node1, node3, 1);
            Edge edge3 = new Edge(node2, node3, 2);
            Edge edge4 = new Edge(node2, node4, 5);

            Graf1 graf = new Graf1(edge1);
            graf.Add(edge2);
            graf.Add(edge3);
            graf.Add(edge4);



            //            ApplicationConfiguration.Initialize();
            //            Application.Run(new Form1());
        }
    }
}