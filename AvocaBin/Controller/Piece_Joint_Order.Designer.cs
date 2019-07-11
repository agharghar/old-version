namespace AvocaBin
{
    partial class Piece_Joint_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Piece_Joint_Order));
            this.Btn_Aficher_Tous = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_searsh = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_pj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_enregistrement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_num_cause = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_telecharger = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Aficher_Tous
            // 
            this.Btn_Aficher_Tous.ImageUri.Uri = "Home;Office2013";
            this.Btn_Aficher_Tous.Location = new System.Drawing.Point(448, 127);
            this.Btn_Aficher_Tous.Name = "Btn_Aficher_Tous";
            this.Btn_Aficher_Tous.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_Aficher_Tous.Size = new System.Drawing.Size(106, 39);
            this.Btn_Aficher_Tous.TabIndex = 31;
            this.Btn_Aficher_Tous.Text = "اضهار الكل";
            this.Btn_Aficher_Tous.Click += new System.EventHandler(this.Btn_Aficher_Tous_Click);
            // 
            // Btn_searsh
            // 
            this.Btn_searsh.ImageUri.Uri = "Preview;Office2013";
            this.Btn_searsh.Location = new System.Drawing.Point(352, 128);
            this.Btn_searsh.Name = "Btn_searsh";
            this.Btn_searsh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_searsh.Size = new System.Drawing.Size(75, 39);
            this.Btn_searsh.TabIndex = 26;
            this.Btn_searsh.Text = "بحث";
            this.Btn_searsh.Click += new System.EventHandler(this.Btn_searsh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 137);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "البحث برقم الامر :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pj,
            this.photo,
            this.titre,
            this.date_enregistrement,
            this.id_order});
            this.dataGridView1.Location = new System.Drawing.Point(11, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(711, 291);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_pj
            // 
            this.id_pj.DataPropertyName = "id_pj";
            this.id_pj.HeaderText = "المرجع";
            this.id_pj.Name = "id_pj";
            this.id_pj.ReadOnly = true;
            // 
            // photo
            // 
            this.photo.DataPropertyName = "photo";
            this.photo.HeaderText = "الصورة";
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            this.photo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.photo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // titre
            // 
            this.titre.DataPropertyName = "titre";
            this.titre.HeaderText = "العنوان";
            this.titre.Name = "titre";
            this.titre.ReadOnly = true;
            // 
            // date_enregistrement
            // 
            this.date_enregistrement.DataPropertyName = "date_enregistrement";
            this.date_enregistrement.HeaderText = "التاريخ";
            this.date_enregistrement.Name = "date_enregistrement";
            this.date_enregistrement.ReadOnly = true;
            // 
            // id_order
            // 
            this.id_order.DataPropertyName = "id_order";
            this.id_order.HeaderText = "الآمر";
            this.id_order.Name = "id_order";
            this.id_order.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 21);
            this.textBox1.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(728, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_num_cause);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_telecharger);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 92);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إضافة";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(235, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 33);
            this.label5.TabIndex = 39;
            this.label5.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(235, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 33);
            this.label4.TabIndex = 39;
            this.label4.Text = ".";
            // 
            // cb_num_cause
            // 
            this.cb_num_cause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_num_cause.FormattingEnabled = true;
            this.cb_num_cause.Location = new System.Drawing.Point(459, 47);
            this.cb_num_cause.Name = "cb_num_cause";
            this.cb_num_cause.Size = new System.Drawing.Size(179, 21);
            this.cb_num_cause.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 50);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "الوثائق :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 50);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "رقم الامر :";
            // 
            // btn_add
            // 
            this.btn_add.ImageUri.Uri = "Add";
            this.btn_add.Location = new System.Drawing.Point(62, 37);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(106, 39);
            this.btn_add.TabIndex = 35;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_telecharger
            // 
            this.btn_telecharger.ImageUri.Uri = "Open";
            this.btn_telecharger.Location = new System.Drawing.Point(264, 37);
            this.btn_telecharger.Name = "btn_telecharger";
            this.btn_telecharger.Size = new System.Drawing.Size(106, 39);
            this.btn_telecharger.TabIndex = 35;
            this.btn_telecharger.Text = "تحميل";
            this.btn_telecharger.Click += new System.EventHandler(this.btn_telecharger_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.ImageUri.Uri = "Delete";
            this.btn_delete.Location = new System.Drawing.Point(570, 128);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(106, 39);
            this.btn_delete.TabIndex = 39;
            this.btn_delete.Text = "حدف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Piece_Joint_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 495);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Aficher_Tous);
            this.Controls.Add(this.Btn_searsh);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Piece_Joint_Order";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Piece_Joint_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btn_Aficher_Tous;
        private DevExpress.XtraEditors.SimpleButton Btn_searsh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_num_cause;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.SimpleButton btn_telecharger;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pj;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_enregistrement;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_order;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
    }
}