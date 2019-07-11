namespace AvocaBin
{
    partial class ادارة_الموكلين
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ادارة_الموكلين));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_imprimer_all = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_imprimer = new DevExpress.XtraEditors.SimpleButton();
            this.btn_remove = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.representant_legal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registre_commerce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_genre_client = new System.Windows.Forms.ComboBox();
            this.txb_num_societe = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_juridique = new System.Windows.Forms.TextBox();
            this.txb_cin = new System.Windows.Forms.TextBox();
            this.txb_adresse = new System.Windows.Forms.TextBox();
            this.txb_tele = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_nouveau = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ajouter = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.btn_imprimer_all);
            this.groupControl2.Controls.Add(this.textBox1);
            this.groupControl2.Controls.Add(this.btn_imprimer);
            this.groupControl2.Controls.Add(this.btn_remove);
            this.groupControl2.Controls.Add(this.btn_edit);
            this.groupControl2.Controls.Add(this.button1);
            this.groupControl2.Controls.Add(this.dataGridView1);
            this.groupControl2.Location = new System.Drawing.Point(32, 252);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(1102, 417);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "جدول الموكلين";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(486, 371);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(199, 38);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "ارسال الموكلين الى الاكسل";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_imprimer_all
            // 
            this.btn_imprimer_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_imprimer_all.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_imprimer_all.Appearance.Options.UseFont = true;
            this.btn_imprimer_all.ImageUri.Uri = "Print;Colored";
            this.btn_imprimer_all.Location = new System.Drawing.Point(691, 371);
            this.btn_imprimer_all.Name = "btn_imprimer_all";
            this.btn_imprimer_all.Size = new System.Drawing.Size(105, 38);
            this.btn_imprimer_all.TabIndex = 12;
            this.btn_imprimer_all.Text = "طباعة الكل";
            this.btn_imprimer_all.Click += new System.EventHandler(this.btn_imprimer_all_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(708, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 21);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_imprimer.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_imprimer.Appearance.Options.UseFont = true;
            this.btn_imprimer.ImageUri.Uri = "Print;Colored";
            this.btn_imprimer.Location = new System.Drawing.Point(802, 371);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(82, 38);
            this.btn_imprimer.TabIndex = 10;
            this.btn_imprimer.Text = "طباعة";
            this.btn_imprimer.Click += new System.EventHandler(this.btn_imprimer_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remove.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_remove.Appearance.Options.UseFont = true;
            this.btn_remove.ImageUri.Uri = "Delete;Colored";
            this.btn_remove.Location = new System.Drawing.Point(890, 371);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(82, 38);
            this.btn_remove.TabIndex = 9;
            this.btn_remove.Text = "حدف";
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.ImageUri.Uri = "Edit;Colored";
            this.btn_edit.Location = new System.Drawing.Point(978, 371);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(82, 38);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(610, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nom,
            this.type_client,
            this.cin,
            this.representant_legal,
            this.registre_commerce,
            this.telephone,
            this.adresse});
            this.dataGridView1.Location = new System.Drawing.Point(22, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "مرجعنا";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.HeaderText = "الاسم";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // type_client
            // 
            this.type_client.HeaderText = "نوع الموكل";
            this.type_client.Name = "type_client";
            this.type_client.ReadOnly = true;
            // 
            // cin
            // 
            this.cin.HeaderText = "ر.ب.و او مرجع الموكل";
            this.cin.Name = "cin";
            this.cin.ReadOnly = true;
            // 
            // representant_legal
            // 
            this.representant_legal.HeaderText = "الممثل القانوني";
            this.representant_legal.Name = "representant_legal";
            this.representant_legal.ReadOnly = true;
            // 
            // registre_commerce
            // 
            this.registre_commerce.HeaderText = "السجل التجاري";
            this.registre_commerce.Name = "registre_commerce";
            this.registre_commerce.ReadOnly = true;
            // 
            // telephone
            // 
            this.telephone.HeaderText = "الهاتف";
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            // 
            // adresse
            // 
            this.adresse.HeaderText = "العنوان";
            this.adresse.Name = "adresse";
            this.adresse.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1000, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نوع الموكل :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1024, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "الاسم :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1021, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "العنوان :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(287, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "الممثل القانوني :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(628, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "السجل التجاري :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(335, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "الهاتف :";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(628, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "رقم البطاقة الوطنية :";
            // 
            // txb_genre_client
            // 
            this.txb_genre_client.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_genre_client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txb_genre_client.FormattingEnabled = true;
            this.txb_genre_client.Items.AddRange(new object[] {
            "طبيعي",
            "معنوي"});
            this.txb_genre_client.Location = new System.Drawing.Point(771, 42);
            this.txb_genre_client.Name = "txb_genre_client";
            this.txb_genre_client.Size = new System.Drawing.Size(214, 21);
            this.txb_genre_client.TabIndex = 1;
            this.txb_genre_client.SelectedIndexChanged += new System.EventHandler(this.txb_genre_client_SelectedIndexChanged);
            // 
            // txb_num_societe
            // 
            this.txb_num_societe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_num_societe.Enabled = false;
            this.txb_num_societe.Location = new System.Drawing.Point(404, 42);
            this.txb_num_societe.Name = "txb_num_societe";
            this.txb_num_societe.Size = new System.Drawing.Size(196, 21);
            this.txb_num_societe.TabIndex = 2;
            // 
            // txb_name
            // 
            this.txb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_name.Enabled = false;
            this.txb_name.Location = new System.Drawing.Point(771, 89);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(214, 21);
            this.txb_name.TabIndex = 2;
            // 
            // txb_juridique
            // 
            this.txb_juridique.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_juridique.Enabled = false;
            this.txb_juridique.Location = new System.Drawing.Point(38, 42);
            this.txb_juridique.Name = "txb_juridique";
            this.txb_juridique.Size = new System.Drawing.Size(245, 21);
            this.txb_juridique.TabIndex = 2;
            // 
            // txb_cin
            // 
            this.txb_cin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_cin.Enabled = false;
            this.txb_cin.Location = new System.Drawing.Point(404, 89);
            this.txb_cin.Name = "txb_cin";
            this.txb_cin.Size = new System.Drawing.Size(196, 21);
            this.txb_cin.TabIndex = 2;
            // 
            // txb_adresse
            // 
            this.txb_adresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_adresse.Enabled = false;
            this.txb_adresse.Location = new System.Drawing.Point(404, 135);
            this.txb_adresse.Multiline = true;
            this.txb_adresse.Name = "txb_adresse";
            this.txb_adresse.Size = new System.Drawing.Size(581, 65);
            this.txb_adresse.TabIndex = 2;
            // 
            // txb_tele
            // 
            this.txb_tele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_tele.Enabled = false;
            this.txb_tele.Location = new System.Drawing.Point(38, 89);
            this.txb_tele.Name = "txb_tele";
            this.txb_tele.Size = new System.Drawing.Size(245, 21);
            this.txb_tele.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btn_nouveau);
            this.groupControl1.Controls.Add(this.btn_ajouter);
            this.groupControl1.Controls.Add(this.txb_tele);
            this.groupControl1.Controls.Add(this.txb_adresse);
            this.groupControl1.Controls.Add(this.txb_cin);
            this.groupControl1.Controls.Add(this.txb_juridique);
            this.groupControl1.Controls.Add(this.txb_name);
            this.groupControl1.Controls.Add(this.txb_num_societe);
            this.groupControl1.Controls.Add(this.txb_genre_client);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(32, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(1102, 217);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "اضافة الموكل";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nouveau.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_nouveau.Appearance.Options.UseFont = true;
            this.btn_nouveau.ImageUri.Uri = "Clear;Office2013";
            this.btn_nouveau.Location = new System.Drawing.Point(42, 149);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(127, 38);
            this.btn_nouveau.TabIndex = 5;
            this.btn_nouveau.Text = "جديد";
            this.btn_nouveau.Click += new System.EventHandler(this.btn_nouveau_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajouter.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_ajouter.Appearance.Options.UseFont = true;
            this.btn_ajouter.ImageUri.Uri = "Add;Office2013";
            this.btn_ajouter.Location = new System.Drawing.Point(175, 149);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(108, 38);
            this.btn_ajouter.TabIndex = 4;
            this.btn_ajouter.Text = "اضافة";
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(628, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "مرجع الموكل :";
            this.label4.Visible = false;
            // 
            // ادارة_الموكلين
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 681);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ادارة_الموكلين";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة الموكلين";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ادارة_الموكلين_FormClosed);
            this.Load += new System.EventHandler(this.ادارة_الموكلين_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txb_genre_client;
        private System.Windows.Forms.TextBox txb_num_societe;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_juridique;
        private System.Windows.Forms.TextBox txb_cin;
        private System.Windows.Forms.TextBox txb_adresse;
        private System.Windows.Forms.TextBox txb_tele;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_ajouter;
        private DevExpress.XtraEditors.SimpleButton btn_nouveau;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_remove;
        private DevExpress.XtraEditors.SimpleButton btn_imprimer;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btn_imprimer_all;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn cin;
        private System.Windows.Forms.DataGridViewTextBoxColumn representant_legal;
        private System.Windows.Forms.DataGridViewTextBoxColumn registre_commerce;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
    }
}