using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesPerWinForm
{
    /// <summary>
    /// Classe TypeAbsence permettant d'intéragir avec la table typAbs de la base de données.
    /// </summary>
    public class TypAbs
    {
        private string typ_code, typ_libelle;
        private bool typ_deductible;

        public string GetTypCode 
        {
            get { return typ_code; }
        }
        public string GetTypLibelle
        {
            get { return typ_libelle; }
        }
        public bool GetTypDeductible
        {
            get { return typ_deductible; }
        }
        public TypAbs(SqlDataReader reader)
        {
            int indiceTypCode = reader.GetOrdinal("typ_code");
            int indiceTypLibelle = reader.GetOrdinal("typ_libelle");
            int indiceTypDeductible = reader.GetOrdinal("typ_deductible");

            typ_code = reader.GetString(indiceTypCode);
            typ_libelle = reader.GetString(indiceTypLibelle);
            typ_deductible = reader.GetBoolean(indiceTypDeductible);
        }
    }
}
