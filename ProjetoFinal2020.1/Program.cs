using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal2020._1
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            DataGridTableStyle ts1 = new DataGridTableStyle();
            ts1.MappingName = "Customers";

            DataGridBoolColumn myDataCol = new DataGridBoolColumn();
            myDataCol.HeaderText = "My New Column";
            myDataCol.MappingName = "Current";

            ts1.GridColumnStyles.Add(myDataCol);
        }
    }
}
