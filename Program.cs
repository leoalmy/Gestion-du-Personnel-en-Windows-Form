using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesPerWinForm
{
    internal static class Program
    {
        /// <summary>
        /// Objet de connexion à la base de données
        /// </summary>
        public static SqlConnection connexionBdd;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                connexionBdd = ConnexionBdd.GetDBConnexion();
                connexionBdd.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de connexion à la base de données.\nDétails : " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            fmMenu fmm = new fmMenu();
            fmm.Show();

            Application.Run();
        }
    }
}
