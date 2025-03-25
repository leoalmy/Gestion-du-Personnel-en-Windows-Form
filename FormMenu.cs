using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesPerWinForm
{
    public partial class fmMenu : Form
    {
        private bool flagExuit = true;

        /// <summary>
        /// Constructeur de la classe fmMenu.
        /// </summary>
        public fmMenu()
        {
            InitializeComponent();
        }
        private void fmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flagExuit)
            {
                Program.connexionBdd.Close();
                Application.Exit();
            }
        }
        private void btSce_Click(object sender, EventArgs e)
        {
            flagExuit = false;
            fmService fms = new fmService();
            fms.Show();
            Close();
        }
        private void btEmp_Click(object sender, EventArgs e)
        {
            flagExuit = false;
            fmEmploye fme = new fmEmploye();
            fme.Show();
            Close();
        }
        private void btAbs_Click(object sender, EventArgs e)
        {
            flagExuit = false;
            fmAbsence fma = new fmAbsence();
            fma.Show();
            Close();
        }
    }
}
