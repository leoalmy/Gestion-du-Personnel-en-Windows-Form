namespace GesPerWinForm
{
    partial class fmEmploye
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_Emp = new System.Windows.Forms.ListView();
            this.NSS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pnom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sce = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_EmpNss = new System.Windows.Forms.Label();
            this.lb_EmpNom = new System.Windows.Forms.Label();
            this.lb_EmpPnom = new System.Windows.Forms.Label();
            this.lb_EmpSal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_modify = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_EmpSce = new System.Windows.Forms.Label();
            this.lb_EmpQual = new System.Windows.Forms.Label();
            this.tb_EmpNss = new System.Windows.Forms.TextBox();
            this.tb_EmpNom = new System.Windows.Forms.TextBox();
            this.tb_EmpPnom = new System.Windows.Forms.TextBox();
            this.tb_EmpSal = new System.Windows.Forms.TextBox();
            this.tb_EmpQual = new System.Windows.Forms.TextBox();
            this.cb_EmpSce = new System.Windows.Forms.ComboBox();
            this.lb_test = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_Emp
            // 
            this.lv_Emp.AutoArrange = false;
            this.lv_Emp.BackColor = System.Drawing.SystemColors.Control;
            this.lv_Emp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NSS,
            this.Nom,
            this.Pnom,
            this.Sal,
            this.Qual,
            this.Sce});
            this.lv_Emp.FullRowSelect = true;
            this.lv_Emp.GridLines = true;
            this.lv_Emp.HideSelection = false;
            this.lv_Emp.Location = new System.Drawing.Point(57, 241);
            this.lv_Emp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_Emp.Name = "lv_Emp";
            this.lv_Emp.Size = new System.Drawing.Size(787, 205);
            this.lv_Emp.TabIndex = 13;
            this.lv_Emp.UseCompatibleStateImageBehavior = false;
            this.lv_Emp.View = System.Windows.Forms.View.Details;
            this.lv_Emp.SelectedIndexChanged += new System.EventHandler(this.lv_Emp_SelectedIndexChanged);
            // 
            // NSS
            // 
            this.NSS.Text = "NSS";
            this.NSS.Width = 110;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 110;
            // 
            // Pnom
            // 
            this.Pnom.Text = "Prénom";
            this.Pnom.Width = 110;
            // 
            // Sal
            // 
            this.Sal.Text = "Salaire";
            this.Sal.Width = 75;
            // 
            // Qual
            // 
            this.Qual.Text = "Qualification";
            this.Qual.Width = 70;
            // 
            // Sce
            // 
            this.Sce.Text = "Service";
            this.Sce.Width = 80;
            // 
            // lb_EmpNss
            // 
            this.lb_EmpNss.AutoSize = true;
            this.lb_EmpNss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EmpNss.Location = new System.Drawing.Point(55, 57);
            this.lb_EmpNss.Name = "lb_EmpNss";
            this.lb_EmpNss.Size = new System.Drawing.Size(48, 20);
            this.lb_EmpNss.TabIndex = 14;
            this.lb_EmpNss.Text = "NSS:";
            // 
            // lb_EmpNom
            // 
            this.lb_EmpNom.AutoSize = true;
            this.lb_EmpNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EmpNom.Location = new System.Drawing.Point(55, 113);
            this.lb_EmpNom.Name = "lb_EmpNom";
            this.lb_EmpNom.Size = new System.Drawing.Size(49, 20);
            this.lb_EmpNom.TabIndex = 15;
            this.lb_EmpNom.Text = "Nom:";
            // 
            // lb_EmpPnom
            // 
            this.lb_EmpPnom.AutoSize = true;
            this.lb_EmpPnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EmpPnom.Location = new System.Drawing.Point(55, 174);
            this.lb_EmpPnom.Name = "lb_EmpPnom";
            this.lb_EmpPnom.Size = new System.Drawing.Size(72, 20);
            this.lb_EmpPnom.TabIndex = 16;
            this.lb_EmpPnom.Text = "Prénom:";
            // 
            // lb_EmpSal
            // 
            this.lb_EmpSal.AutoSize = true;
            this.lb_EmpSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EmpSal.Location = new System.Drawing.Point(400, 57);
            this.lb_EmpSal.Name = "lb_EmpSal";
            this.lb_EmpSal.Size = new System.Drawing.Size(66, 20);
            this.lb_EmpSal.TabIndex = 17;
            this.lb_EmpSal.Text = "Salaire:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_tool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(896, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file_tool
            // 
            this.file_tool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.file_tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_new,
            this.mi_modify,
            this.mi_save,
            this.mi_delete,
            this.toolStripSeparator1,
            this.mi_quit});
            this.file_tool.ForeColor = System.Drawing.Color.Silver;
            this.file_tool.Name = "file_tool";
            this.file_tool.Size = new System.Drawing.Size(81, 24);
            this.file_tool.Text = "Employé";
            // 
            // mi_new
            // 
            this.mi_new.Name = "mi_new";
            this.mi_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mi_new.Size = new System.Drawing.Size(217, 26);
            this.mi_new.Text = "New";
            this.mi_new.Click += new System.EventHandler(this.mi_new_Click);
            // 
            // mi_modify
            // 
            this.mi_modify.BackColor = System.Drawing.SystemColors.Control;
            this.mi_modify.Name = "mi_modify";
            this.mi_modify.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mi_modify.Size = new System.Drawing.Size(217, 26);
            this.mi_modify.Text = "Modify";
            this.mi_modify.Click += new System.EventHandler(this.mi_modify_Click);
            // 
            // mi_save
            // 
            this.mi_save.Name = "mi_save";
            this.mi_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mi_save.Size = new System.Drawing.Size(217, 26);
            this.mi_save.Text = "Save";
            this.mi_save.Click += new System.EventHandler(this.mi_save_Click);
            // 
            // mi_delete
            // 
            this.mi_delete.Name = "mi_delete";
            this.mi_delete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.mi_delete.Size = new System.Drawing.Size(217, 26);
            this.mi_delete.Text = "Delete";
            this.mi_delete.Click += new System.EventHandler(this.mi_delete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // mi_quit
            // 
            this.mi_quit.Name = "mi_quit";
            this.mi_quit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mi_quit.Size = new System.Drawing.Size(217, 26);
            this.mi_quit.Text = "Quit";
            this.mi_quit.Click += new System.EventHandler(this.mi_quit_Click);
            // 
            // lb_EmpSce
            // 
            this.lb_EmpSce.AutoSize = true;
            this.lb_EmpSce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EmpSce.Location = new System.Drawing.Point(396, 174);
            this.lb_EmpSce.Name = "lb_EmpSce";
            this.lb_EmpSce.Size = new System.Drawing.Size(70, 20);
            this.lb_EmpSce.TabIndex = 19;
            this.lb_EmpSce.Text = "Service:";
            // 
            // lb_EmpQual
            // 
            this.lb_EmpQual.AutoSize = true;
            this.lb_EmpQual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EmpQual.Location = new System.Drawing.Point(400, 113);
            this.lb_EmpQual.Name = "lb_EmpQual";
            this.lb_EmpQual.Size = new System.Drawing.Size(107, 20);
            this.lb_EmpQual.TabIndex = 20;
            this.lb_EmpQual.Text = "Qualification:";
            // 
            // tb_EmpNss
            // 
            this.tb_EmpNss.Location = new System.Drawing.Point(131, 55);
            this.tb_EmpNss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_EmpNss.MaxLength = 13;
            this.tb_EmpNss.Name = "tb_EmpNss";
            this.tb_EmpNss.Size = new System.Drawing.Size(263, 22);
            this.tb_EmpNss.TabIndex = 21;
            // 
            // tb_EmpNom
            // 
            this.tb_EmpNom.Location = new System.Drawing.Point(115, 113);
            this.tb_EmpNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_EmpNom.MaxLength = 50;
            this.tb_EmpNom.Name = "tb_EmpNom";
            this.tb_EmpNom.Size = new System.Drawing.Size(263, 22);
            this.tb_EmpNom.TabIndex = 22;
            // 
            // tb_EmpPnom
            // 
            this.tb_EmpPnom.Location = new System.Drawing.Point(141, 172);
            this.tb_EmpPnom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_EmpPnom.MaxLength = 50;
            this.tb_EmpPnom.Name = "tb_EmpPnom";
            this.tb_EmpPnom.Size = new System.Drawing.Size(240, 22);
            this.tb_EmpPnom.TabIndex = 23;
            // 
            // tb_EmpSal
            // 
            this.tb_EmpSal.Location = new System.Drawing.Point(480, 57);
            this.tb_EmpSal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_EmpSal.MaxLength = 12;
            this.tb_EmpSal.Name = "tb_EmpSal";
            this.tb_EmpSal.Size = new System.Drawing.Size(111, 22);
            this.tb_EmpSal.TabIndex = 24;
            // 
            // tb_EmpQual
            // 
            this.tb_EmpQual.Location = new System.Drawing.Point(525, 111);
            this.tb_EmpQual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_EmpQual.MaxLength = 2;
            this.tb_EmpQual.Name = "tb_EmpQual";
            this.tb_EmpQual.Size = new System.Drawing.Size(57, 22);
            this.tb_EmpQual.TabIndex = 26;
            // 
            // cb_EmpSce
            // 
            this.cb_EmpSce.FormattingEnabled = true;
            this.cb_EmpSce.Location = new System.Drawing.Point(480, 172);
            this.cb_EmpSce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_EmpSce.Name = "cb_EmpSce";
            this.cb_EmpSce.Size = new System.Drawing.Size(181, 24);
            this.cb_EmpSce.TabIndex = 27;
            // 
            // lb_test
            // 
            this.lb_test.AutoSize = true;
            this.lb_test.Enabled = false;
            this.lb_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_test.Location = new System.Drawing.Point(704, 309);
            this.lb_test.Name = "lb_test";
            this.lb_test.Size = new System.Drawing.Size(65, 25);
            this.lb_test.TabIndex = 28;
            this.lb_test.Text = "TEST";
            this.lb_test.Visible = false;
            // 
            // fmEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(896, 466);
            this.Controls.Add(this.cb_EmpSce);
            this.Controls.Add(this.tb_EmpQual);
            this.Controls.Add(this.tb_EmpSal);
            this.Controls.Add(this.tb_EmpPnom);
            this.Controls.Add(this.tb_EmpNom);
            this.Controls.Add(this.tb_EmpNss);
            this.Controls.Add(this.lb_EmpQual);
            this.Controls.Add(this.lb_EmpSce);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lb_EmpSal);
            this.Controls.Add(this.lb_EmpPnom);
            this.Controls.Add(this.lb_EmpNom);
            this.Controls.Add(this.lb_EmpNss);
            this.Controls.Add(this.lv_Emp);
            this.Controls.Add(this.lb_test);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(911, 504);
            this.Name = "fmEmploye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employés";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmEmploye_FormClosed);
            this.Load += new System.EventHandler(this.fmEmploye_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Emp;
        private System.Windows.Forms.ColumnHeader NSS;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Pnom;
        private System.Windows.Forms.ColumnHeader Sal;
        private System.Windows.Forms.Label lb_EmpNss;
        private System.Windows.Forms.Label lb_EmpNom;
        private System.Windows.Forms.Label lb_EmpPnom;
        private System.Windows.Forms.Label lb_EmpSal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file_tool;
        private System.Windows.Forms.ToolStripMenuItem mi_new;
        private System.Windows.Forms.ToolStripMenuItem mi_modify;
        private System.Windows.Forms.ToolStripMenuItem mi_save;
        private System.Windows.Forms.ToolStripMenuItem mi_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mi_quit;
        private System.Windows.Forms.Label lb_EmpSce;
        private System.Windows.Forms.Label lb_EmpQual;
        private System.Windows.Forms.TextBox tb_EmpNss;
        private System.Windows.Forms.TextBox tb_EmpNom;
        private System.Windows.Forms.TextBox tb_EmpPnom;
        private System.Windows.Forms.TextBox tb_EmpSal;
        private System.Windows.Forms.TextBox tb_EmpQual;
        private System.Windows.Forms.ComboBox cb_EmpSce;
        private System.Windows.Forms.ColumnHeader Qual;
        private System.Windows.Forms.ColumnHeader Sce;
        private System.Windows.Forms.Label lb_test;
    }
}