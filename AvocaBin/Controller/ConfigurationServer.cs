using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvocaBin.Controller;


namespace AvocaBin.Controller
{
    public partial class ConfigurationServer : Form
    {
        public ConfigurationServer()
        {
            InitializeComponent();
            txtServerName.Text = Properties.Settings.Default.Server;
            txtDBName.Text = Properties.Settings.Default.DataBase;
            if (Properties.Settings.Default.Mode=="SQL")
            {
                radioSQLAuth.Checked = true;
                txtUser.Text = Properties.Settings.Default.ID;
                txtPass.Text = Properties.Settings.Default.PassWord;
            }
            else
            {
                radioWindowsAuth.Checked = true;
                txtUser.Clear();
                txtPass.Clear();
                txtUser.ReadOnly = true;
                txtPass.ReadOnly = true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void معلوماتعناToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProposNous p = new ProposNous();
                p.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            MessageBoxManager.Yes = "نعم";
            MessageBoxManager.No = "لا";
            MessageBoxManager.Register();
            DialogResult dr = MessageBox.Show("هل أنت متأكد من التعديل .. ؟؟", "تنبيه", MessageBoxButtons.YesNo);
            MessageBoxManager.Unregister();
            if (dr == DialogResult.Yes)
            {
                Properties.Settings.Default.Server = txtServerName.Text;
                Properties.Settings.Default.DataBase = txtDBName.Text;
                Properties.Settings.Default.Mode = radioSQLAuth.Checked == true ? "SQL" : "Windows";
                Properties.Settings.Default.ID = txtUser.Text;
                Properties.Settings.Default.PassWord = txtPass.Text;
                Properties.Settings.Default.Save();
                MessageBoxManager.OK = "حسنا";
                MessageBoxManager.Register();
                DialogResult d = MessageBox.Show("لقد ثم التعديل ", "تنبيه", MessageBoxButtons.OK,MessageBoxIcon.Information);
                MessageBoxManager.Unregister();                
            }
            else
            {
                this.Close();
            }

        }

        private void radioSQLAuth_CheckedChanged(object sender, EventArgs e)
        {
            txtUser.ReadOnly = false;
            txtPass.ReadOnly = false;
        }

        private void radioWindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            txtUser.ReadOnly = true;
            txtPass.ReadOnly = true;
        }

        private void ConfigurationServer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
