using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesPerWinForm
{
    /// <summary>
    /// Classe Absence permettant d'intéragir avec la table Absence de la base de données.
    /// </summary>
    public class Absence
    {
        private readonly string abs_emp;
        private readonly DateTime abs_debut;
        private readonly DateTime abs_fin;

        /// <summary>
        /// Propriété permettant de récupérer l'employé en absence.
        /// </summary>
        private string GetAbsEmp
        {
            get { return abs_emp; }
        }

        /// <summary>
        /// Propriété permettant de récupérer la date de début de l'absence.
        /// </summary>
        public DateTime GetAbsDebut
        {
            get { return abs_debut; }
        }

        /// <summary>
        /// Propriété permettant de récupérer la date de fin de l'absence.
        /// </summary>
        public DateTime GetAbsFin
        {
            get { return abs_fin; }
        }

        /// <summary>
        /// Constructeur de la classe Absence qui prend en paramètre un curseur de base de données.
        /// </summary>
        /// <param name="reader"></param>
        public Absence(SqlDataReader reader)
        {
            int indiceAbsEmp = reader.GetOrdinal("abs_emp");
            int indiceAbsDebut = reader.GetOrdinal("abs_debut");
            int indiceAbsFin = reader.GetOrdinal("abs_fin");

            abs_emp = reader.GetString(indiceAbsEmp);
            abs_debut = reader.GetDateTime(indiceAbsDebut);
            abs_fin = reader.GetDateTime(indiceAbsFin);
        }
    }

}
