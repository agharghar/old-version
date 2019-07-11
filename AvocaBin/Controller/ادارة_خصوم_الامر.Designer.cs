namespace AvocaBin
{
    partial class ادارة_خصوم_الامر
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ادارة_خصوم_الامر));
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_remove = new DevExpress.XtraEditors.SimpleButton();
            this.txb_searsh = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_adv_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_adv_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.representant_legal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registre_commerce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_nouveau = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ajouter = new DevExpress.XtraEditors.SimpleButton();
            this.txb_adresse = new System.Windows.Forms.TextBox();
            this.txb_cin = new System.Windows.Forms.TextBox();
            this.txb_juridique = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_num_societe = new System.Windows.Forms.TextBox();
            this.TxB_ident = new System.Windows.Forms.TextBox();
            this.CB_genre_Adv = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(445, 14);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(20, 453);
            this.separatorControl1.TabIndex = 6;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Controls.Add(this.simpleButton5);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.btn_edit);
            this.groupControl2.Controls.Add(this.btn_remove);
            this.groupControl2.Controls.Add(this.txb_searsh);
            this.groupControl2.Controls.Add(this.dataGridView1);
            this.groupControl2.Location = new System.Drawing.Point(16, 14);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(410, 453);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "جدول الخصوم";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Location = new System.Drawing.Point(22, 386);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(175, 39);
            this.simpleButton5.TabIndex = 46;
            this.simpleButton5.Text = "ارسال الى الاكسل";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.ImageUri.Uri = "Zoom;Colored";
            this.simpleButton1.Location = new System.Drawing.Point(51, 40);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(59, 36);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.ImageUri.Uri = "Edit;Colored";
            this.btn_edit.Location = new System.Drawing.Point(309, 384);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 41);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.ImageUri.Uri = "Delete;Colored";
            this.btn_remove.Location = new System.Drawing.Point(213, 384);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 41);
            this.btn_remove.TabIndex = 6;
            this.btn_remove.Text = "حدف";
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // txb_searsh
            // 
            this.txb_searsh.Location = new System.Drawing.Point(130, 48);
            this.txb_searsh.Name = "txb_searsh";
            this.txb_searsh.Size = new System.Drawing.Size(254, 21);
            this.txb_searsh.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_adv_order,
            this.type_adv_order,
            this.cin,
            this.nom,
            this.representant_legal,
            this.registre_commerce,
            this.adresse});
            this.dataGridView1.Location = new System.Drawing.Point(22, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(362, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // id_adv_order
            // 
            this.id_adv_order.DataPropertyName = "id_adv_order";
            this.id_adv_order.HeaderText = "المرجع";
            this.id_adv_order.Name = "id_adv_order";
            this.id_adv_order.ReadOnly = true;
            // 
            // type_adv_order
            // 
            this.type_adv_order.DataPropertyName = "type_adv_order";
            this.type_adv_order.HeaderText = "نوع الخصم";
            this.type_adv_order.Name = "type_adv_order";
            this.type_adv_order.ReadOnly = true;
            // 
            // cin
            // 
            this.cin.DataPropertyName = "cin";
            this.cin.HeaderText = "البطاقة الوطنية";
            this.cin.Name = "cin";
            this.cin.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "الإسم";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // representant_legal
            // 
            this.representant_legal.DataPropertyName = "representant_legal";
            this.representant_legal.HeaderText = "الممثل القانوني";
            this.representant_legal.Name = "representant_legal";
            this.representant_legal.ReadOnly = true;
            // 
            // registre_commerce
            // 
            this.registre_commerce.DataPropertyName = "registre_commerce";
            this.registre_commerce.HeaderText = "السجل القضائي";
            this.registre_commerce.Name = "registre_commerce";
            this.registre_commerce.ReadOnly = true;
            // 
            // adresse
            // 
            this.adresse.DataPropertyName = "adresse";
            this.adresse.HeaderText = "العنوان";
            this.adresse.Name = "adresse";
            this.adresse.ReadOnly = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_nouveau);
            this.groupControl1.Controls.Add(this.btn_ajouter);
            this.groupControl1.Controls.Add(this.txb_adresse);
            this.groupControl1.Controls.Add(this.txb_cin);
            this.groupControl1.Controls.Add(this.txb_juridique);
            this.groupControl1.Controls.Add(this.txb_name);
            this.groupControl1.Controls.Add(this.txb_num_societe);
            this.groupControl1.Controls.Add(this.TxB_ident);
            this.groupControl1.Controls.Add(this.CB_genre_Adv);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(483, 14);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(442, 453);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "اضافة الخصم";
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.ImageUri.Uri = "Clear;Colored";
            this.btn_nouveau.Location = new System.Drawing.Point(92, 362);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(75, 41);
            this.btn_nouveau.TabIndex = 4;
            this.btn_nouveau.Text = "جديد";
            this.btn_nouveau.Click += new System.EventHandler(this.btn_nouveau_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.ImageUri.Uri = "Add;Colored";
            this.btn_ajouter.Location = new System.Drawing.Point(213, 362);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 41);
            this.btn_ajouter.TabIndex = 3;
            this.btn_ajouter.Text = "اضافة";
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // txb_adresse
            // 
            this.txb_adresse.Location = new System.Drawing.Point(92, 277);
            this.txb_adresse.Multiline = true;
            this.txb_adresse.Name = "txb_adresse";
            this.txb_adresse.Size = new System.Drawing.Size(196, 44);
            this.txb_adresse.TabIndex = 2;
            // 
            // txb_cin
            // 
            this.txb_cin.Location = new System.Drawing.Point(92, 238);
            this.txb_cin.Name = "txb_cin";
            this.txb_cin.Size = new System.Drawing.Size(196, 21);
            this.txb_cin.TabIndex = 2;
            // 
            // txb_juridique
            // 
            this.txb_juridique.Location = new System.Drawing.Point(92, 199);
            this.txb_juridique.Name = "txb_juridique";
            this.txb_juridique.Size = new System.Drawing.Size(196, 21);
            this.txb_juridique.TabIndex = 2;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(92, 160);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(196, 21);
            this.txb_name.TabIndex = 2;
            // 
            // txb_num_societe
            // 
            this.txb_num_societe.Location = new System.Drawing.Point(92, 121);
            this.txb_num_societe.Name = "txb_num_societe";
            this.txb_num_societe.Size = new System.Drawing.Size(196, 21);
            this.txb_num_societe.TabIndex = 2;
            // 
            // TxB_ident
            // 
            this.TxB_ident.Location = new System.Drawing.Point(92, 82);
            this.TxB_ident.Name = "TxB_ident";
            this.TxB_ident.Size = new System.Drawing.Size(196, 21);
            this.TxB_ident.TabIndex = 2;
            // 
            // CB_genre_Adv
            // 
            this.CB_genre_Adv.FormattingEnabled = true;
            this.CB_genre_Adv.Items.AddRange(new object[] {
            "طبيعي",
            "معنوي"});
            this.CB_genre_Adv.Location = new System.Drawing.Point(92, 48);
            this.CB_genre_Adv.Name = "CB_genre_Adv";
            this.CB_genre_Adv.Size = new System.Drawing.Size(196, 21);
            this.CB_genre_Adv.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "رقم البطاقة الوطنية :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "المرجع :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "السجل التجاري :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "الممثل القانوني :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "العنوان :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "الاسم :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نوع الخصم :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "البحث بالاسم :";
            // 
            // ادارة_خصوم_الامر
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 480);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ادارة_خصوم_الامر";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة خصوم الامر";
            this.Load += new System.EventHandler(this.ادارة_خصوم_الامر_Load);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_remove;
        private System.Windows.Forms.TextBox txb_searsh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_nouveau;
        private DevExpress.XtraEditors.SimpleButton btn_ajouter;
        private System.Windows.Forms.TextBox txb_adresse;
        private System.Windows.Forms.TextBox txb_cin;
        private System.Windows.Forms.TextBox txb_juridique;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_num_societe;
        private System.Windows.Forms.TextBox TxB_ident;
        private System.Windows.Forms.ComboBox CB_genre_Adv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_adv_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_adv_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn cin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn representant_legal;
        private System.Windows.Forms.DataGridViewTextBoxColumn registre_commerce;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.Label label9;
    }
}