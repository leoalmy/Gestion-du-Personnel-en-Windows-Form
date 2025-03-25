using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesPerWinForm
{
    /// <summary>
    /// Classe Employé permettant d'intéragir avec la table Employé de la base de données.
    /// </summary>
    public class Employe
    {
        private readonly string emp_nss, emp_nom, emp_pnom, emp_qualif, emp_sce;
        private readonly decimal emp_salaire;

        /// <summary>
        /// Propriété permettant de récupérer le numéro de sécurité sociale de l'employé.
        /// </summary>
        public string GetEmpNss
        {
            get { return emp_nss; }
        }

        /// <summary>
        /// Propriété permettant de récupérer le nom de l'employé.
        /// </summary>
        public string GetEmpNom
        {
            get { return emp_nom; }
        }

        /// <summary>
        /// Propriété permettant de récupérer le prénom de l'employé.
        /// </summary>
        public string GetEmpPnom
        {
            get { return emp_pnom; }
        }

        /// <summary>
        /// Propriété permettant de récupérer le salaire de l'employé.
        /// </summary>
        public decimal GetEmpSalaire
        {
            get { return emp_salaire; }
        }

        /// <summary>
        /// Propriété permettant de récupérer la qualification de l'employé.
        /// </summary>
        public string GetEmpQualif
        {
            get { return emp_qualif; }
        }

        /// <summary>
        /// Propriété permettant de récupérer le service de l'employé.
        /// </summary>
        public string GetEmpSce
        {
            get { return emp_sce; }
        }

        /// <summary>
        /// Constructeur de la classe Employé qui prend en paramètre un curseur de base de données.
        /// </summary>
        /// <param name="reader"></param>
        public Employe(SqlDataReader reader)
        {
            int indiceEmpNss = reader.GetOrdinal("emp_nss");
            int indiceEmpNom = reader.GetOrdinal("emp_nom");
            int indiceEmpPnom = reader.GetOrdinal("emp_pnom");
            int indiceEmpSalaire = reader.GetOrdinal("emp_salaire");
            int indiceEmpQualif = reader.GetOrdinal("emp_qualif");
            int indiceEmpSce = reader.GetOrdinal("emp_sce");

            emp_nss = reader.GetString(indiceEmpNss);
            emp_nom = reader.GetString(indiceEmpNom);
            emp_pnom = reader.GetString(indiceEmpPnom);
            emp_salaire = reader.GetDecimal(indiceEmpSalaire);
            emp_qualif = reader.GetString(indiceEmpQualif);
            emp_sce = reader.GetString(indiceEmpSce);
        }
    }
}
