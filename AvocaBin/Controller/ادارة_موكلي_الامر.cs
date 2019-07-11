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
    public partial class ادارة_موكلي_الامر : DevExpress.XtraEditors.XtraForm
    {
        public ادارة_موكلي_الامر()
        {
            InitializeComponent();
        }

        //refresh datagridview data
        private void refresh()
        {
            SqlConnection cn = connection.getConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            DataTable dt =new DataTable();
            if (cn.State == ConnectionState.Closed) { cn.Open(); }
            cmd.Connection = cn;
            cmd.CommandText = "select * from client_order";
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
            cn.Close();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            client_order cl = new client_order();
            if (txb_name.Text != "" && txb_genre_client.Text!="")
            {

                cl.type_client_order = (string)txb_genre_client.SelectedItem;
                cl.registre_commerce = txb_num_societe.Text;
                cl.nom = txb_name.Text;
                cl.representant_legal = txb_juridique.Text;
                cl.cin = txb_cin.Text;
                cl.adresse = txb_adresse.Text;
                cl.telephone = txb_tele.Text;
                int id = cl.save();
                history.AddHistory("موكلي الأمر", "إضافة", id.ToString());
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
            txb_genre_client.Text = "";
            txb_adresse.Text = "";
            txb_cin.Text = "";
            txb_juridique.Text = "";
            txb_name.Text = "";
            txb_num_societe.Text = "";
            txb_tele.Text = "";
            txb_ident_client.Text = "";
            txb_ident_client.ReadOnly = true;
            btn_ajouter.Enabled = true;
        }

        private void ادارة_موكلي_الامر_Load(object sender, EventArgs e)
        {
            refresh();
            txb_ident_client.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                txb_ident_client.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txb_num_societe.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txb_name.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txb_juridique.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txb_cin.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txb_adresse.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txb_tele.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txb_genre_client.SelectedItem = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txb_ident_client.ReadOnly = true;
            }
            else
            {
                    
            }
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
                if (dr == DialogResult.Yes && dataGridView1.Rows.Count > 0)
                {
                    client_order c = client_order.findById((int)dataGridView1.CurrentRow.Cells[0].Value);
                    c.delete();
                    history.AddHistory("موكلي الأمر", "حدف", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("تم الحذف بنجاح");
                    refresh();
                }
                else { }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            client_order cl = new client_order();
            if (dataGridView1.Rows.Count > 0 && txb_ident_client.Text !="")
            {
                cl.id_client_order = int.Parse(txb_ident_client.Text);
                cl.type_client_order = (string)txb_genre_client.SelectedItem;
                cl.registre_commerce = txb_num_societe.Text;
                cl.nom = txb_name.Text;
                cl.representant_legal = txb_juridique.Text;
                cl.cin = txb_cin.Text;
                cl.adresse = txb_adresse.Text;
                cl.telephone = txb_tele.Text;
                cl.update();
                history.AddHistory("موكلي الأمر", "تحديث", cl.id_client_order.ToString());
                MessageBox.Show("تم تحديث الملومات");
                refresh();
            }
            else
            {
                MessageBox.Show("المرجو تحديد الحقل المراد تعديله");
            }
           
        }

        private void btn_imprimer_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string word = textBox8.Text;
            List<client_order> list = new List<client_order>();
            list = client_order.find(word);
            dataGridView1.DataSource = list;
        }

        private void txb_genre_client_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("ssss");
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

        private void txb_genre_client_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}