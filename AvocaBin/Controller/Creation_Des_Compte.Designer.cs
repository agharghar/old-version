namespace AvocaBin
{
    partial class Creation_Des_Compte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creation_Des_Compte));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbFonction = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCompteSortie = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCompteCreation = new DevExpress.XtraEditors.SimpleButton();
            this.txtMOTPASS = new System.Windows.Forms.TextBox();
            this.txtPRE = new System.Windows.Forms.TextBox();
            this.txtNOM = new System.Windows.Forms.TextBox();
            this.txtCIN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.معلوماتعناToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbFonction);
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.BtnCompteSortie);
            this.groupControl1.Controls.Add(this.BtnCompteCreation);
            this.groupControl1.Controls.Add(this.txtMOTPASS);
            this.groupControl1.Controls.Add(this.txtPRE);
            this.groupControl1.Controls.Add(this.txtNOM);
            this.groupControl1.Controls.Add(this.txtCIN);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 42);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(557, 401);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "حساب جديد";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // cmbFonction
            // 
            this.cmbFonction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFonction.FormattingEnabled = true;
            this.cmbFonction.Location = new System.Drawing.Point(220, 212);
            this.cmbFonction.Name = "cmbFonction";
            this.cmbFonction.Size = new System.Drawing.Size(193, 21);
            this.cmbFonction.TabIndex = 18;
            this.cmbFonction.SelectedIndexChanged += new System.EventHandler(this.cmbFonction_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AvocaBin.Properties.Resources._6_1__01;
            this.pictureBox1.Location = new System.Drawing.Point(18, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCompteSortie
            // 
            this.BtnCompteSortie.ImageUri.Uri = "Cancel";
            this.BtnCompteSortie.Location = new System.Drawing.Point(131, 341);
            this.BtnCompteSortie.Name = "BtnCompteSortie";
            this.BtnCompteSortie.Size = new System.Drawing.Size(89, 36);
            this.BtnCompteSortie.TabIndex = 16;
            this.BtnCompteSortie.Text = "خروج";
            this.BtnCompteSortie.Click += new System.EventHandler(this.BtnCompteSortie_Click);
            // 
            // BtnCompteCreation
            // 
            this.BtnCompteCreation.ImageUri.Uri = "Apply";
            this.BtnCompteCreation.Location = new System.Drawing.Point(29, 341);
            this.BtnCompteCreation.Name = "BtnCompteCreation";
            this.BtnCompteCreation.Size = new System.Drawing.Size(89, 36);
            this.BtnCompteCreation.TabIndex = 14;
            this.BtnCompteCreation.Text = "انشاء";
            this.BtnCompteCreation.Click += new System.EventHandler(this.BtnCompteCreation_Click);
            // 
            // txtMOTPASS
            // 
            this.txtMOTPASS.Location = new System.Drawing.Point(220, 175);
            this.txtMOTPASS.Name = "txtMOTPASS";
            this.txtMOTPASS.PasswordChar = '*';
            this.txtMOTPASS.Size = new System.Drawing.Size(193, 21);
            this.txtMOTPASS.TabIndex = 12;
            // 
            // txtPRE
            // 
            this.txtPRE.Location = new System.Drawing.Point(220, 131);
            this.txtPRE.Name = "txtPRE";
            this.txtPRE.Size = new System.Drawing.Size(193, 21);
            this.txtPRE.TabIndex = 9;
            // 
            // txtNOM
            // 
            this.txtNOM.Location = new System.Drawing.Point(220, 94);
            this.txtNOM.Name = "txtNOM";
            this.txtNOM.Size = new System.Drawing.Size(193, 21);
            this.txtNOM.TabIndex = 8;
            // 
            // txtCIN
            // 
            this.txtCIN.Location = new System.Drawing.Point(220, 57);
            this.txtCIN.Name = "txtCIN";
            this.txtCIN.Size = new System.Drawing.Size(193, 21);
            this.txtCIN.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "الوظيفة :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "الرقم السري :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "الاسم الشخصي :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم العائلي :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم البطاقة الوطنية :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.معلوماتعناToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(26, 20);
            this.toolStripMenuItem1.Text = "؟";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // معلوماتعناToolStripMenuItem
            // 
            this.معلوماتعناToolStripMenuItem.Name = "معلوماتعناToolStripMenuItem";
            this.معلوماتعناToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.معلوماتعناToolStripMenuItem.Text = "معلومات عنا ...";
            this.معلوماتعناToolStripMenuItem.Click += new System.EventHandler(this.معلوماتعناToolStripMenuItem_Click);
            // 
            // Creation_Des_Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 472);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Creation_Des_Compte";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انشاء حساب جديد";
            this.Load += new System.EventHandler(this.Creation_Des_Compte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtMOTPASS;
        private System.Windows.Forms.TextBox txtPRE;
        private System.Windows.Forms.TextBox txtNOM;
        private System.Windows.Forms.TextBox txtCIN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton BtnCompteCreation;
        private DevExpress.XtraEditors.SimpleButton BtnCompteSortie;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem معلوماتعناToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbFonction;
    }
}