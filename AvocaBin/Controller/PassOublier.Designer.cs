namespace AvocaBin.Controller
{
    partial class PassOublier
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
            this.txtbxREP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComBxQuest = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxMOTPASS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbxREP
            // 
            this.txtbxREP.Location = new System.Drawing.Point(138, 94);
            this.txtbxREP.Multiline = true;
            this.txtbxREP.Name = "txtbxREP";
            this.txtbxREP.Size = new System.Drawing.Size(193, 66);
            this.txtbxREP.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 97);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "الاجابة :";
            // 
            // ComBxQuest
            // 
            this.ComBxQuest.FormattingEnabled = true;
            this.ComBxQuest.Location = new System.Drawing.Point(138, 48);
            this.ComBxQuest.Name = "ComBxQuest";
            this.ComBxQuest.Size = new System.Drawing.Size(193, 21);
            this.ComBxQuest.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 51);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "سؤال :";
            // 
            // txtbxMOTPASS
            // 
            this.txtbxMOTPASS.Location = new System.Drawing.Point(187, 205);
            this.txtbxMOTPASS.Name = "txtbxMOTPASS";
            this.txtbxMOTPASS.Size = new System.Drawing.Size(100, 20);
            this.txtbxMOTPASS.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "الرقم السري :";
            // 
            // PassOublier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 367);
            this.Controls.Add(this.txtbxMOTPASS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComBxQuest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxREP);
            this.Controls.Add(this.label5);
            this.Name = "PassOublier";
            this.Text = "PassOublier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxREP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComBxQuest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxMOTPASS;
        private System.Windows.Forms.Label label6;
    }
}