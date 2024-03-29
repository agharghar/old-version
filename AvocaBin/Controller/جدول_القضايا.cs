﻿using System;
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
using AvocaBin.Models;
using AvocaBin.Models.cause;
using AvocaBin.Controller;

namespace AvocaBin
{
    public partial class جدول_القضايا : DevExpress.XtraEditors.XtraForm
    {
        Cause_Operations co = new Cause_Operations();
        SqlConnection cn = connection.getConnection();
        DataSet ds;
        SqlCommand cmd;
        SqlDataAdapter dr;
        SqlDataReader reader;
        //DataTable dt = new DataTable("cause");
        
      
        public جدول_القضايا()
        {
            InitializeComponent();
        }
        private DataSet GetData()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
                
            cmd = new SqlCommand("select c.id_cause as[مرجعنا],cl.nom as[الموكل],cl.cin as[مرجع الموكل],ad.nom_adv as[الخصم],c.appel as[الاستدعاء],c.type_cause as[نوع القضية],c.num_cause_tribunal as[رقم القضية],c.date_session as[تاريخ الجلسة],c.ville as[المدينة],c.tribunal as[المحكمة],c.total_paiement as[الاتعاب],s.decision as[الاجراء] from cause c,client_cause cl,adversaire_cause ad,sessione s  where c.id_client=cl.id_client_cause and c.id_adv=ad.id_adversaire_cause and c.id_cause=s.id_cause order by s.date_session ASC", cn);
            dr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dr.Fill(ds, "causes");
            cn.Close();
            return ds;
        }

