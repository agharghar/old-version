using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AvocaBin.Controller
{
    public partial class MassarifListe : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnx = connection.getConnection();
        SqlDataReader dr;


        public MassarifListe()
        {
            
            InitializeComponent();
            
        }

        private void MassarifListe_Load(object sender, EventArgs e)
        {
            try
            {
                if (cnx.State == ConnectionState.Closed) { cnx.Open(); }
                dataGridViewRecherche.Rows.Clear();
                cmd.CommandText = "SELECT DISTINCT p.id_paiement,c.id_cause,avance,date_paiement,total_paiement FROM  dbo.Paiement p , dbo.cause c where p.id_cause=c.id_cause";
                cmd.Connection = cnx;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridViewRecherche.Rows.Add(dr["id_paiement"].ToString(), dr["id_cause"].ToString(), dr["date_paiement"].ToString(), dr["total_paiement"].ToString(), dr["avance"].ToString());
                }
                dr.Close();
                dr.Dispose();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtRecherche.Text!="")
                {
                    dataGridViewRecherche.Rows.Clear();
                    if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                    cmd.CommandText = "select p.id_paiement,c.id_cause,avance,date_paiement,total_paiement from dbo.Paiement p , dbo.cause c where c.id_cause = '" + txtRecherche.Text + "'";
                    cmd.Connection = cnx;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        dataGridViewRecherche.Rows.Add(dr["id_paiement"].ToString(), dr["id_cause"].ToString(), dr["date_paiement"].ToString(), dr["total_paiement"].ToString(), dr["avance"].ToString());
                    }
                    dr.Close();
                    cnx.Close();
                }
                if (txtRecherche.Text == "")
                {
                    dataGridViewRecherche.Rows.Clear();
                    if (cnx.State == ConnectionState.Closed)
                    {
                        cnx.Open();
                    }
                    cmd.CommandText = "SELECT DISTINCT p.id_paiement,c.id_cause,avance,date_paiement,total_paiement FROM  dbo.Paiement p , dbo.cause c where p.id_cause=c.id_cause";
                    cmd.Connection = cnx;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        dataGridViewRecherche.Rows.Add(dr["id_paiement"].ToString(), dr["id_cause"].ToString(), dr["date_paiement"].ToString(), dr["total_paiement"].ToString(), dr["avance"].ToString());
                    }
                    dr.Close();
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void معلوماتعناToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProposNous p = new ProposNous();
            p.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dataGridViewRecherche.Rows.Count != 0)
            {
                PrintMassarifForm f = new PrintMassarifForm();
                f.idPaiement = (string)dataGridViewRecherche.CurrentRow.Cells[0].Value;
                f.Show();
            }
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
            for (int j = 0; j < dataGridViewRecherche.Columns.Count; j++)
            {
                oRange = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[1, j + 1];
                oRange.Value2 = dataGridViewRecherche.Columns[j].HeaderText;
            }

            for (int i = 0; i < dataGridViewRecherche.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridViewRecherche.Columns.Count; j++)
                {
                    oRange = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[i + 2, j + 1];
                    oRange.Value2 = dataGridViewRecherche[j, i].Value;
                }
            }

            oBook = null;
            oExcel_12 = null;
            GC.Collect();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewRecherche.SelectedRows.Count !=0 )
                {
                    cmd.Parameters.Clear();
                    if (cnx.State == ConnectionState.Closed) { cnx.Open(); }
                    cmd.Connection = cnx;
                    cmd.CommandText = "delete Paiement where id_paiement like '"+(string)dataGridViewRecherche.SelectedRows[0].Cells[0].Value+"'";
                    cmd.ExecuteNonQuery();

                    dataGridViewRecherche.Rows.Clear();
                    cmd.CommandText = "SELECT DISTINCT p.id_paiement,c.id_cause,avance,date_paiement,total_paiement FROM  dbo.Paiement p , dbo.cause c where p.id_cause=c.id_cause";
                    cmd.Connection = cnx;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        dataGridViewRecherche.Rows.Add(dr["id_paiement"].ToString(), dr["id_cause"].ToString(), dr["date_paiement"].ToString(), dr["total_paiement"].ToString(), dr["avance"].ToString());
                    }
                    dr.Close();
                    dr.Dispose();
                    cnx.Close();
                    cnx.Close();
                    MessageBox.Show("تم الحدف بنجاح");
                }
                else
                {
                    MessageBox.Show("الرجاء إعادة المحاولة");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
