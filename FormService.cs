using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace GesPerWinForm
{
    public partial class fmService : Form
    {
        private bool newOrUpd = false; // false = update, true = new
        /// <summary>
        /// Constructeur de la classe fmService.
        /// </summary>
        public fmService()
        {
            InitializeComponent();
        }
        private void DataLoad()
        {
            lv_Sce.Items.Clear();

            try
            {
                string sql = $"SELECT * FROM service ORDER BY sce_code";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.connexionBdd;
                cmd.CommandText = sql;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Service unService = new Service(reader);

                        string[] row = new string[]
                        {
                            unService.GetSceCode,
                            unService.GetSceDes,
                            unService.GetSceType,
                            unService.GetSceBudget.ToString()
                        };

                        var lvItems = new ListViewItem(row);
                        lv_Sce.Items.Add(lvItems);
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
            tb_SceCode.ReadOnly = true;
            tb_SceCode.Clear();
            tb_SceDes.ReadOnly = true;
            tb_SceDes.Clear();
            tb_SceBud.ReadOnly = true;
            tb_SceBud.Clear();

            rb_Admin.Enabled = false;
            rb_Admin.Checked = false;
            rb_Prod.Enabled = false;
            rb_Prod.Checked = false;
            rb_Unknown.Enabled = false;
            rb_Unknown.Checked = false;

            mi_modify.Enabled = false;
            mi_delete.Enabled = false;
            mi_save.Enabled = false;

            mi_new.Enabled = true;
        }
        private void Lv_Sce_Click(object sender, EventArgs e)
        {
            tb_SceCode.ReadOnly = true;
            tb_SceCode.Clear();

            tb_SceDes.ReadOnly = true;
            tb_SceDes.Clear();

            tb_SceBud.ReadOnly = true;
            tb_SceBud.Clear();

            rb_Admin.Enabled = false;
            rb_Prod.Enabled = false;

            mi_new.Enabled = true;
            mi_modify.Enabled = true;
            mi_delete.Enabled = true;

            if (lv_Sce.SelectedItems.Count != 0)
            {
                string codeService = lv_Sce.SelectedItems[0].SubItems[0].Text;

                string sql = $"SELECT * FROM service WHERE sce_code = '{codeService}'";
                Service unService;

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Program.connexionBdd;
                    cmd.CommandText = sql;

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            unService = new Service(reader);

                            tb_SceCode.Text = unService.GetSceCode;
                            tb_SceDes.Text = unService.GetSceDes;
                            tb_SceBud.Text = unService.GetSceBudget.ToString();

                            if (unService.GetSceType == "administratif")
                            {
                                rb_Admin.Checked = true;
                                rb_Unknown.Visible = false;
                            }
                            else if (unService.GetSceType == "productif")
                            {
                                rb_Prod.Checked = true;
                                rb_Unknown.Visible = false;
                            }
                            else
                            {
                                rb_Unknown.Checked = true;
                                rb_Unknown.Visible = true;
                            }
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
        private void fmService_Load(object sender, EventArgs e)
        {
            DataLoad();
            InitControls();
        }

        private void mi_quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mi_new_Click(object sender, EventArgs e)
        {
            string lastCode = "";
            if (lv_Sce.Items.Count > 0)
            {
                ListViewItem lastEle = lv_Sce.Items[lv_Sce.Items.Count - 1];
                lastCode = lastEle.SubItems[0].Text;
                int SceNum = Convert.ToInt32(lastCode.Substring(1)) + 1;
                tb_SceCode.Text = "s" + SceNum;
            }
            else
            {
                tb_SceCode.Text = "s1";
            }

            tb_SceDes.ReadOnly = false;

            tb_SceBud.ReadOnly = false;

            rb_Admin.Enabled = true;
            rb_Prod.Enabled = true;

            mi_new.Enabled = false;
            mi_modify.Enabled = false;
            mi_save.Enabled = true;
            mi_delete.Enabled = false;

            newOrUpd = true;
        }

        private void mi_modify_Click(object sender, EventArgs e)
        {
            tb_SceDes.ReadOnly = false;

            tb_SceBud.ReadOnly = false;

            rb_Admin.Enabled = true;
            rb_Prod.Enabled = true;

            mi_new.Enabled = false;
            mi_modify.Enabled = false;
            mi_save.Enabled = true;
            mi_delete.Enabled = false;
        }

        private void mi_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this service ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM service WHERE sce_code = @SceCode";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Program.connexionBdd;
                    cmd.CommandText = sql;

                    cmd.Parameters.AddWithValue("@SceCode", tb_SceCode.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Service supprimé avec succès.");
                    DataLoad();
                    mi_delete.Enabled = false;
                    tb_SceBud.Text = string.Empty;
                    tb_SceCode.Text = string.Empty;
                    tb_SceDes.Text = string.Empty;
                    rb_Unknown.Checked = true;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erreur lors de la suppression du service.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            if (MessageBox.Show("Are you sure you want to " + ehe + " the service ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes && tb_SceBud.Text != string.Empty && tb_SceDes.Text != string.Empty)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string state = string.Empty;
                    string sql = string.Empty;

                    if (newOrUpd)
                    {
                        sql = "INSERT INTO service (sce_code, sce_des, sce_type, sce_budget) VALUES (@SceCode, @SceDes, @SceType, @SceBudget)";
                        state = "ajouté";
                    }
                    else
                    {
                        sql = "UPDATE service SET sce_des = @SceDes, sce_type = @SceType, sce_budget = @SceBudget WHERE sce_code = @SceCode";
                        state = "modifié";
                    }

                    cmd.Connection = Program.connexionBdd;
                    cmd.CommandText = sql;

                    string sceType;
                    if (rb_Admin.Checked == true)
                    {
                        sceType = "administratif";
                    }
                    else if (rb_Admin.Checked == false && rb_Prod.Checked == false)
                    {
                        throw new Exception("Aucun type n'a été séléctionné.");
                    }
                    else
                    {
                        sceType = "productif";
                    }

                    cmd.Parameters.AddWithValue("@SceCode", tb_SceCode.Text);
                    cmd.Parameters.AddWithValue("@SceDes", tb_SceDes.Text);
                    cmd.Parameters.AddWithValue("@SceType", sceType);
                    cmd.Parameters.AddWithValue("@SceBudget", decimal.Parse(tb_SceBud.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Service " + state + " avec succès.");
                    DataLoad();
                    mi_new.Enabled = true;
                    mi_save.Enabled = false;
                    tb_SceBud.Text = string.Empty;
                    tb_SceCode.Text = string.Empty;
                    tb_SceDes.Text = string.Empty;
                    rb_Unknown.Checked = true;
                    newOrUpd = false;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erreur lors de l'ajout du service.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fmService_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmMenu fmMenu = new fmMenu();
            fmMenu.Show();
        }
    }
}
