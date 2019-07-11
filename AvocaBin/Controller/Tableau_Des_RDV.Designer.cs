namespace AvocaBin
{
    partial class Tableau_Des_RDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tableau_Des_RDV));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomRDV = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePickerARDV = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeRDV = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePickerDateRDV = new System.Windows.Forms.DateTimePicker();
            this.txtDescriptionRDV = new System.Windows.Forms.TextBox();
            this.txtBoxNomRDV = new System.Windows.Forms.TextBox();
            this.txtBoxCinRDV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(460, 390);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CinRDV";
            this.Column1.HeaderText = "بطاقة الوطنية";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nom";
            this.Column2.HeaderText = "الاسم الكامل ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DateRDV";
            this.Column3.HeaderText = "التاريخ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Cause";
            this.Column4.HeaderText = "سبب الموعد";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.dropDownButton1);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtNomRDV);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.dateTimePickerARDV);
            this.groupControl1.Controls.Add(this.dateTimePickerDeRDV);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 19);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(457, 184);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "البحث";
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.dropDownButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.dropDownButton1.ImageUri.Uri = "Clear";
            this.dropDownButton1.Location = new System.Drawing.Point(156, 131);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(30, 20);
            this.dropDownButton1.TabIndex = 14;
            this.dropDownButton1.Click += new System.EventHandler(this.dropDownButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "الاسم :";
            // 
            // txtNomRDV
            // 
            this.txtNomRDV.Location = new System.Drawing.Point(156, 131);
            this.txtNomRDV.Name = "txtNomRDV";
            this.txtNomRDV.Size = new System.Drawing.Size(200, 21);
            this.txtNomRDV.TabIndex = 5;
            this.txtNomRDV.TextChanged += new System.EventHandler(this.txtNomRDV_TextChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageUri.Uri = "Zoom";
            this.simpleButton1.Location = new System.Drawing.Point(45, 89);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 40);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "بحث";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dateTimePickerARDV
            // 
            this.dateTimePickerARDV.Location = new System.Drawing.Point(156, 96);
            this.dateTimePickerARDV.Name = "dateTimePickerARDV";
            this.dateTimePickerARDV.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerARDV.TabIndex = 3;
            // 
            // dateTimePickerDeRDV
            // 
            this.dateTimePickerDeRDV.Location = new System.Drawing.Point(156, 63);
            this.dateTimePickerDeRDV.Name = "dateTimePickerDeRDV";
            this.dateTimePickerDeRDV.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerDeRDV.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "الى :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "من :";
            // 
            // simpleButton7
            // 
            this.simpleButton7.ImageUri.Uri = "Edit";
            this.simpleButton7.Location = new System.Drawing.Point(379, 335);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(90, 39);
            this.simpleButton7.TabIndex = 11;
            this.simpleButton7.Text = "تعديل";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // simpleButton8
            // 
            this.simpleButton8.ImageUri.Uri = "Delete";
            this.simpleButton8.Location = new System.Drawing.Point(283, 335);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(90, 39);
            this.simpleButton8.TabIndex = 10;
            this.simpleButton8.Text = "حدف";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(this.simpleButton4);
            this.groupControl2.Controls.Add(this.simpleButton7);
            this.groupControl2.Controls.Add(this.simpleButton8);
            this.groupControl2.Controls.Add(this.simpleButton5);
            this.groupControl2.Controls.Add(this.dateTimePickerDateRDV);
            this.groupControl2.Controls.Add(this.txtDescriptionRDV);
            this.groupControl2.Controls.Add(this.txtBoxNomRDV);
            this.groupControl2.Controls.Add(this.txtBoxCinRDV);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Location = new System.Drawing.Point(492, 19);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(535, 406);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "المواعيد";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageUri.Uri = "Clear";
            this.simpleButton4.Location = new System.Drawing.Point(178, 335);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(99, 39);
            this.simpleButton4.TabIndex = 11;
            this.simpleButton4.Text = "موعد جديد";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageUri.Uri = "Add";
            this.simpleButton5.Location = new System.Drawing.Point(82, 335);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(90, 39);
            this.simpleButton5.TabIndex = 10;
            this.simpleButton5.Text = "اضافة ";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // dateTimePickerDateRDV
            // 
            this.dateTimePickerDateRDV.Location = new System.Drawing.Point(122, 120);
            this.dateTimePickerDateRDV.Name = "dateTimePickerDateRDV";
            this.dateTimePickerDateRDV.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerDateRDV.TabIndex = 7;
            this.dateTimePickerDateRDV.Value = new System.DateTime(2017, 6, 7, 14, 43, 24, 0);
            // 
            // txtDescriptionRDV
            // 
            this.txtDescriptionRDV.Location = new System.Drawing.Point(124, 229);
            this.txtDescriptionRDV.Multiline = true;
            this.txtDescriptionRDV.Name = "txtDescriptionRDV";
            this.txtDescriptionRDV.Size = new System.Drawing.Size(198, 69);
            this.txtDescriptionRDV.TabIndex = 6;
            this.txtDescriptionRDV.TextChanged += new System.EventHandler(this.txtDescriptionRDV_TextChanged);
            // 
            // txtBoxNomRDV
            // 
            this.txtBoxNomRDV.Location = new System.Drawing.Point(124, 175);
            this.txtBoxNomRDV.Name = "txtBoxNomRDV";
            this.txtBoxNomRDV.Size = new System.Drawing.Size(198, 21);
            this.txtBoxNomRDV.TabIndex = 5;
            // 
            // txtBoxCinRDV
            // 
            this.txtBoxCinRDV.Location = new System.Drawing.Point(124, 72);
            this.txtBoxCinRDV.Name = "txtBoxCinRDV";
            this.txtBoxCinRDV.Size = new System.Drawing.Size(198, 21);
            this.txtBoxCinRDV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "سبب الموعد :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "الاسم الكامل :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "التاريخ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "البطاقة الوطنية :";
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageUri.Uri = "Refresh";
            this.simpleButton6.Location = new System.Drawing.Point(209, 605);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(75, 40);
            this.simpleButton6.TabIndex = 13;
            this.simpleButton6.Text = "تحديث";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AvocaBin.Properties.Resources._6_1__01;
            this.pictureBox1.Location = new System.Drawing.Point(492, 449);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // simpleButton9
            // 
            this.simpleButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton9.Appearance.Options.UseFont = true;
            this.simpleButton9.Location = new System.Drawing.Point(28, 605);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(175, 39);
            this.simpleButton9.TabIndex = 47;
            this.simpleButton9.Text = "ارسال الى الاكسل";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // Tableau_Des_RDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 657);
            this.Controls.Add(this.simpleButton9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tableau_Des_RDV";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جدول المواعيد";
            this.Load += new System.EventHandler(this.Tableau_Des_RDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DateTimePicker dateTimePickerARDV;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeRDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomRDV;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateRDV;
        private System.Windows.Forms.TextBox txtDescriptionRDV;
        private System.Windows.Forms.TextBox txtBoxNomRDV;
        private System.Windows.Forms.TextBox txtBoxCinRDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}