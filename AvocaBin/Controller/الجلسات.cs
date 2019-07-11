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
using System.Data.SqlClient;
using AvocaBin.Operation;
using AvocaBin.Models.cause;
using AvocaBin.Models;

namespace AvocaBin
{
    public partial class الجلسات : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection cn = connection.getConnection();
        Cause_Operations co = new Cause_Operations();
        DataSet ds=new DataSet();
        SqlDataAdapter ad;
        SqlCommand cmd;

        public الجلسات()
        {
            InitializeComponent();
        }
        public void getDataTable_cause()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
                
            cmd = new SqlCommand("select id_cause from cause", cn);
            ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "b");
            cb_id_cause.DataSource = ds.Tables["b"];
            cb_id_cause.DisplayMember = "id_cause";
            
            cn.Close();
        }
       public void getdata()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
                
            cmd = new SqlCommand("select s.id_cause as[المرجع],cl.nom as[الموكل],a.nom_adv as[الخصم],s.date_session as[تاريخ الجلسة],s.decision as[الاجراء] from cause c,sessione s,client_cause cl,adversaire_cause a where s.id_cause=c.id_cause and c.id_client=cl.id_client_cause and a.id_adversaire_cause=c.id_adv order by s.date_session DESC", cn);
            ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "a");
            dataGridView1.DataSource = ds.Tables["a"];
            cn.Close();
        }
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (txt_decision.Text=="" || cb_id_cause.Text=="")
            {
                MessageBoxManager.OK = "حسنا";
                MessageBoxManager.Register();
                DialogResult dr = MessageBox.Show("المرجو ملئ جميع الحقول", "تنبيه", MessageBoxButtons.OK);
                MessageBoxManager.Unregister();

            }
            else
            {
                try
                {
                    //cn.Open();
                    Session se = new Session();
                    se.Date_session = dateTimePicker1.Value;
                    se.Decision = txt_decision.Text;
                    se.Id_cause = cb_id_cause.Text;
                    co.add_session(se);
                    getdata();
                    history.AddHistory("الجلسات", "الاضافة", cb_id_cause.Text);
                    //cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void الجلسات_Load(object sender, EventArgs e)
        {
            getdata();
            getDataTable_cause();
        }

        private void txb_searsh_TextChanged(object sender, EventArgs e)
        {
            if (txb_searsh.Text=="")
            {
                getdata();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            txt_decision.Clear();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
                
            cmd = new SqlCommand("select s.id_cause as [المرجع],cl.nom as [الموكل],a.nom_adv as [الخصم],s.date_session as [تاريخ الجلسة],s.decision as [الاجراء] from cause c,sessione s,client_cause cl,adversaire_cause a where s.id_cause like'%" + txb_searsh.Text + "%' and c.id_cause=s.id_cause and c.id_client=cl.id_client_cause and a.id_adversaire_cause=c.id_adv", cn);
            ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "k");
            dataGridView1.DataSource = ds.Tables["k"];
            cn.Close();
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            txb_searsh.Clear();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
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