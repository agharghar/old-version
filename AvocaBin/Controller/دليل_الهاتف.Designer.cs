namespace AvocaBin
{
    partial class دليل_الهاتف
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(دليل_الهاتف));
            this.radioButtonClient = new System.Windows.Forms.RadioButton();
            this.radioButtonAutre = new System.Windows.Forms.RadioButton();
            this.textBoxRechercheContact = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.textBoxNomContact = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.simpleButtonAjouter = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSupprimer = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonModification = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.simpleButtonRefreche = new DevExpress.XtraEditors.SimpleButton();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonClient
            // 
            this.radioButtonClient.AutoSize = true;
            this.radioButtonClient.Location = new System.Drawing.Point(623, 38);
            this.radioButtonClient.Name = "radioButtonClient";
            this.radioButtonClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonClient.Size = new System.Drawing.Size(64, 17);
            this.radioButtonClient.TabIndex = 0;
            this.radioButtonClient.TabStop = true;
            this.radioButtonClient.Text = "الموكلون";
            this.radioButtonClient.UseVisualStyleBackColor = true;
            this.radioButtonClient.CheckedChanged += new System.EventHandler(this.radioButtonClient_CheckedChanged);
            // 
            // radioButtonAutre
            // 
            this.radioButtonAutre.AutoSize = true;
            this.radioButtonAutre.Location = new System.Drawing.Point(511, 38);
            this.radioButtonAutre.Name = "radioButtonAutre";
            this.radioButtonAutre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonAutre.Size = new System.Drawing.Size(50, 17);
            this.radioButtonAutre.TabIndex = 0;
            this.radioButtonAutre.TabStop = true;
            this.radioButtonAutre.Text = "اخرى";
            this.radioButtonAutre.UseVisualStyleBackColor = true;
            this.radioButtonAutre.CheckedChanged += new System.EventHandler(this.radioButtonAutre_CheckedChanged);
            // 
            // textBoxRechercheContact
            // 
            this.textBoxRechercheContact.Location = new System.Drawing.Point(491, 83);
            this.textBoxRechercheContact.Name = "textBoxRechercheContact";
            this.textBoxRechercheContact.Size = new System.Drawing.Size(228, 21);
            this.textBoxRechercheContact.TabIndex = 1;
            this.textBoxRechercheContact.TextChanged += new System.EventHandler(this.textBoxRechercheContact_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(482, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(247, 264);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "الاسم الكامل ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "الهاتف";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 58);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "الاسم الكامل :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 111);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "الهاتف :";
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(372, 5);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(20, 388);
            this.separatorControl1.TabIndex = 4;
            // 
            // textBoxNomContact
            // 
            this.textBoxNomContact.Location = new System.Drawing.Point(152, 55);
            this.textBoxNomContact.Name = "textBoxNomContact";
            this.textBoxNomContact.Size = new System.Drawing.Size(177, 21);
            this.textBoxNomContact.TabIndex = 5;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(152, 108);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(177, 21);
            this.textBoxTel.TabIndex = 5;
            // 
            // simpleButtonAjouter
            // 
            this.simpleButtonAjouter.ImageUri.Uri = "Add;Colored";
            this.simpleButtonAjouter.Location = new System.Drawing.Point(30, 224);
            this.simpleButtonAjouter.Name = "simpleButtonAjouter";
            this.simpleButtonAjouter.Size = new System.Drawing.Size(102, 34);
            this.simpleButtonAjouter.TabIndex = 6;
            this.simpleButtonAjouter.Text = "اضافة";
            this.simpleButtonAjouter.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButtonSupprimer
            // 
            this.simpleButtonSupprimer.ImageUri.Uri = "Delete;Colored";
            this.simpleButtonSupprimer.Location = new System.Drawing.Point(255, 224);
            this.simpleButtonSupprimer.Name = "simpleButtonSupprimer";
            this.simpleButtonSupprimer.Size = new System.Drawing.Size(102, 34);
            this.simpleButtonSupprimer.TabIndex = 6;
            this.simpleButtonSupprimer.Text = "حذف";
            this.simpleButtonSupprimer.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButtonModification
            // 
            this.simpleButtonModification.ImageUri.Uri = "Edit;Colored";
            this.simpleButtonModification.Location = new System.Drawing.Point(143, 224);
            this.simpleButtonModification.Name = "simpleButtonModification";
            this.simpleButtonModification.Size = new System.Drawing.Size(102, 34);
            this.simpleButtonModification.TabIndex = 6;
            this.simpleButtonModification.Text = "تعديل";
            this.simpleButtonModification.Click += new System.EventHandler(this.simpleButtonModification_Click);
            // 
            // simpleButtonClose
            // 
            this.simpleButtonClose.ImageUri.Uri = "Close;Colored";
            this.simpleButtonClose.Location = new System.Drawing.Point(143, 273);
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new System.Drawing.Size(102, 34);
            this.simpleButtonClose.TabIndex = 7;
            this.simpleButtonClose.Text = "خروج";
            this.simpleButtonClose.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // separatorControl2
            // 
            this.separatorControl2.Location = new System.Drawing.Point(30, 167);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(327, 25);
            this.separatorControl2.TabIndex = 8;
            // 
            // simpleButtonRefreche
            // 
            this.simpleButtonRefreche.ImageUri.Uri = "Refresh;Colored";
            this.simpleButtonRefreche.Location = new System.Drawing.Point(398, 354);
            this.simpleButtonRefreche.Name = "simpleButtonRefreche";
            this.simpleButtonRefreche.Size = new System.Drawing.Size(73, 34);
            this.simpleButtonRefreche.TabIndex = 9;
            this.simpleButtonRefreche.Text = "ثحديث";
            this.simpleButtonRefreche.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.dropDownButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.dropDownButton1.ImageUri.Uri = "Clear;Colored";
            this.dropDownButton1.Location = new System.Drawing.Point(689, 83);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(30, 20);
            this.dropDownButton1.TabIndex = 13;
            this.dropDownButton1.Click += new System.EventHandler(this.dropDownButton1_Click);
            // 
            // دليل_الهاتف
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 405);
            this.Controls.Add(this.dropDownButton1);
            this.Controls.Add(this.simpleButtonRefreche);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.simpleButtonClose);
            this.Controls.Add(this.simpleButtonSupprimer);
            this.Controls.Add(this.simpleButtonModification);
            this.Controls.Add(this.simpleButtonAjouter);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxNomContact);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxRechercheContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonAutre);
            this.Controls.Add(this.radioButtonClient);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "دليل_الهاتف";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دليل_الهاتف";
            this.Load += new System.EventHandler(this.دليل_الهاتف_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonClient;
        private System.Windows.Forms.RadioButton radioButtonAutre;
        private System.Windows.Forms.TextBox textBoxRechercheContact;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.TextBox textBoxNomContact;
        private System.Windows.Forms.TextBox textBoxTel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAjouter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSupprimer;
        private DevExpress.XtraEditors.SimpleButton simpleButtonModification;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRefreche;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
    }
}