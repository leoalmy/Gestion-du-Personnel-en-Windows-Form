namespace GesPerWinForm
{
    partial class fmService
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_modify = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_SceCode = new System.Windows.Forms.Label();
            this.lb_SceBud = new System.Windows.Forms.Label();
            this.lb_SceDes = new System.Windows.Forms.Label();
            this.lb_SceType = new System.Windows.Forms.Label();
            this.tb_SceCode = new System.Windows.Forms.TextBox();
            this.tb_SceDes = new System.Windows.Forms.TextBox();
            this.tb_SceBud = new System.Windows.Forms.TextBox();
            this.rb_Admin = new System.Windows.Forms.RadioButton();
            this.rb_Prod = new System.Windows.Forms.RadioButton();
            this.lv_Sce = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Désignation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Budget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rb_Unknown = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_tool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 2;
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
            this.file_tool.Size = new System.Drawing.Size(70, 26);
            this.file_tool.Text = "Service";
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
            // lb_SceCode
            // 
            this.lb_SceCode.AutoSize = true;
            this.lb_SceCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SceCode.Location = new System.Drawing.Point(53, 63);
            this.lb_SceCode.Name = "lb_SceCode";
            this.lb_SceCode.Size = new System.Drawing.Size(114, 20);
            this.lb_SceCode.TabIndex = 3;
            this.lb_SceCode.Text = "Code Service:";
            // 
            // lb_SceBud
            // 
            this.lb_SceBud.AutoSize = true;
            this.lb_SceBud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SceBud.Location = new System.Drawing.Point(53, 203);
            this.lb_SceBud.Name = "lb_SceBud";
            this.lb_SceBud.Size = new System.Drawing.Size(67, 20);
            this.lb_SceBud.TabIndex = 4;
            this.lb_SceBud.Text = "Budget:";
            // 
            // lb_SceDes
            // 
            this.lb_SceDes.AutoSize = true;
            this.lb_SceDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SceDes.Location = new System.Drawing.Point(53, 105);
            this.lb_SceDes.Name = "lb_SceDes";
            this.lb_SceDes.Size = new System.Drawing.Size(103, 20);
            this.lb_SceDes.TabIndex = 5;
            this.lb_SceDes.Text = "Désignation:";
            // 
            // lb_SceType
            // 
            this.lb_SceType.AutoSize = true;
            this.lb_SceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SceType.Location = new System.Drawing.Point(53, 151);
            this.lb_SceType.Name = "lb_SceType";
            this.lb_SceType.Size = new System.Drawing.Size(50, 20);
            this.lb_SceType.TabIndex = 6;
            this.lb_SceType.Text = "Type:";
            // 
            // tb_SceCode
            // 
            this.tb_SceCode.Location = new System.Drawing.Point(173, 63);
            this.tb_SceCode.Name = "tb_SceCode";
            this.tb_SceCode.Size = new System.Drawing.Size(152, 22);
            this.tb_SceCode.TabIndex = 7;
            // 
            // tb_SceDes
            // 
            this.tb_SceDes.Location = new System.Drawing.Point(173, 103);
            this.tb_SceDes.MaxLength = 50;
            this.tb_SceDes.Name = "tb_SceDes";
            this.tb_SceDes.Size = new System.Drawing.Size(152, 22);
            this.tb_SceDes.TabIndex = 8;
            // 
            // tb_SceBud
            // 
            this.tb_SceBud.Location = new System.Drawing.Point(173, 201);
            this.tb_SceBud.MaxLength = 18;
            this.tb_SceBud.Name = "tb_SceBud";
            this.tb_SceBud.Size = new System.Drawing.Size(152, 22);
            this.tb_SceBud.TabIndex = 9;
            // 
            // rb_Admin
            // 
            this.rb_Admin.AutoSize = true;
            this.rb_Admin.Location = new System.Drawing.Point(173, 152);
            this.rb_Admin.Name = "rb_Admin";
            this.rb_Admin.Size = new System.Drawing.Size(100, 20);
            this.rb_Admin.TabIndex = 10;
            this.rb_Admin.TabStop = true;
            this.rb_Admin.Text = "Administratif";
            this.rb_Admin.UseVisualStyleBackColor = true;
            // 
            // rb_Prod
            // 
            this.rb_Prod.AutoSize = true;
            this.rb_Prod.Location = new System.Drawing.Point(279, 152);
            this.rb_Prod.Name = "rb_Prod";
            this.rb_Prod.Size = new System.Drawing.Size(80, 20);
            this.rb_Prod.TabIndex = 11;
            this.rb_Prod.TabStop = true;
            this.rb_Prod.Text = "Productif";
            this.rb_Prod.UseVisualStyleBackColor = true;
            // 
            // lv_Sce
            // 
            this.lv_Sce.BackColor = System.Drawing.SystemColors.Control;
            this.lv_Sce.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.Désignation,
            this.Type,
            this.Budget});
            this.lv_Sce.FullRowSelect = true;
            this.lv_Sce.GridLines = true;
            this.lv_Sce.HideSelection = false;
            this.lv_Sce.Location = new System.Drawing.Point(57, 241);
            this.lv_Sce.Name = "lv_Sce";
            this.lv_Sce.Size = new System.Drawing.Size(722, 205);
            this.lv_Sce.TabIndex = 12;
            this.lv_Sce.UseCompatibleStateImageBehavior = false;
            this.lv_Sce.View = System.Windows.Forms.View.Details;
            this.lv_Sce.Click += new System.EventHandler(this.Lv_Sce_Click);
            // 
            // Code
            // 
            this.Code.Text = "Code";
            // 
            // Désignation
            // 
            this.Désignation.Text = "Désignation";
            this.Désignation.Width = 139;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 143;
            // 
            // Budget
            // 
            this.Budget.Text = "Budget";
            this.Budget.Width = 73;
            // 
            // rb_Unknown
            // 
            this.rb_Unknown.AutoSize = true;
            this.rb_Unknown.Enabled = false;
            this.rb_Unknown.Location = new System.Drawing.Point(365, 152);
            this.rb_Unknown.Name = "rb_Unknown";
            this.rb_Unknown.Size = new System.Drawing.Size(83, 20);
            this.rb_Unknown.TabIndex = 13;
            this.rb_Unknown.TabStop = true;
            this.rb_Unknown.Text = "Unknown";
            this.rb_Unknown.UseVisualStyleBackColor = true;
            this.rb_Unknown.Visible = false;
            // 
            // fmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rb_Unknown);
            this.Controls.Add(this.lv_Sce);
            this.Controls.Add(this.rb_Prod);
            this.Controls.Add(this.rb_Admin);
            this.Controls.Add(this.tb_SceBud);
            this.Controls.Add(this.tb_SceDes);
            this.Controls.Add(this.tb_SceCode);
            this.Controls.Add(this.lb_SceType);
            this.Controls.Add(this.lb_SceDes);
            this.Controls.Add(this.lb_SceBud);
            this.Controls.Add(this.lb_SceCode);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "fmService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmService_FormClosed);
            this.Load += new System.EventHandler(this.fmService_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file_tool;
        private System.Windows.Forms.ToolStripMenuItem mi_new;
        private System.Windows.Forms.ToolStripMenuItem mi_modify;
        private System.Windows.Forms.ToolStripMenuItem mi_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mi_quit;
        private System.Windows.Forms.Label lb_SceCode;
        private System.Windows.Forms.Label lb_SceBud;
        private System.Windows.Forms.Label lb_SceDes;
        private System.Windows.Forms.Label lb_SceType;
        private System.Windows.Forms.TextBox tb_SceCode;
        private System.Windows.Forms.TextBox tb_SceDes;
        private System.Windows.Forms.TextBox tb_SceBud;
        private System.Windows.Forms.ToolStripMenuItem mi_delete;
        private System.Windows.Forms.RadioButton rb_Admin;
        private System.Windows.Forms.RadioButton rb_Prod;
        private System.Windows.Forms.ListView lv_Sce;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Désignation;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Budget;
        private System.Windows.Forms.RadioButton rb_Unknown;
    }
}

