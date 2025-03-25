namespace GesPerWinForm
{
    partial class fmMenu
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
            this.lbMenu = new System.Windows.Forms.Label();
            this.btSce = new System.Windows.Forms.Button();
            this.btEmp = new System.Windows.Forms.Button();
            this.btAbs = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.Location = new System.Drawing.Point(36, 30);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(404, 46);
            this.lbMenu.TabIndex = 0;
            this.lbMenu.Text = "Gestion du Personnel";
            // 
            // btSce
            // 
            this.btSce.BackColor = System.Drawing.Color.Silver;
            this.btSce.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btSce.FlatAppearance.BorderSize = 0;
            this.btSce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSce.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSce.Location = new System.Drawing.Point(450, 120);
            this.btSce.Name = "btSce";
            this.btSce.Size = new System.Drawing.Size(145, 51);
            this.btSce.TabIndex = 2;
            this.btSce.Text = "Services";
            this.btSce.UseVisualStyleBackColor = false;
            this.btSce.Click += new System.EventHandler(this.btSce_Click);
            // 
            // btEmp
            // 
            this.btEmp.BackColor = System.Drawing.Color.Silver;
            this.btEmp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btEmp.FlatAppearance.BorderSize = 0;
            this.btEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmp.Location = new System.Drawing.Point(450, 209);
            this.btEmp.Name = "btEmp";
            this.btEmp.Size = new System.Drawing.Size(145, 51);
            this.btEmp.TabIndex = 5;
            this.btEmp.Text = "Employés";
            this.btEmp.UseVisualStyleBackColor = false;
            this.btEmp.Click += new System.EventHandler(this.btEmp_Click);
            // 
            // btAbs
            // 
            this.btAbs.BackColor = System.Drawing.Color.Silver;
            this.btAbs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btAbs.FlatAppearance.BorderSize = 0;
            this.btAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbs.Location = new System.Drawing.Point(450, 294);
            this.btAbs.Name = "btAbs";
            this.btAbs.Size = new System.Drawing.Size(145, 51);
            this.btAbs.TabIndex = 6;
            this.btAbs.Text = "Absences";
            this.btAbs.UseVisualStyleBackColor = false;
            this.btAbs.Click += new System.EventHandler(this.btAbs_Click);
            // 
            // picBox
            // 
            this.picBox.Image = global::GesPerWinForm.Properties.Resources.rh;
            this.picBox.Location = new System.Drawing.Point(78, 90);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(320, 320);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // fmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.btAbs);
            this.Controls.Add(this.btEmp);
            this.Controls.Add(this.btSce);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.lbMenu);
            this.MinimumSize = new System.Drawing.Size(647, 497);
            this.Name = "fmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btSce;
        private System.Windows.Forms.Button btEmp;
        private System.Windows.Forms.Button btAbs;
    }
}