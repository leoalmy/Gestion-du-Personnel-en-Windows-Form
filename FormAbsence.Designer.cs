namespace GesPerWinForm
{
    partial class fmAbsence
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
            this.datDebPicker = new System.Windows.Forms.DateTimePicker();
            this.datFinPicker = new System.Windows.Forms.DateTimePicker();
            this.lb_DatDebAbs = new System.Windows.Forms.Label();
            this.lb_DatFinAbs = new System.Windows.Forms.Label();
            this.lb_EmpAbs = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_modify = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_TypAbs = new System.Windows.Forms.Label();
            this.cb_TypAbs = new System.Windows.Forms.ComboBox();
            this.cb_EmpAbs = new System.Windows.Forms.ComboBox();
            this.lv_Abs = new System.Windows.Forms.ListView();
            this.DatDeb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatFin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypAbs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NbJours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_test = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datDebPicker
            // 
            this.datDebPicker.Location = new System.Drawing.Point(252, 92);
            this.datDebPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datDebPicker.Name = "datDebPicker";
            this.datDebPicker.Size = new System.Drawing.Size(239, 22);
            this.datDebPicker.TabIndex = 0;
            // 
            // datFinPicker
            // 
            this.datFinPicker.Location = new System.Drawing.Point(252, 133);
            this.datFinPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datFinPicker.Name = "datFinPicker";
            this.datFinPicker.Size = new System.Drawing.Size(239, 22);
            this.datFinPicker.TabIndex = 1;
            // 
            // lb_DatDebAbs
            // 
            this.lb_DatDebAbs.AutoSize = true;
            this.lb_DatDebAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DatDebAbs.Location = new System.Drawing.Point(53, 94);
            this.lb_DatDebAbs.Name = "lb_DatDebAbs";
            this.lb_DatDebAbs.Size = new System.Drawing.Size(164, 20);
            this.lb_DatDebAbs.TabIndex = 2;
            this.lb_DatDebAbs.Text = "Date début absence:";
            // 
            // lb_DatFinAbs
            // 
            this.lb_DatFinAbs.AutoSize = true;
            this.lb_DatFinAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DatFinAbs.Location = new System.Drawing.Point(53, 135);
            this.lb_DatFinAbs.Name = "lb_DatFinAbs";
            this.lb_DatFinAbs.Size = new System.Drawing.Size(141, 20);
            this.lb_DatFinAbs.TabIndex = 3;
            this.lb_DatFinAbs.Text = "Date fin absence:";
            // 
            // lb_EmpAbs
            // 
            this.lb_EmpAbs.AutoSize = true;
            this.lb_EmpAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EmpAbs.Location = new System.Drawing.Point(53, 48);
            this.lb_EmpAbs.Name = "lb_EmpAbs";
            this.lb_EmpAbs.Size = new System.Drawing.Size(78, 20);
            this.lb_EmpAbs.TabIndex = 4;
            this.lb_EmpAbs.Text = "Employé:";
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
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
            this.file_tool.Size = new System.Drawing.Size(79, 24);
            this.file_tool.Text = "Absence";
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
            // lb_TypAbs
            // 
            this.lb_TypAbs.AutoSize = true;
            this.lb_TypAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TypAbs.Location = new System.Drawing.Point(53, 181);
            this.lb_TypAbs.Name = "lb_TypAbs";
            this.lb_TypAbs.Size = new System.Drawing.Size(120, 20);
            this.lb_TypAbs.TabIndex = 7;
            this.lb_TypAbs.Text = "Type Absence:";
            // 
            // cb_TypAbs
            // 
            this.cb_TypAbs.FormattingEnabled = true;
            this.cb_TypAbs.Location = new System.Drawing.Point(195, 177);
            this.cb_TypAbs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_TypAbs.Name = "cb_TypAbs";
            this.cb_TypAbs.Size = new System.Drawing.Size(213, 24);
            this.cb_TypAbs.TabIndex = 28;
            // 
            // cb_EmpAbs
            // 
            this.cb_EmpAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_EmpAbs.FormattingEnabled = true;
            this.cb_EmpAbs.Location = new System.Drawing.Point(149, 44);
            this.cb_EmpAbs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_EmpAbs.Name = "cb_EmpAbs";
            this.cb_EmpAbs.Size = new System.Drawing.Size(440, 26);
            this.cb_EmpAbs.TabIndex = 29;
            this.cb_EmpAbs.SelectedIndexChanged += new System.EventHandler(this.cb_EmpAbs_SelectedIndexChanged);
            // 
            // lv_Abs
            // 
            this.lv_Abs.BackColor = System.Drawing.SystemColors.Control;
            this.lv_Abs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DatDeb,
            this.DatFin,
            this.TypAbs,
            this.NbJours});
            this.lv_Abs.FullRowSelect = true;
            this.lv_Abs.GridLines = true;
            this.lv_Abs.HideSelection = false;
            this.lv_Abs.Location = new System.Drawing.Point(57, 241);
            this.lv_Abs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_Abs.Name = "lv_Abs";
            this.lv_Abs.Size = new System.Drawing.Size(721, 205);
            this.lv_Abs.TabIndex = 30;
            this.lv_Abs.UseCompatibleStateImageBehavior = false;
            this.lv_Abs.View = System.Windows.Forms.View.Details;
            this.lv_Abs.SelectedIndexChanged += new System.EventHandler(this.lv_Abs_SelectedIndexChanged);
            // 
            // DatDeb
            // 
            this.DatDeb.Text = "Date Début";
            this.DatDeb.Width = 160;
            // 
            // DatFin
            // 
            this.DatFin.Text = "Date Fin";
            this.DatFin.Width = 160;
            // 
            // TypAbs
            // 
            this.TypAbs.Text = "Type Absence";
            this.TypAbs.Width = 140;
            // 
            // NbJours
            // 
            this.NbJours.Text = "Nb Jours";
            this.NbJours.Width = 75;
            // 
            // lb_test
            // 
            this.lb_test.AutoSize = true;
            this.lb_test.Enabled = false;
            this.lb_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_test.Location = new System.Drawing.Point(603, 334);
            this.lb_test.Name = "lb_test";
            this.lb_test.Size = new System.Drawing.Size(65, 25);
            this.lb_test.TabIndex = 31;
            this.lb_test.Text = "TEST";
            this.lb_test.Visible = false;
            // 
            // fmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lv_Abs);
            this.Controls.Add(this.cb_EmpAbs);
            this.Controls.Add(this.cb_TypAbs);
            this.Controls.Add(this.lb_TypAbs);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lb_EmpAbs);
            this.Controls.Add(this.lb_DatFinAbs);
            this.Controls.Add(this.lb_DatDebAbs);
            this.Controls.Add(this.datFinPicker);
            this.Controls.Add(this.datDebPicker);
            this.Controls.Add(this.lb_test);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fmAbsence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Absences";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmAbsence_FormClosed);
            this.Load += new System.EventHandler(this.fmAbsence_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datDebPicker;
        private System.Windows.Forms.DateTimePicker datFinPicker;
        private System.Windows.Forms.Label lb_DatDebAbs;
        private System.Windows.Forms.Label lb_DatFinAbs;
        private System.Windows.Forms.Label lb_EmpAbs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file_tool;
        private System.Windows.Forms.ToolStripMenuItem mi_new;
        private System.Windows.Forms.ToolStripMenuItem mi_modify;
        private System.Windows.Forms.ToolStripMenuItem mi_save;
        private System.Windows.Forms.ToolStripMenuItem mi_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mi_quit;
        private System.Windows.Forms.Label lb_TypAbs;
        private System.Windows.Forms.ComboBox cb_TypAbs;
        private System.Windows.Forms.ComboBox cb_EmpAbs;
        private System.Windows.Forms.ListView lv_Abs;
        private System.Windows.Forms.ColumnHeader DatDeb;
        private System.Windows.Forms.ColumnHeader DatFin;
        private System.Windows.Forms.ColumnHeader TypAbs;
        private System.Windows.Forms.ColumnHeader NbJours;
        private System.Windows.Forms.Label lb_test;
    }
}