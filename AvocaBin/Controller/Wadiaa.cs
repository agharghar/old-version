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
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Design;
using AvocaBin.Controller;
using AvocaBin.Operation;
using AvocaBin.Models.cause;
using AvocaBin.Models.Plaintes;
using AvocaBin.Models;
using AvocaBin.Controller;

namespace AvocaBin.Controller
{
    public partial class Wadiaa : Form
    {
        
        SqlConnection cnx = connection.getConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        Cause_Operations co;
        PlaintesOperations po;
        order_operation oo;
        
        public Wadiaa()
        {
            InitializeComponent();
            
        }
        public void getData1()
        {
            dataGridView1.Rows.Clear();

            co = new Cause_Operations();
            List<depot_cause> depot_cause = co.getDepot_Cause();
            foreach (depot_cause cc in depot_cause)
            {
                try
                {
                    dataGridView1.Rows.Add(cc.Id_depot,cc.Id_cause, cc.Nom, cc.Nom_adv, cc.Num_check, cc.Montant);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //testdata();

        }
        public void searchDep_cause() 
        {
            dataGridView1.Rows.Clear();

            co = new Cause_Operations();
            List<depot_cause> depot_cause = co.seardepot_caause(textBox2.Text);
            foreach (depot_cause cc in depot_cause)
            {
                try
                {
                    dataGridView1.Rows.Add(cc.Id_depot, cc.Id_cause, cc.Nom, cc.Nom_adv, cc.Num_check, cc.Montant);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void getData2()
        {
            dataGridView2.Rows.Clear();

            po = new PlaintesOperations();
            List<depot_plaint> depot_plaint = po.get_depot_plainte();
            foreach (depot_plaint cc in depot_plaint)
            {
                try
                {
                    dataGridView2.Rows.Add(cc.Id_depot, cc.Id_plainte, cc.Nom, cc.Nom_adv, cc.Num_check, cc.Montant);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //testdata();

        }
        public void searchDep_plainte()
        {
            dataGridView2.Rows.Clear();

            po = new PlaintesOperations();
            List<depot_plaint> depot_plaint = po.seardepot_plainte(textBox1.Text);
            foreach (depot_plaint cc in depot_plaint)
            {
                try
                {
                    dataGridView2.Rows.Add(cc.Id_depot, cc.Id_plainte, cc.Nom, cc.Nom_adv, cc.Num_check, cc.Montant);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void getData3()
        {
            dataGridView3.Rows.Clear();

            oo = new order_operation();
            List<depot_order> depot_order = oo.detDepotOrder();
            foreach (depot_order cc in depot_order)
            {
                try
                {
                    dataGridView3.Rows.Add(cc.Id_depot, cc.Id_order, cc.Nom, cc.Nom_adv, cc.Num_check, cc.Montant);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //testdata();

        }
        public void searchdep_order()
        {
            dataGridView3.Rows.Clear();

            oo = new order_operation();
            List<depot_order> depot_order = oo.seardepot_order(textBox3.Text);
            foreach (depot_order cc in depot_order)
            {
                try
                {
                    dataGridView3.Rows.Add(cc.Id_depot, cc.Id_order, cc.Nom, cc.Nom_adv, cc.Num_check, cc.Montant);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void Wadiaa_Load(object sender, EventArgs e)
        {
            
            //w.BackColor = System.Drawing.Color.
            //combobox rempliser par l'ID du cause  : 
            try
            {
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                
                cmd.Connection = cnx;
                cmd.CommandText = "SELECT id_cause FROM cause ";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbNumMawdoua.Items.Add(dr["id_cause"].ToString());
                }
                dr.Close();
                cnx.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //combobox rempliser par l'ID d'order  : 
            try
            {
                SqlCommand cmdIDOrder = new SqlCommand();
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                
                cmdIDOrder.Connection = cnx;
                cmdIDOrder.CommandText = "SELECT o2.id_order FROM dbo.orderr o2";
                dr = cmdIDOrder.ExecuteReader();
                while (dr.Read())
                {
                    cmbNumOrder.Items.Add(dr[0].ToString());
                }
                dr.Close();
                cnx.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            // comboBox remplisage ID == Plagnt : 
            try
            {
                SqlCommand cmdPlagnt = new SqlCommand();
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                
                cmdPlagnt.Connection = cnx;
                cmdPlagnt.CommandText = "SELECT p.id_plainte from dbo.plainte p";
                dr = cmdPlagnt.ExecuteReader();
                while (dr.Read())
                {
                    cmbTypeFileChikaya.Items.Add(dr[0].ToString());
                }
                dr.Close();
                cnx.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //remplire datagridview
            try
            {
                getData1();
                getData2();
                getData3();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void معلوماتعتاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProposNous p = new ProposNous();
            p.Show();
        }

        private void cmbTypeFileMawdoua_TextChanged(object sender, EventArgs e)
        {


            try
            {
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                
                cmd.Connection = cnx;
                cmd.CommandText = "SELECT cc.id_client_cause, cc.nom , ac.id_adversaire_cause ,ac.nom_adv  from dbo.cause c, dbo.client_cause cc, dbo.adversaire_cause ac WHERE c.id_cause='" + cmbNumMawdoua.SelectedItem + "' AND c.id_client=cc.id_client_cause AND c.id_adv=ac.id_adversaire_cause ";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtClientMawdoua.Clear();
                    txtAdvMawdoua.Clear();
                    txtClientMawdoua.Text = dr[1].ToString().Trim() + " - " + dr[0].ToString().Trim();
                    txtAdvMawdoua.Text = dr[3].ToString().Trim() +" - "+ dr[2].ToString().Trim();
                }
               
                cnx.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

          
            

            
        }
        OpenFileDialog dlg = new OpenFileDialog();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            dlg.Filter = "Images (*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG)|*.BMP;*.JPG;*.PNG;*.JPEG;*.GIF|" + "All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imagLocation = dlg.FileName.ToString();
                pictureBoxPieceJointWadiaaMawdoua.ImageLocation = imagLocation;
            }
            
        }


        string imagLocation = "";
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if(cnx.State==ConnectionState.Closed)
            {
                cnx.Open();
            }
            //!string.IsNullOrEmpty(imagLocation)
            if ((!string.IsNullOrEmpty(imagLocation) && txtAdvMawdoua.Text != "" && txtClientMawdoua.Text != "" && txtMontantMawdoua.Text != "" && txtNumCheckMawdoua.Text != ""))
                {
                
                byte[] imageCause = null;
                FileStream stream = new FileStream(imagLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(stream);
                imageCause = br.ReadBytes((int)stream.Length);


                SqlCommand cmdAjoutCause = new SqlCommand();
                cmd.Connection = cnx;
                cmdAjoutCause.Connection = cnx;
                cmd.CommandText = "SELECT cc.id_client_cause, cc.nom , ac.id_adversaire_cause ,ac.nom_adv  from dbo.cause c, dbo.client_cause cc, dbo.adversaire_cause ac WHERE c.id_cause='" + cmbNumMawdoua.SelectedItem + "' AND c.id_client=cc.id_client_cause AND c.id_adv=ac.id_adversaire_cause ";
                dr = cmd.ExecuteReader();
                //MessageBox.Show(dr[0].ToString());
                while (dr.Read())
                {
                    cmdAjoutCause.Parameters.Add(new SqlParameter("@logo", imageCause));
                    cmdAjoutCause.CommandText = "insert into depot_cause values('" + cmbNumMawdoua.Text + "'," + dr[0].ToString() + "," + int.Parse(dr[2].ToString()) + ", " +  txtNumCheckMawdoua.Text  + "," + float.Parse( txtMontantMawdoua.Text ) + ",@logo)";
                }
                dr.Close();
                cmdAjoutCause.ExecuteNonQuery();
                MessageBox.Show("لقد ثمت الاضافة بنجاح ... ");
                getData1();
                history.AddHistory(" الوديعة", "الاضافة", cmbNumMawdoua.Text);
                cnx.Close();
                }
                else
                {
                    MessageBoxManager.OK = "حسنا";
                    MessageBoxManager.Register();
                    MessageBox.Show("يجب ملئ الخانات ", "تنبيه", MessageBoxButtons.OK);
                }
        }
            
        private void xtraTabPage4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Images (*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG)|*.BMP;*.JPG;*.PNG;*.JPEG;*.GIF|" + "All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imagLocation = dlg.FileName.ToString();
                pictureBoxChikayaPieceJoin.ImageLocation = imagLocation;
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Images (*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG)|*.BMP;*.JPG;*.PNG;*.JPEG;*.GIF|" + "All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imagLocation = dlg.FileName.ToString();
               // pictureBoxChikayaPieceJoin.ImageLocation = imagLocation;
                pictureBoxOrderPieceJoint.ImageLocation = imagLocation;
            }
        }

        private void xtraTabPage6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbNumMawdoua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTypeFileChikaya_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtClientChikaya.Clear();
                listeBoxParPlagnt.Items.Clear();
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                
                SqlCommand cmdNomIDcHikaya = new SqlCommand();
                cmdNomIDcHikaya.Connection = cnx;
                cmdNomIDcHikaya.CommandText = "SELECT p2.id_plaignant, p2.nom, ppp.id_par_plaignant ,pp.nom from dbo.plainte p,dbo.plaignant p2, dbo.plainte_par_plaignant ppp, dbo.par_plaignant pp WHERE p.id_plainte='"+cmbTypeFileChikaya.SelectedItem+"' AND p.id_plaignant=p2.id_plaignant AND pp.id_par_plaignant=ppp.id_par_plaignant AND pp.id_par_plaignant=ppp.id_par_plaignant AND ppp.id_plainte=p.id_plainte ";
                dr = cmdNomIDcHikaya.ExecuteReader();
                while (dr.Read())
                {
                    
                    //txtAdvChikaya.Clear();
                    txtClientChikaya.Text = dr[0].ToString() + " / " + dr[1].ToString();
                    listeBoxParPlagnt.Items.Add(dr[2].ToString() + " / " + dr[3].ToString());
                }
                dr.Close();
                cnx.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbNumOrder_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                
                SqlCommand cmdNomIDOrder = new SqlCommand();
                cmdNomIDOrder.Connection = cnx;
                cmdNomIDOrder.CommandText = "SELECT co.id_client_order,co.nom,ao.id_adv_order,ao.nom FROM dbo.orderr o, dbo.client_order co, dbo.adv_order ao WHERE o.id_order='"+cmbNumOrder.SelectedItem+"' AND o.id_client_order=co.id_client_order AND ao.id_adv_order=o.id_adversaire_order";
                dr = cmdNomIDOrder.ExecuteReader();
                while (dr.Read())
                {
                    txtClientOrder.Clear();
                    txtAdvOrder.Clear();
                    txtClientOrder.Text = dr[0].ToString() + " / " + dr[1].ToString();
                    txtAdvOrder.Text = dr[2].ToString() + " / " + dr[3].ToString();
                }
                dr.Close();
                cnx.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
           // pictureBox1.Image = null;
            txtClientMawdoua.Clear();
            pictureBoxPieceJointWadiaaMawdoua.Image = null;
            cmbNumMawdoua.Text = "";
            txtAdvMawdoua.Clear();
            txtNumCheckMawdoua.Clear();
            txtMontantMawdoua.Clear();
            txtClientMawdoua.Clear();

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            txtClientChikaya.Clear();
            pictureBoxChikayaPieceJoin.Image = null;
            //txtAdvChikaya.Clear();
            listeBoxParPlagnt.Items.Clear();
            txtNumCheckChikaya.Clear();
            txtMontantChikaya.Clear();


        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            txtClientOrder.Clear();
            txtAdvOrder.Clear();
            txtNumCheckOrder.Clear();
            txtMontantOrder.Clear();
            pictureBoxOrderPieceJoint.Image = null;


        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
           try
           {
               int ID_Par_Plagnant=0;
               int ID_Plaignant;
               if(cnx.State==ConnectionState.Closed)
               {
                   cnx.Open();
               }
               if (!string.IsNullOrEmpty(imagLocation) && txtClientChikaya.Text != "" && listeBoxParPlagnt.SelectedItem != "" && txtNumCheckChikaya.Text != "" && txtMontantChikaya.Text != "")
               {
                   byte[] image = null;
                   FileStream stream = new FileStream(imagLocation, FileMode.Open, FileAccess.Read);
                   BinaryReader br = new BinaryReader(stream);
                   image = br.ReadBytes((int)stream.Length);

                   
                   SqlCommand CmdInfoPlgnt1 = new SqlCommand();
                   CmdInfoPlgnt1.Connection = cnx;
                   cmd.Connection = cnx;
                   CmdInfoPlgnt1.CommandText = "SELECT distinct p2.id_plaignant, ppp.id_par_plaignant, pp.nom from dbo.plainte p,dbo.plaignant p2, dbo.plainte_par_plaignant ppp, dbo.par_plaignant pp WHERE p.id_plainte='"+cmbTypeFileChikaya.SelectedItem+"' AND p.id_plaignant=p2.id_plaignant AND pp.id_par_plaignant=ppp.id_par_plaignant AND   ppp.id_plainte=p.id_plainte";
                   SqlDataReader DataReader1 = CmdInfoPlgnt1.ExecuteReader();
                   DataReader1.Read();
                   
                   ID_Plaignant = (int)DataReader1["id_plaignant"];
                   
                   if (listeBoxParPlagnt.Text!=null)
                   {
                       ID_Par_Plagnant = (int)DataReader1["id_par_plaignant"];
                   }
                       

                       cmd.CommandText = "insert into  depot_plgn([id_plainte],[id_plaignant],[id_par_plaignant],[num_check],[montant],[image_depot_plgn])values('" + cmbTypeFileChikaya.Text + "'," + ID_Plaignant + "," + ID_Par_Plagnant + "," + int.Parse(txtNumCheckChikaya.Text) + "," + float.Parse(txtMontantChikaya.Text) + ",@logoo)";
                       cmd.Parameters.Add("@ID_Par_Plagn", ID_Par_Plagnant);
                       cmd.Parameters.Add(new SqlParameter("@logoo", image));
                      
                       //cmd.CommandText = "insert into depot_plgn values('" + cmbTypeFileChikaya.Text + "'," + ID_Plaignant + ", " + ID_Par_Plagnant + " , " + int.Parse(txtNumCheckChikaya.Text) + "," + float.Parse(txtMontantChikaya.Text) + ",@logoo)";
                       DataReader1.Close();
                       dr.Close();
                        cmd.ExecuteNonQuery();
                       // MessageBox.Show("لقد ثمت الاضافة بنجاح ... ");
                        MessageBox.Show("لقد ثمت الاضافة بنجاح ... ","", MessageBoxButtons.OK);
                        history.AddHistory(" الوديعة", "الاضافة", cmbTypeFileChikaya.Text);
                        getData2();
                        cnx.Close();
                        cmd.Parameters.Clear();


               }
               else
               {
                   MessageBoxManager.OK = "حسنا";
                   MessageBoxManager.Register();
                   MessageBox.Show("يجب ملئ الخانات ", "تنبيه", MessageBoxButtons.OK);
               }
           }


           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }

                // requéte récuperation des ID d'order :

                SqlCommand cmdNomIDOrder = new SqlCommand();
                cmdNomIDOrder.Connection = cnx;
                cmdNomIDOrder.CommandText = "SELECT co.id_client_order,co.nom,ao.id_adv_order,ao.nom FROM dbo.orderr o, dbo.client_order co, dbo.adv_order ao WHERE o.id_order='" + cmbNumOrder.SelectedItem + "' AND o.id_client_order=co.id_client_order AND ao.id_adv_order=o.id_adversaire_order";
                dr = cmdNomIDOrder.ExecuteReader();
                while (dr.Read())
                {
                    txtClientOrder.Clear();
                    txtAdvOrder.Clear();
                    txtClientOrder.Text = dr[0].ToString() + " / " + dr[1].ToString();
                    txtAdvOrder.Text = dr[2].ToString() + " / " + dr[3].ToString();
                }
                dr.Close();



                //!string.IsNullOrEmpty(imagLocation)
                if ((!string.IsNullOrEmpty(imagLocation) && txtClientOrder.Text != "" && txtAdvOrder.Text != "" && txtNumCheckOrder.Text != "" && txtMontantOrder.Text != ""))
                {

                    byte[] imageCause = null;
                    FileStream stream = new FileStream(imagLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(stream);
                    imageCause = br.ReadBytes((int)stream.Length);


                    SqlCommand cmdInfoOrder = new SqlCommand();
                    cmd.Connection = cnx;
                    cmdInfoOrder.Connection = cnx;
                    cmdInfoOrder.CommandText = "SELECT co.id_client_order,ao.id_adv_order FROM dbo.orderr o, dbo.client_order co, dbo.adv_order ao WHERE o.id_order='" + cmbNumOrder.SelectedItem + "' AND o.id_client_order=co.id_client_order AND ao.id_adv_order=o.id_adversaire_order";
                    SqlDataReader DataReaderOrderInfo = cmdInfoOrder.ExecuteReader();
                    //MessageBox.Show(dr[0].ToString());
                    DataReaderOrderInfo.Read();
                    cmd.Parameters.Add(new SqlParameter("@logo", imageCause));
                    cmd.CommandText = "insert into depot_order values('" + cmbNumOrder.Text.ToString() + "'," + (int)DataReaderOrderInfo["id_client_order"] + "," + int.Parse(DataReaderOrderInfo["id_adv_order"].ToString()) + ", " + Convert.ToInt32( txtNumCheckOrder.Text) + "," + float.Parse(txtMontantOrder.Text) + ",@logo)";
                    DataReaderOrderInfo.Close();
                    dr.Close();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("لقد ثم اضافة الوديعة بنجاح ... ");
                    history.AddHistory(" الوديعة", "الاضافة", cmbNumOrder.Text.ToString());
                    getData3();
                    cnx.Close();
                    cmd.Parameters.Clear();
                }
                else
                {
                    MessageBoxManager.OK = "حسنا";
                    MessageBoxManager.Register();
                    MessageBox.Show("يجب ملئ الخانات ", "تنبيه", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbTypeFileChikaya_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void xtraTabPage5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbNumOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Imprimer_Depot_Cause frm = new Imprimer_Depot_Cause(id);
                frm.Show();
            }
            else
            {

            }
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count != 0)
            {
                int id = int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                Imprimer_Depot_Plainte frm = new Imprimer_Depot_Plainte(id);
                frm.Show();
            }
            else
            {

            }
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            if (dataGridView3.Rows.Count!=0)
            {
                int id = int.Parse(dataGridView3.SelectedRows[0].Cells[0].Value.ToString());
                Imprimer_depot_order frm = new Imprimer_depot_order(id);
                frm.Show();
            }
            else
            {

            }
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                getData1();

            }
            else 
            {
                searchDep_cause();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                getData2();

            }
            else
            {
                searchDep_plainte();
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
             if (textBox3.Text == "")
            {
                getData3();

            }
            else
            {
                searchdep_order();
            }
           
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            ImprimerAllDept_Cause frm = new ImprimerAllDept_Cause(textBox2.Text);
            frm.Show();
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            ImprimerAllDepotPlainte frm = new ImprimerAllDepotPlainte(textBox1.Text);
            frm.Show();
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            ImprimerAllDepotOrder frm = new ImprimerAllDepotOrder(textBox3.Text);
            frm.Show();
        }

        private void dropDownButton3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void dropDownButton2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
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

        private void simpleButton10_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton27_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xtraTabPage8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton12_Click(object sender, EventArgs e)
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

        private void simpleButton13_Click(object sender, EventArgs e)
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
