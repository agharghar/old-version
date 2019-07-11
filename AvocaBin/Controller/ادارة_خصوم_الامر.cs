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
using System.Data;
using System.Data.SqlClient;
using AvocaBin.Models;

namespace AvocaBin
{
    public partial class ادارة_خصوم_الامر : DevExpress.XtraEditors.XtraForm
    {
        public ادارة_خصوم_الامر()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            SqlConnection cn = connection.getConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new System.Data.DataTable();
            if (cn.State == ConnectionState.Closed) { cn.Open(); }
            cmd.Connection = cn;
            cmd.CommandText = "select * from adv_order";
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cn.Close();
            dr.Close();
        }

        private void ادارة_خصوم_الامر_Load(object sender, EventArgs e)
        {
            refresh();
            TxB_ident.ReadOnly = true;
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            adv_order adv = new adv_order();
            if (CB_genre_Adv.Text != "" && txb_name.Text != "")
            {
                adv.type_adv_order = CB_genre_Adv.Text;
                adv.cin = txb_cin.Text;
                adv.nom = txb_name.Text;
                adv.representant_legal = txb_juridique.Text;
                adv.registre_commerce = txb_num_societe.Text;
                adv.adresse = txb_adresse.Text;
                int id = adv.save();
                history.AddHistory("خصوم الأمر", "إضافة", id.ToString());
                MessageBox.Show("تمت الإضافة بنجاح");
                refresh();
                btn_ajouter.Enabled = false;
            }
            else
            {
                MessageBox.Show("يجب ادخال البيانات");
            }
        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            CB_genre_Adv.Text = "";
            TxB_ident.Text = "";
            txb_adresse.Text = "";
            txb_cin.Text = "";
            txb_juridique.Text = "";
            txb_name.Text = "";
            txb_num_societe.Text = "";
            btn_ajouter.Enabled = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("الجدول غير ممتلئ");
            }
            else
            {

                MessageBoxManager.Yes = "نعم";
                MessageBoxManager.No = "لا";
                MessageBoxManager.Register();
                DialogResult dr = MessageBox.Show("هل أنت متأكد من الحدف ؟؟", "تنبيه", MessageBoxButtons.YesNo);
                MessageBoxManager.Unregister();
                if (dr == DialogResult.Yes)
                {
                    adv_order ad = adv_order.findById((int)dataGridView1.CurrentRow.Cells[0].Value);
                    ad.delete();
                    history.AddHistory("خصوم الأمر", "حذف", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("تم الحذف بنجاح");
                    refresh();
                }
                else { }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            adv_order cl = new adv_order();
            if (dataGridView1.Rows.Count > 0 && TxB_ident.Text != "")
            {
                cl.id_adv_order = int.Parse(TxB_ident.Text);
                cl.type_adv_order = CB_genre_Adv.Text;
                cl.registre_commerce = txb_num_societe.Text;
                cl.nom = txb_name.Text;
                cl.representant_legal = txb_juridique.Text;
                cl.cin = txb_cin.Text;
                cl.adresse = txb_adresse.Text;
                cl.update();
                history.AddHistory("خصوم الأمر", "تحديث", cl.id_adv_order.ToString());
                MessageBox.Show("تم تحديث الملومات");
                refresh();
            }
            else
            {
                MessageBox.Show("المرجو تحديد الحقل المراد تعديله");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxB_ident.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CB_genre_Adv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txb_cin.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txb_name.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txb_juridique.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txb_num_societe.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txb_adresse.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            TxB_ident.ReadOnly = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string word = txb_searsh.Text;
            List<adv_order> li = new List<adv_order>();
            li = adv_order.find(word);
            dataGridView1.DataSource = li;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application oExcel_12 = null;
            Microsoft.Office.Interop.Excel.Workbook oBook = null;
            Microsoft.Office.Interop.Excel.Sheets oSheetsColl = null;
            Microsoft.Office.Interop.Excel.Worksheet oSheet = null;
            Microsoft.Office.Interop.Excel.Range oRange = null;
            Object oMissing = System.Reflection.Missing.Value;
            oExcel_12 = new Microsoft.Office.Interop.Excel.Application();
            oExcel_12.Visible = true;
            oExcel_12.UserControl = true;
            oBook = oExcel_12.Workbooks.Add(oMissing);
            oSheetsColl = oExcel_12.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheetsColl.get_Item(1);
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                oRange = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[1, j + 1];
                oRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    oRange = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[i + 2, j + 1];
                    oRange.Value2 = dataGridView1[j, i].Value;
                }
            }
            oBook = null;
            oExcel_12 = null;
            GC.Collect();
        }
    }
}