        void fm_Refresh()
        {
            
            //SqlCommand cmd = new SqlCommand("insert into tribunal values(@a)", cn);
            //cmd.Parameters.AddWithValue("@a", a);
            //cmd.ExecuteNonQuery();
            dataGridView1.DataSource = GetData().Tables["causes"];
            //comboBoxTypeTribunal.DisplayMember = "type_tribunal";
            cn.Close();
        }

      
        public void testdata()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                simpleButton1.Enabled = false;
                simpleButton2.Enabled = false;
                btn_imprimerAll.Enabled = false;
                btn_imprimer.Enabled = false;
            }
            else
            {
                simpleButton1.Enabled = true;
                simpleButton2.Enabled = true;
                btn_imprimerAll.Enabled = true;
                btn_imprimer.Enabled = true;
                
            }
        }

        private void جدول_القضايا_Load(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
                
            cmd = new SqlCommand("select c.id_cause as[مرجعنا],cl.nom as[الموكل],cl.cin as[مرجع الموكل],ad.nom_adv as[الخصم],c.appel as[الاستدعاء],c.type_cause as[نوع القضية],c.num_cause_tribunal as[رقم القضية],c.date_session as[تاريخ الجلسة],c.ville as[المدينة],c.tribunal as[المحكمة],c.total_paiement as[الاتعاب],s.decision as[الاجراء] from cause c,client_cause cl,adversaire_cause ad,sessione s  where  c.id_client=cl.id_client_cause and c.id_adv=ad.id_adversaire_cause and c.id_cause=s.id_cause order by s.date_session ASC", cn);
            dr = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dr.Fill(ds, "causes");
            dataGridView1.DataSource = ds.Tables["causes"];
            cn.Close();
            testdata();
           // rbtn_marji3.Checked = true;
            

        }

        

        private void btn_searsh_Click(object sender, EventArgs e)
        {
            if (txt_search.Text!="")
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                
                cmd = new SqlCommand("select c.id_cause as[مرجعنا],cl.nom as[الموكل],cl.cin as[مرجع الموكل],ad.nom_adv as[الخصم],c.appel as[الاستدعاء],c.type_cause as[نوع القضية],c.num_cause_tribunal as[رقم القضية],c.date_session as[تاريخ الجلسة],c.ville as[المدينة],c.tribunal as[المحكمة],c.total_paiement as[الاتعاب],s.decision as[الاجراء] from cause c,client_cause cl,adversaire_cause ad,sessione s where( c.id_cause like '%" + txt_search.Text + "%'  and c.id_client=cl.id_client_cause and c.id_adv=ad.id_adversaire_cause and c.id_cause=s.id_cause) or ( c.num_cause_tribunal like '%" + txt_search.Text + "%'  and c.id_client=cl.id_client_cause and c.id_adv=ad.id_adversaire_cause and c.id_cause=s.id_cause) or ( cl.nom like '%" + txt_search.Text + "%' and  c.id_client=cl.id_client_cause and c.id_adv=ad.id_adversaire_cause and c.id_cause=s.id_cause) or ( cl.cin like '%" + txt_search.Text + "%'  and c.id_client=cl.id_client_cause and c.id_adv=ad.id_adversaire_cause and c.id_cause=s.id_cause) order by c.date_session ASC", cn);
                dr = new SqlDataAdapter(cmd);
                ds = new DataSet();
                dr.Fill(ds, "causes");
                dataGridView1.DataSource = ds.Tables["causes"];
                testdata();
                history.AddHistory("القضية", "البحث", txt_search.Text);
                cn.Close();

            }
           

            
        }

        private void cb_identi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
                
            if (dataGridView1.SelectedRows.Count>0)
            {
                //ادارة_الموكلين a = new ادارة_الموكلين(this);
                الموضوع frm = new الموضوع();
                frm.edit_button.Visible = true;
                frm.simpleButtonAjouterCause.Visible = false;
                frm.simpleButtonNouveauCause.Visible = false;
                frm.txtMarjiaCause1.Enabled = false;
                cmd = new SqlCommand("select * from cause c,client_cause cl,adversaire_cause ad where c.id_cause='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "' and c.id_client=cl.id_client_cause and c.id_adv=ad.id_adversaire_cause", cn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    frm.txtMarjiaCause1.Text = reader["id_cause"].ToString().Trim();
                    frm.dateTimePickeDateCause.Text = reader["date_creation"].ToString();
                    frm.txt_juge.Text = reader["juge"].ToString().Trim();
                    frm.txt_signe_cause.Text = reader["signe_cause"].ToString().Trim();
                    frm.txt_type_cause.Text = reader["type_cause"].ToString().Trim();
                    frm.txtNumCause.Text = reader["num_cause_tribunal"].ToString().Trim();
                    frm.txt_avocat_adversaire.Text = reader["avocat_adv"].ToString().Trim();
                    frm.txt_commisaire_judiciaire.Text = reader["commisaire_judiciaire"].ToString().Trim();
                    frm.textBoxCauseProfMoukalaf.Text = reader["nom_avocat"].ToString().Trim(); ;
                   // frm.cb_appel.Text = reader["appel"].ToString().Trim();
                    frm.cb_appel.Text = reader["appel"].ToString().Trim();
                    frm.comboBoxTypeTribunal.Text = reader["tribunal"].ToString().Trim();
                    frm.comboBoxVilleCause.Text = reader["ville"].ToString().Trim();
                   // MessageBox.Show((string)reader["tribunal"]);
                    frm.cb_porsuit.Text = reader["poursuite"].ToString().Trim();
                    frm.textBoxTypeClient.Text= reader["type_client"].ToString().Trim();
                    frm.textBoxNomClient.Text = reader["nom"].ToString().Trim();
                    frm.textBoxTelClient.Text = (string)reader["telephone"].ToString().Trim();
                    frm.textBoxAdresseClient.Text = (string)reader["adresse"].ToString().Trim();
                    frm.textBoxCINClient.Text = (string)reader["cin"].ToString().Trim();
                    frm.textBoxMoumatilQanouniClient.Text = (string)reader["representant_legal"].ToString().Trim();
                    frm.textBoxSijilTijariClient.Text = (string)reader["registre_commerce"].ToString().Trim();
                    frm.textBoxTypeAdver.Text = (string)reader["type_adv"].ToString().Trim();
                    frm.textBoxNomAdv.Text = (string)reader["nom_adv"].ToString().Trim();
                    frm.textBoxSijilTijariAdv.Text = (string)reader["registre_commerce_adv"].ToString().Trim();
                    frm.textBoxAdresseAdv.Text = (string)reader["adresse_adv"].ToString().Trim();
                    frm.textBoxCINAdv.Text = (string)reader["cin_adv"].ToString().Trim();
                    frm.textBoxMoumatilQanouniAdv.Text = (string)reader["representant_legal_adv"].ToString().Trim();
                    frm.txt_montant.Text = reader["total_paiement"].ToString().Trim();
                    frm.txt_duree.Text = reader["duree"].ToString().Trim();
                }
                //(this.Owner as الموضوع).edit_button.Visible = true;
                frm.abc += new الموضوع.DoEvent(fm_Refresh);
                frm.Show();
                this.Close();
               
                //frm.ShowDialog();

            }
            else
            {
                //MessageBox.Show("you should shoose a rows");
            }    
            
            cn.Close();
        }

        

        private void txt_identi_TextChanged(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
                
            if (txt_search.Text == "")
            {
                cmd = new SqlCommand("select c.id_cause as[مرجعنا],cl.nom as[الموكل],cl.cin as[مرجع الموكل],ad.nom_adv as[الخصم],c.appel as[الاستدعاء],c.type_cause as[نوع القضية],c.num_cause_tribunal as[رقم القضية],c.date_session as[تاريخ الجلسة],c.ville as[المدينة],c.tribunal as[المحكمة],c.total_paiement as[الاتعاب],s.decision as[الاجراء] from cause c,client_cause cl,adversaire_cause ad,sessione s  where  c.id_client=cl.id_client_cause and c.id_adv=ad.id_adversaire_cause  and c.id_cause=s.id_cause order by s.date_session ASC", cn);
                dr = new SqlDataAdapter(cmd);
                ds = new DataSet();
                dr.Fill(ds, "causes");
                dataGridView1.DataSource = ds.Tables["causes"];
                testdata();
            }

            cn.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //cause c = new cause();
           MessageBoxManager.Yes = "نعم";
            MessageBoxManager.No = "لا";
            MessageBoxManager.Register();
            DialogResult dr = MessageBox.Show("هل أنت متأكد من الحذف ؟؟", "تنبيه", MessageBoxButtons.YesNo);
            MessageBoxManager.Unregister();
            if (dr == DialogResult.Yes)
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                co.deleteCause(id);
                history.AddHistory("القضية", "حدف", id);
                dataGridView1.DataSource = GetData().Tables["causes"];
                testdata();
                cn.Close();
            }
            else
            {
                    
            }
        }

        private void btn_imprimer_Click(object sender, EventArgs e)
        {

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Imprimer_cause frm = new Imprimer_cause(id);
            frm.Show();
            
        }
        DataSet1 das;
        private void simpleButtonAjouter_Click(object sender, EventArgs e)
        {
             
          
            string id = txt_search.Text;
            ImprimerAllCauses frm = new ImprimerAllCauses(id);
            frm.Show();
            //MessageBox.Show(das.causes.Rows[0][0].ToString());

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