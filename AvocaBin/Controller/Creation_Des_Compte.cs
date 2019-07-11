using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AvocaBin.Controller;
using AvocaBin.Models;
using AvocaBin.Models.TextJuridique;

namespace AvocaBin
{
    public partial class Creation_Des_Compte : DevExpress.XtraEditors.XtraForm
    {
        public Creation_Des_Compte()
        {
            InitializeComponent();
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

        private void BtnCompteSortie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCompteCreation_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCIN.Text == "" || txtNOM.Text == "" || txtPRE.Text == "" || txtMOTPASS.Text == "" || cmbFonction.SelectedIndex == -1)
                {
                    MessageBox.Show("المرجو ملئ جميع الحقول");
                }
                else
                {
                    //if (d.AfficherUneSeulValeur("select count(Cin) from utilisateur where cin='" + txtCIN.Text + "'") == "1")
                    //{
                    //    MessageBox.Show("المرجو تغيير رقم البطاقة الوطنية");
                    //}
                    //else
                    //{

                    //    if (DialogResult.Yes == MessageBox.Show("هل أنت متأكد من إنشاء حساب جديد ؟؟", "تنبيه", MessageBoxButtons.YesNo))
                    //    {
                    //        d.MiseAjour("INSERT INTO [dbo].[Utilisateur] VALUES ('"+txtCIN.Text+"','"+txtNOM.Text+"','"+txtPRE.Text+"','"+txtMOTPASS.Text+"','"+DateTime.Now+"','"+cmbFonction.Text+"')");
                    //        MessageBox.Show("العملية تمت بنجاح");
                    //        history.AddHistory("انشاء حساب", "الحدف", txtNOM.Text);
                    //    }
                    //}
                }               
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }           
        }

        private void Creation_Des_Compte_Load(object sender, EventArgs e)
        {
            try
            {
                //d.ChargerCombobox("select Fonction from fonction", "fonction", cmbFonction, "Fonction", "Fonction");

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbFonction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}