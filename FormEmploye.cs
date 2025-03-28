using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesPerWinForm
{
    public partial class fmEmploye : Form
    {
        private bool newOrUpd = false; // false = update, true = new
        /// <summary>
        /// Constructeur de la classe fmEmploye.
        /// </summary>
        public fmEmploye()
        {
            InitializeComponent();
        }
        private void mi_quit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void fmEmploye_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmMenu fmMenu = new fmMenu();
            fmMenu.Show();
        }

        private void fmEmploye_Load(object sender, EventArgs e)
        {
            InitControls();
            DataLoad();
        }
        private void DataLoad()
        {
            lv_Emp.Items.Clear();

            try
            {
                string sql = $"SELECT e.*, s.sce_des FROM employe e JOIN service s ON e.emp_sce = s.sce_code ORDER BY emp_nss";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.connexionBdd;
                cmd.CommandText = sql;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Employe unEmploye = new Employe(reader);

                        string[] row = new string[]
                        {
                            unEmploye.GetEmpNss,
                            unEmploye.GetEmpNom,
                            unEmploye.GetEmpPnom,
                            unEmploye.GetEmpSalaire.ToString(),
                            unEmploye.GetEmpQualif,
                            reader["sce_des"].ToString()
                        };

                        var lvItems = new ListViewItem(row);
                        lv_Emp.Items.Add(lvItems);
                    }
                }
                reader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur d'accès à la base de données.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitControls()
        {
            tb_EmpNss.ReadOnly = true;
            tb_EmpNss.Clear();
            tb_EmpNom.ReadOnly = true;
            tb_EmpNom.Clear();
            tb_EmpPnom.ReadOnly = true;
            tb_EmpPnom.Clear();
            tb_EmpSal.ReadOnly = true;
            tb_EmpSal.Clear();
            tb_EmpQual.ReadOnly = true;
            tb_EmpQual.Clear();

            cb_EmpSce.Enabled = false;
            cb_EmpSce.Items.Clear();
            cb_EmpSce.Text = string.Empty;

            mi_modify.Enabled = false;
            mi_save.Enabled = false;
            mi_delete.Enabled = false;

            mi_new.Enabled = true;
        }
        private void AffListSce(string idService)
        {
            try
            {
                string sql = $"SELECT * FROM service ORDER BY sce_code";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.connexionBdd;
                cmd.CommandText = sql;

                int indexItem = 0;
                cb_EmpSce.Items.Clear();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Service unService = new Service(reader);
                        cb_EmpSce.Items.Add(new { Text = unService.GetSceDes, Value = unService.GetSceCode });

                        if (unService.GetSceCode == idService)
                        {
                            indexItem = cb_EmpSce.Items.Count - 1;
                        }

                        cb_EmpSce.SelectedIndex = indexItem;

                        cb_EmpSce.DisplayMember = "Text";
                        cb_EmpSce.ValueMember = "Value";
                    }
                }
                reader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur d'accès à la base de données.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lv_Emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Emp.SelectedItems.Count != 0)
            {
                string empNSS = lv_Emp.SelectedItems[0].SubItems[0].Text;

                string sql = $"SELECT * FROM employe WHERE emp_nss = '{empNSS}'";
                Employe unEmploye = null;

                try
                {
                    InitControls();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Program.connexionBdd;
                    cmd.CommandText = sql;

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            unEmploye = new Employe(reader);

                            tb_EmpNss.Text = unEmploye.GetEmpNss;
                            tb_EmpNom.Text = unEmploye.GetEmpNom;
                            tb_EmpPnom.Text = unEmploye.GetEmpPnom;
                            tb_EmpQual.Text = unEmploye.GetEmpQualif;
                            tb_EmpSal.Text = unEmploye.GetEmpSalaire.ToString();
                            lb_test.Text = unEmploye.GetEmpSce;
                        }
                    }
                    reader.Close();
                    AffListSce(unEmploye.GetEmpSce);
                    mi_delete.Enabled = true;
                    mi_modify.Enabled = true;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erreur d'accès à la base de données.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mi_new_Click(object sender, EventArgs e)
        {
            AffListSce(null);
            tb_EmpNss.ReadOnly = false;
            tb_EmpNss.Clear();
            tb_EmpNom.ReadOnly = false;
            tb_EmpNom.Clear();
            tb_EmpPnom.ReadOnly = false;
            tb_EmpPnom.Clear();
            tb_EmpQual.ReadOnly = false;
            tb_EmpQual.Clear();
            tb_EmpSal.ReadOnly = false;
            tb_EmpSal.Clear();
            cb_EmpSce.Enabled = true;

            mi_new.Enabled = false;
            mi_save.Enabled = true;
            mi_modify.Enabled = false;
            mi_delete.Enabled = false;

            newOrUpd = true;
        }
        private void mi_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this employee ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM employe WHERE emp_nss = @EmpNss";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Program.connexionBdd;
                    cmd.CommandText = sql;

                    cmd.Parameters.AddWithValue("@EmpNss", tb_EmpNss.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Employé supprimé avec succès.");
                    DataLoad();
                    InitControls();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erreur lors de la suppression du service.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void mi_modify_Click(object sender, EventArgs e)
        {
            tb_EmpNom.ReadOnly = false;
            tb_EmpPnom.ReadOnly = false;
            tb_EmpQual.ReadOnly = false;
            tb_EmpSal.ReadOnly = false;
            cb_EmpSce.Enabled = true;
            mi_modify.Enabled = false;
            mi_save.Enabled = true;
            mi_delete.Enabled = false;
            mi_new.Enabled = false;
        }

        private void mi_save_Click(object sender, EventArgs e)
        {
            string ehe = string.Empty;
            if (newOrUpd)
            {
                ehe = "add";
            }
            else
            {
                ehe = "save";
            }
            if (MessageBox.Show("Are you sure you want to " + ehe + " this employee ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes && tb_EmpNss.Text != string.Empty)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string state = string.Empty;
                    string sql = string.Empty;

                    if (newOrUpd)
                    {
                        sql = "INSERT INTO employe (emp_nss, emp_nom, emp_pnom, emp_salaire, emp_qualif, emp_sce) VALUES (@EmpNss, @EmpNom, @EmpPnom, @EmpSalaire, @EmpQualif, @EmpSce)";
                        state = "ajouté";
                    }
                    else
                    {
                        sql = "UPDATE employe SET emp_nom = @EmpNom, emp_pnom = @EmpPnom, emp_salaire = @EmpSalaire, emp_qualif = @EmpQualif, emp_sce = @EmpSce WHERE emp_nss = @EmpNss";
                        state = "modifié";
                    }
                    
                    cmd.Connection = Program.connexionBdd;
                    cmd.CommandText = sql;

                    cmd.Parameters.AddWithValue("@EmpNss", tb_EmpNss.Text);
                    cmd.Parameters.AddWithValue("@EmpNom", tb_EmpNom.Text);
                    cmd.Parameters.AddWithValue("@EmpPnom", tb_EmpPnom.Text);
                    cmd.Parameters.AddWithValue("@EmpSalaire", decimal.Parse(tb_EmpSal.Text));
                    cmd.Parameters.AddWithValue("@EmpQualif", tb_EmpQual.Text);
                    cmd.Parameters.AddWithValue("@EmpSce", (cb_EmpSce.SelectedItem as dynamic).Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Employé " + state + " avec succès.");
                    DataLoad();
                    InitControls();
                    newOrUpd = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout de l'employé.\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
