namespace AvocaBin
{
    partial class Piéce_Joint_Plainte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Piéce_Joint_Plainte));
            this.Btn_searsh = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdPlainte = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colidpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colidPlainte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltitepj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colimg = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_searsh
            // 
            this.Btn_searsh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.Btn_searsh.ImageUri.Uri = "Zoom;Colored";
            this.Btn_searsh.Location = new System.Drawing.Point(477, 153);
            this.Btn_searsh.Name = "Btn_searsh";
            this.Btn_searsh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_searsh.Size = new System.Drawing.Size(75, 23);
            this.Btn_searsh.TabIndex = 26;
            this.Btn_searsh.Click += new System.EventHandler(this.Btn_searsh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 158);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "بحث بالمرجع :";
            // 
            // textBoxIdPlainte
            // 
            this.textBoxIdPlainte.Location = new System.Drawing.Point(322, 155);
            this.textBoxIdPlainte.Name = "textBoxIdPlainte";
            this.textBoxIdPlainte.Size = new System.Drawing.Size(135, 21);
            this.textBoxIdPlainte.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colidpj,
            this.colidPlainte,
            this.coltitepj,
            this.colimg});
            this.dataGridView1.Location = new System.Drawing.Point(18, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(748, 442);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // colidpj
            // 
            this.colidpj.HeaderText = "الرقم";
            this.colidpj.Name = "colidpj";
            this.colidpj.ReadOnly = true;
            // 
            // colidPlainte
            // 
            this.colidPlainte.HeaderText = "رقم الشكاية";
            this.colidPlainte.Name = "colidPlainte";
            this.colidPlainte.ReadOnly = true;
            // 
            // coltitepj
            // 
            this.coltitepj.HeaderText = "العنوان";
            this.coltitepj.Name = "coltitepj";
            this.coltitepj.ReadOnly = true;
            // 
            // colimg
            // 
            this.colimg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colimg.HeaderText = "الصورة";
            this.colimg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colimg.Name = "colimg";
            this.colimg.ReadOnly = true;
            this.colimg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colimg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(789, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 442);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageUri.Uri = "Open";
            this.simpleButton1.Location = new System.Drawing.Point(211, 83);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(126, 37);
            this.simpleButton1.TabIndex = 35;
            this.simpleButton1.Text = "تحميل ملف";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageUri.Uri = "Add";
            this.simpleButton2.Location = new System.Drawing.Point(353, 83);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(108, 37);
            this.simpleButton2.TabIndex = 35;
            this.simpleButton2.Text = "إضافة ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageUri.Uri = "Cancel";
            this.simpleButton3.Location = new System.Drawing.Point(477, 83);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(108, 37);
            this.simpleButton3.TabIndex = 35;
            this.simpleButton3.Text = "حذف";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(333, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 26);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "مرجع الشكاية :";
            // 
            // Piéce_Joint_Plainte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxIdPlainte);
            this.Controls.Add(this.Btn_searsh);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Piéce_Joint_Plainte";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الوثائق المرفقة  لشكاية ";
            this.Load += new System.EventHandler(this.Piéce_Joint_Plainte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btn_searsh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdPlainte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colidpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colidPlainte;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltitepj;
        private System.Windows.Forms.DataGridViewImageColumn colimg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}