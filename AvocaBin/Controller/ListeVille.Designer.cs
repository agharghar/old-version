namespace AvocaBin.Controller
{
    partial class ListeVille
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeVille));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.الملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LesVille = new System.Windows.Forms.ToolStripMenuItem();
            this.الحدفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الخروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.معلوماتعناToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageUri.Uri = "Close;Colored";
            this.simpleButton2.Location = new System.Drawing.Point(130, 349);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(79, 39);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "خروج";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageUri.Uri = "Refresh;Colored";
            this.simpleButton1.Location = new System.Drawing.Point(215, 349);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(79, 39);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "تحديث ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الملفToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(305, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // الملفToolStripMenuItem
            // 
            this.الملفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LesVille,
            this.الحدفToolStripMenuItem,
            this.الخروجToolStripMenuItem});
            this.الملفToolStripMenuItem.Name = "الملفToolStripMenuItem";
            this.الملفToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.الملفToolStripMenuItem.Text = "الادارة";
            // 
            // LesVille
            // 
            this.LesVille.Name = "LesVille";
            this.LesVille.Size = new System.Drawing.Size(152, 22);
            this.LesVille.Text = "الاضافة";
            this.LesVille.Click += new System.EventHandler(this.LesVille_Click);
            // 
            // الحدفToolStripMenuItem
            // 
            this.الحدفToolStripMenuItem.Name = "الحدفToolStripMenuItem";
            this.الحدفToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.الحدفToolStripMenuItem.Text = "الحدف";
            this.الحدفToolStripMenuItem.Click += new System.EventHandler(this.الحدفToolStripMenuItem_Click);
            // 
            // الخروجToolStripMenuItem
            // 
            this.الخروجToolStripMenuItem.Name = "الخروجToolStripMenuItem";
            this.الخروجToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.الخروجToolStripMenuItem.Text = "الخروج";
            this.الخروجToolStripMenuItem.Click += new System.EventHandler(this.الخروجToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.معلوماتعناToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(25, 20);
            this.toolStripMenuItem1.Text = "؟";
            // 
            // معلوماتعناToolStripMenuItem
            // 
            this.معلوماتعناToolStripMenuItem.Name = "معلوماتعناToolStripMenuItem";
            this.معلوماتعناToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.معلوماتعناToolStripMenuItem.Text = "معلومات عنا ...";
            this.معلوماتعناToolStripMenuItem.Click += new System.EventHandler(this.معلوماتعناToolStripMenuItem_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "المدينة";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(74, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(157, 271);
            this.dataGridView1.TabIndex = 5;
            // 
            // ListeVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 399);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListeVille";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المدن ";
            this.Load += new System.EventHandler(this.ListeVille_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem الملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LesVille;
        private System.Windows.Forms.ToolStripMenuItem الحدفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الخروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem معلوماتعناToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}