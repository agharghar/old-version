namespace AvocaBin
{
    partial class جدول_الاوامر
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(جدول_الاوامر));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_searsh = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signe_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commissaire_judirique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villekk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tribunal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_client_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_adversaire_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "مرجع الموكل أو ب.ت.و :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "المرجع أو رقم الأمر";
            // 
            // btn_searsh
            // 
            this.btn_searsh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_searsh.ImageUri.Uri = "Zoom;Colored";
            this.btn_searsh.Location = new System.Drawing.Point(144, 109);
            this.btn_searsh.Name = "btn_searsh";
            this.btn_searsh.Size = new System.Drawing.Size(142, 36);
            this.btn_searsh.TabIndex = 8;
            this.btn_searsh.Text = "بحث حسب المرجع";
            this.btn_searsh.Click += new System.EventHandler(this.btn_searsh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_order,
            this.signe_order,
            this.date_order,
            this.commissaire_judirique,
            this.villekk,
            this.tribunal,
            this.id_client_order,
            this.id_adversaire_order,
            this.decision,
            this.type});
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(839, 442);
            this.dataGridView1.TabIndex = 9;
            // 
            // id_order
            // 
            this.id_order.DataPropertyName = "id_order";
            this.id_order.HeaderText = "المرجع";
            this.id_order.Name = "id_order";
            this.id_order.ReadOnly = true;
            // 
            // signe_order
            // 
            this.signe_order.DataPropertyName = "signe_order";
            this.signe_order.HeaderText = "رقم الأمر";
            this.signe_order.Name = "signe_order";
            this.signe_order.ReadOnly = true;
            // 
            // date_order
            // 
            this.date_order.DataPropertyName = "date_order";
            this.date_order.HeaderText = "التاريخ";
            this.date_order.Name = "date_order";
            this.date_order.ReadOnly = true;
            // 
            // commissaire_judirique
            // 
            this.commissaire_judirique.DataPropertyName = "commissaire_judiciaire";
            this.commissaire_judirique.HeaderText = "المفوض القضائي";
            this.commissaire_judirique.Name = "commissaire_judirique";
            this.commissaire_judirique.ReadOnly = true;
            // 
            // villekk
            // 
            this.villekk.DataPropertyName = "ville";
            this.villekk.HeaderText = "المدينة";
            this.villekk.Name = "villekk";
            this.villekk.ReadOnly = true;
            // 
            // tribunal
            // 
            this.tribunal.DataPropertyName = "tribunal";
            this.tribunal.HeaderText = "المحكمة";
            this.tribunal.Name = "tribunal";
            this.tribunal.ReadOnly = true;
            // 
            // id_client_order
            // 
            this.id_client_order.DataPropertyName = "id_client_order";
            this.id_client_order.HeaderText = "الموكل";
            this.id_client_order.Name = "id_client_order";
            this.id_client_order.ReadOnly = true;
            // 
            // id_adversaire_order
            // 
            this.id_adversaire_order.DataPropertyName = "id_adversaire_order";
            this.id_adversaire_order.HeaderText = "الخصم";
            this.id_adversaire_order.Name = "id_adversaire_order";
            this.id_adversaire_order.ReadOnly = true;
            // 
            // decision
            // 
            this.decision.DataPropertyName = "decision";
            this.decision.HeaderText = "القرار";
            this.decision.Name = "decision";
            this.decision.ReadOnly = true;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "نوع الأمر";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 21);
            this.textBox1.TabIndex = 10;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageUri.Uri = "Delete;Colored";
            this.simpleButton1.Location = new System.Drawing.Point(554, 187);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 36);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "حذف";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageUri.Uri = "Refresh";
            this.simpleButton2.Location = new System.Drawing.Point(380, 187);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(95, 36);
            this.simpleButton2.TabIndex = 12;
            this.simpleButton2.Text = "تحديث";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton4.ImageUri.Uri = "Zoom;Colored";
            this.simpleButton4.Location = new System.Drawing.Point(609, 109);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(94, 36);
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "بحث";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageUri.Uri = "Print";
            this.simpleButton5.Location = new System.Drawing.Point(224, 187);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(100, 36);
            this.simpleButton5.TabIndex = 13;
            this.simpleButton5.Text = "طباعة الكل";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageUri.Uri = "Print";
            this.simpleButton6.Location = new System.Drawing.Point(79, 187);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(87, 36);
            this.simpleButton6.TabIndex = 14;
            this.simpleButton6.Text = "طباعة";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.AutoSize = true;
            this.simpleButton7.ImageUri.Uri = "Edit";
            this.simpleButton7.Location = new System.Drawing.Point(700, 187);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(70, 38);
            this.simpleButton7.TabIndex = 15;
            this.simpleButton7.Text = "تعديل";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(637, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 21);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(350, 109);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(223, 38);
            this.simpleButton3.TabIndex = 47;
            this.simpleButton3.Text = "ارسال الى الاكسل";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click_1);
            // 
            // جدول_الاوامر
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 683);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.btn_searsh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "جدول_الاوامر";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جدول الاوامر";
            this.Load += new System.EventHandler(this.جدول_الاوامر_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_searsh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn signe_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn commissaire_judirique;
        private System.Windows.Forms.DataGridViewTextBoxColumn villekk;
        private System.Windows.Forms.DataGridViewTextBoxColumn tribunal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_adversaire_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn decision;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}