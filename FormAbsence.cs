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
using System.Windows.Forms.Design;

namespace GesPerWinForm
{
    public partial class fmAbsence : Form
    {
        /// <summary>
        /// Constructeur de la classe fmAbsence.
        /// </summary>
        public fmAbsence()
        {
            InitializeComponent();
        }

        private void fmAbsence_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmMenu fmMenu = new fmMenu();
            fmMenu.Show();
        }

        private void mi_quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fmAbsence_Load(object sender, EventArgs e)
        {
            InitControls();
            AffListEmp();
        }
        private void InitControls()
        {
            cb_TypAbs.Enabled = false;

            datDebPicker.Enabled = false;
            datFinPicker.Enabled = false;

            mi_new.Enabled = true;
            mi_delete.Enabled = false;
            mi_save.Enabled = false;
            mi_modify.Enabled = false;
        }
        private void AffListEmp()
        {
            try
            {
                string sql = $"SELECT * FROM employe ORDER BY emp_nss";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.connexionBdd;
                cmd.CommandText = sql;

                cb_EmpAbs.Items.Clear();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Employe unEmploye = new Employe(reader);
                        cb_EmpAbs.Items.Add(new { Text = ("Nom: " + unEmploye.GetEmpNom + "   Prénom: " + unEmploye.GetEmpPnom + "   NSS: " + unEmploye.GetEmpNss), Value = unEmploye.GetEmpNss });

                        cb_EmpAbs.DisplayMember = "Text";
                        cb_EmpAbs.ValueMember = "Value";
                    }
                }
                reader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur d'accès à la base de données.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AffAbsEmp()
        {
            if (cb_EmpAbs.SelectedIndex != -1)
            {
                try
                {
                    string emp_nss = (cb_EmpAbs.SelectedItem as dynamic).Value;
                    string sql = $"SELECT a.*, t.typ_libelle, t.typ_code, DATEDIFF(day, abs_debut, abs_fin) AS NbJours FROM absence AS a JOIN typabs AS t ON a.abs_typ = t.typ_code WHERE abs_emp = '{emp_nss}' ORDER BY abs_debut";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Program.connexionBdd;
                    cmd.CommandText = sql;

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Absence uneAbsence = new Absence(reader);
                            string typcode = reader["typ_code"].ToString();
                            string typlibel = reader["typ_libelle"].ToString();
                            string nbJours = reader["NbJours"].ToString();

                            string[] row = new string[]
                            {
                                uneAbsence.GetAbsDebut.ToString("yyyy-MM-dd"),
                                uneAbsence.GetAbsFin.ToString("yyyy-MM-dd"),
                                typlibel,
                                nbJours,
                                lb_test.Text = typcode
                            };

                            var lvItems = new ListViewItem(row);
                            lv_Abs.Items.Add(lvItems);
                        }
                    }
                    reader.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erreur d'accès à la base de données.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cb_EmpAbs_SelectedIndexChanged(object sender, EventArgs e)
        {
            AffAbsEmp();
        }
        private void AffListTypAbs(string idTypAbs)
        {
            try
            {
                string sql = $"SELECT * FROM TypAbs ORDER BY typ_code";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.connexionBdd;
                cmd.CommandText = sql;

                int indexItem = 0;
                cb_TypAbs.Items.Clear();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TypAbs unTypAbs = new TypAbs(reader);
                        cb_TypAbs.Items.Add(new { Text = unTypAbs.GetTypLibelle, Value = unTypAbs.GetTypCode });

                        if (unTypAbs.GetTypCode == idTypAbs)
                        {
                            indexItem = cb_TypAbs.Items.Count - 1;
                        }

                        cb_TypAbs.SelectedIndex = indexItem;

                        cb_TypAbs.DisplayMember = "Text";
                        cb_TypAbs.ValueMember = "Value";
                    }
                }
                reader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur d'accès à la base de données.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lv_Abs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mi_modify.Enabled == false)
            {
                mi_delete.Enabled = true;
                mi_modify.Enabled = true;
            }
            try
            {
                string typabs = "maladie";
                if (lv_Abs.SelectedItems.Count > 0)
                {
                    datDebPicker.Value = Convert.ToDateTime(lv_Abs.SelectedItems[0].SubItems[0].Text);
                    datFinPicker.Value = Convert.ToDateTime(lv_Abs.SelectedItems[0].SubItems[1].Text);
                    typabs = lv_Abs.SelectedItems[0].SubItems[2].Text;
                }

                string sql = $"SELECT t.* FROM TypAbs AS t WHERE t.typ_libelle = '{typabs}' ORDER BY typ_code";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.connexionBdd;
                cmd.CommandText = sql;

                SqlDataReader reader = cmd.ExecuteReader();

                TypAbs unTypAbs = null;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        unTypAbs = new TypAbs(reader);
                        lb_test.Text = reader["typ_code"].ToString();
                    }
                }
                reader.Close();
                AffListTypAbs(unTypAbs.GetTypCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur d'accès à la base de données.\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void mi_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this absence ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM absence WHERE abs_emp = @EmpNss AND abs_debut = @absdeb AND abs_fin = @absfin";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Program.connexionBdd;
                    cmd.CommandText = sql;

                    cmd.Parameters.AddWithValue("@EmpNss", (cb_EmpAbs.SelectedItem as dynamic).Value);
                    cmd.Parameters.AddWithValue("@absdeb", datDebPicker.Value);
                    cmd.Parameters.AddWithValue("@absfin", datFinPicker.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Absence supprimé avec succès.");
                    lv_Abs.Items.Clear();
                    AffAbsEmp();
                    InitControls();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erreur lors de la suppression de l'absence.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mi_new_Click(object sender, EventArgs e)
        {
            cb_EmpAbs.SelectedIndex = -1;
            datDebPicker.Enabled = true;
            datFinPicker.Enabled = true;
            cb_TypAbs.Enabled = true;
            lv_Abs.Items.Clear();
            lv_Abs.Enabled = false;

            datDebPicker.Value = DateTime.Now;
            datFinPicker.Value = DateTime.Now;

            mi_new.Enabled = false;
            mi_save.Enabled = true;
            mi_modify.Enabled = false;
            mi_delete.Enabled = false;
            AffListTypAbs(null);
        }

        private void mi_modify_Click(object sender, EventArgs e)
        {
            cb_EmpAbs.Enabled = false;
            datDebPicker.Enabled = false;
            datFinPicker.Enabled = true;
            cb_TypAbs.Enabled = true;
            lv_Abs.Enabled = false;

            mi_new.Enabled = false;
            mi_save.Enabled = true;
            mi_modify.Enabled = false;
            mi_delete.Enabled = false;
        }

        private void mi_save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add/save this absence ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes && (cb_EmpAbs.SelectedItem as dynamic).Value != string.Empty)
            {
                try
                {
                    string sql = "INSERT INTO absence (abs_emp, abs_debut, abs_fin, abs_typ) VALUES (@absemp, @absdeb, @absfin, @abstyp)";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Program.connexionBdd;
                    cmd.CommandText = sql;

                    cmd.Parameters.AddWithValue("@absemp", (cb_EmpAbs.SelectedItem as dynamic).Value);
                    cmd.Parameters.AddWithValue("@absdeb", datDebPicker.Value);
                    cmd.Parameters.AddWithValue("@absfin", datFinPicker.Value);
                    cmd.Parameters.AddWithValue("@abstyp", (cb_TypAbs.SelectedItem as dynamic).Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Absence ajouté avec succès.");
                    lv_Abs.Items.Clear();
                    AffAbsEmp();
                    InitControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout de l'absence.\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
