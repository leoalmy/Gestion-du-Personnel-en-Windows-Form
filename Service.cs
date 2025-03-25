using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesPerWinForm
{
    /// <summary>
    /// Classe Service permettant d'intéragir avec la table Service de la base de données.
    /// </summary>
    public class Service
    {
        private readonly string sce_code, sce_des, sce_type;
        private readonly decimal sce_budget;

        /// <summary>
        /// Propriété permettant de récupérer le code du service.
        /// </summary>
        public string GetSceCode
        {
            get { return sce_code; }
        }

        /// <summary>
        /// Propriété permettant de récupérer la description du service.
        /// </summary>
        public string GetSceDes
        {
            get { return sce_des; }
        }

        /// <summary>
        /// Propriété permettant de récupérer le type du service.
        /// </summary>
        public string GetSceType 
        {
            get { return sce_type; } 
        }

        /// <summary>
        /// Propriété permettant de récupérer le budget du service.
        /// </summary>
        public decimal GetSceBudget
        {
            get { return sce_budget; }
        }

        /// <summary>
        /// Constructeur de la classe Service qui prend en paramètre un curseur de base de données.
        /// </summary>
        /// <param name="reader"></param>
        public Service(SqlDataReader reader)
        {
            int indiceSceCode = reader.GetOrdinal("sce_code");
            int indiceSceDes = reader.GetOrdinal("sce_des");
            int indiceSceType = reader.GetOrdinal("sce_type");
            int indiceSceBudget = reader.GetOrdinal("sce_budget");

            sce_code = reader.GetString(indiceSceCode);
            sce_des = reader.GetString(indiceSceDes);
            sce_type = reader.GetString(indiceSceType);
            sce_budget = reader.GetDecimal(indiceSceBudget);
        }
    }
}
