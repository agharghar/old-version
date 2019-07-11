namespace AvocaBin
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelCréerCompte = new System.Windows.Forms.LinkLabel();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnConx = new DevExpress.XtraEditors.SimpleButton();
            this.txtbxPasse = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxCIN = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.dropDownButton2 = new DevExpress.XtraEditors.DropDownButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AvocaBin.Properties.Resources._6_1__01;
            this.pictureBox1.Location = new System.Drawing.Point(108, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelCréerCompte
            // 
            this.linkLabelCréerCompte.AutoSize = true;
            this.linkLabelCréerCompte.Location = new System.Drawing.Point(43, 245);
            this.linkLabelCréerCompte.Name = "linkLabelCréerCompte";
            this.linkLabelCréerCompte.Size = new System.Drawing.Size(66, 13);
            this.linkLabelCréerCompte.TabIndex = 16;
            this.linkLabelCréerCompte.TabStop = true;
            this.linkLabelCréerCompte.Text = "انشاء حساب";
            this.linkLabelCréerCompte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCréerCompte_LinkClicked);
            // 
            // BtnClose
            // 
            this.BtnClose.ImageUri.Uri = "Cancel;Colored";
            this.BtnClose.Location = new System.Drawing.Point(310, 258);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(61, 38);
            this.BtnClose.TabIndex = 15;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click_1);
            // 
            // BtnConx
            // 
            this.BtnConx.ImageUri.Uri = "Apply;Colored";
            this.BtnConx.Location = new System.Drawing.Point(386, 258);
            this.BtnConx.Name = "BtnConx";
            this.BtnConx.Size = new System.Drawing.Size(57, 38);
            this.BtnConx.TabIndex = 14;
            this.BtnConx.Click += new System.EventHandler(this.BtnConx_Click_1);
            // 
            // txtbxPasse
            // 
            this.txtbxPasse.Location = new System.Drawing.Point(43, 209);
            this.txtbxPasse.Name = "txtbxPasse";
            this.txtbxPasse.PasswordChar = '*';
            this.txtbxPasse.Size = new System.Drawing.Size(247, 21);
            this.txtbxPasse.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(345, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "كلمة المرور :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(345, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "رقم البطاقة الوطنية :";
            // 
            // txtbxCIN
            // 
            this.txtbxCIN.Location = new System.Drawing.Point(43, 167);
            this.txtbxCIN.Name = "txtbxCIN";
            this.txtbxCIN.Size = new System.Drawing.Size(247, 21);
            this.txtbxCIN.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.dropDownButton1.ImageUri.Uri = "Clear;Colored";
            this.dropDownButton1.Location = new System.Drawing.Point(43, 167);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(28, 20);
            this.dropDownButton1.TabIndex = 19;
            this.dropDownButton1.Text = "dropDownButton1";
            this.dropDownButton1.Click += new System.EventHandler(this.dropDownButton1_Click);
            // 
            // dropDownButton2
            // 
            this.dropDownButton2.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.dropDownButton2.ImageUri.Uri = "Clear;Colored";
            this.dropDownButton2.Location = new System.Drawing.Point(43, 210);
            this.dropDownButton2.Name = "dropDownButton2";
            this.dropDownButton2.Size = new System.Drawing.Size(28, 20);
            this.dropDownButton2.TabIndex = 20;
            this.dropDownButton2.Text = "dropDownButton2";
            this.dropDownButton2.Click += new System.EventHandler(this.dropDownButton2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(145, 245);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 13);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "اعدادات السيرفر";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 313);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dropDownButton2);
            this.Controls.Add(this.dropDownButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelCréerCompte);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnConx);
            this.Controls.Add(this.txtbxPasse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxCIN);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الدخول";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Enter += new System.EventHandler(this.Login_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelCréerCompte;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnConx;
        private System.Windows.Forms.MaskedTextBox txtbxPasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxCIN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraEditors.DropDownButton dropDownButton2;
        private System.Windows.Forms.LinkLabel linkLabel1;

    }
}