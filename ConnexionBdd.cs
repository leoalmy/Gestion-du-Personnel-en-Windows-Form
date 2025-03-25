using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesPerWinForm
{
    /// <summary>
    /// Classe permettant de se connecter à la base de données
    /// </summary>
    public class ConnexionBdd
    {
        /// <summary>
        /// Méthode permettant de se connecter à la base de données
        /// La connexion est initialisée mais pas ouverte. 
        /// Il est nécessaire d'appeler <c>Open()</c> pour l'ouvrir.
        /// </summary>
        /// <returns>
        /// Retourne un objet <see cref="SqlConnection"/> configuré avec les informations de connexion 
        /// (serveur, base de données, utilisateur, mot de passe).
        /// </returns>
        public static SqlConnection GetDBConnexion()
        {
            string host = Environment.MachineName;
            string database = "gesper";
            string login = "sa";
            string password = "toto";

            string connString = string.Format(@"Server={0}; Database={1}; User ID={2}; Password={3};", host, database, login, password);

            // @ permet d'éviter les séquences d'échappement, par exemple, C:\Users\Marc est équivalent à @"C:\Users\Marc"

            SqlConnection maConnexion = new SqlConnection(connString);

            return maConnexion;
        }
    }
}
