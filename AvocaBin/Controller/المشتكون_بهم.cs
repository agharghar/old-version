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
using AvocaBin.Operation;
using AvocaBin.Models.Plaintes;
using AvocaBin.Models;


namespace AvocaBin
{
    public partial class المشتكون_بهم : DevExpress.XtraEditors.XtraForm
    {
        شكاية chikaya = new شكاية();
        PlaintesOperations op;

        public المشتكون_بهم(شكاية chikaya)
        {
            op = new PlaintesOperations();
            InitializeComponent();
            this.chikaya = chikaya;
        }

        public المشتكون_بهم()
        {
            op = new PlaintesOperations();
            InitializeComponent();
        }

        private void cb_genre_plai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void المشتكون_بهم_Load(object sender, EventArgs e)
        {
            cb_genre_plai.Items.Add("طبيعي");
            cb_genre_plai.Items.Add("معنوي");
            getDataTable();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cb_genre_plai.Text=="" || txb_name.Text=="")
            {
                MessageBox.Show("المرجو ملا الخانات");
            }
            else
            {
                Par_plaignant pp = new Par_plaignant();
                pp.Cin = txb_cin.Text;
                pp.Nom = txb_name.Text;
                pp.RegistreDeCommerce1 = txb_num_societe.Text;
                pp.RepresentantLegal = txb_juridique.Text;
                pp.Adresse = txb_adresse.Text;
                //  pp.TypeParPlaignant=cb_genre_plai.selectedItem
                pp.TypeParPlaignant = cb_genre_plai.SelectedItem.ToString();
                op.addParPlaignant(pp);
                chikaya.getDataTableParPlaignant();
                getDataTable();
                simpleButton1.Enabled = false;
                history.AddHistory("المشتكون بهم", "الاضافة", txb_cin.Text);   

               
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {




        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {


            MessageBoxManager.Yes = "نعم";
            MessageBoxManager.No = "لا";
            MessageBoxManager.Register();
            DialogResult dr=MessageBox.Show("هل أنت متأكد من الحذف ؟؟", "تنبيه", MessageBoxButtons.YesNo);
            MessageBoxManager.Unregister();
            if (dr == DialogResult.Yes)
            {
                String id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                
                    op.deleteParPlaignant(id);
                    MessageBox.Show("تم الحذف بنجاح");
                    getDataTable();
                    chikaya.getDataTableParPlaignant();
                    history.AddHistory("المشتكون بهم", "الحدف", txb_cin.Text);
            }
            else
            {
            }
  
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            {
                txb_cin.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txb_name.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txb_num_societe.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txb_juridique.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txb_adresse.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                cb_genre_plai.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString(); 
            }
           
        }

        public void getDataTable()
        {
            dataGridView1.Rows.Clear();
            op = new PlaintesOperations();

            List<Par_plaignant> pps = op.getAllParPlaignant();
            foreach (Par_plaignant pp in pps)
            {
                try
                {
                    dataGridView1.Rows.Add(pp.IdParPlaignant, pp.Cin, pp.Nom, pp.RegistreDeCommerce1, pp.RepresentantLegal, pp.TypeParPlaignant, pp.Adresse);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            testdata();
        }
        public void testdata()
        {
            if (dataGridView1.Rows.Count == 0)
            {

                //simpleButton1.Enabled = false;
                simpleButton3.Enabled = false;
                simpleButton4.Enabled = false;
              
            }
            else
            {
               // simpleButton1.Enabled = true;
                simpleButton3.Enabled = true;
                simpleButton4.Enabled = true;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            clearText();
            simpleButton1.Enabled = true;
        }

        public void clearText()
        {
           
            txb_cin.Clear();
            txb_name.Clear();
            txb_num_societe.Clear();
            txb_juridique.Clear();
            txb_adresse.Clear();
           
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
                Par_plaignant pp = new Par_plaignant();
                pp.IdParPlaignant = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                pp.Cin = txb_cin.Text;
                pp.Nom = txb_name.Text;
                pp.RegistreDeCommerce1 = txb_num_societe.Text;
                pp.RepresentantLegal = txb_juridique.Text;
                pp.Adresse = txb_adresse.Text;
                //  pp.TypeParPlaignant=cb_genre_plai.selectedItem
                pp.TypeParPlaignant = cb_genre_plai.SelectedItem.ToString();
                op.updateParPlaignant(pp);
                getDataTable();
                chikaya.getDataTableParPlaignant();
                history.AddHistory("المشتكون بهم", "التعديل", txb_cin.Text);
            
        }

        private void btn_searsh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
           // op.getParPlaignantByIdAndCIN(txb_searsh.Text);
            foreach (Par_plaignant pp in op.getParPlaignantByIdAndCIN(txb_searsh.Text))
            {
                try
                {
                   
                    dataGridView1.Rows.Add(pp.IdParPlaignant, pp.Cin, pp.Nom, pp.RepresentantLegal, pp.RegistreDeCommerce1, pp.TypeParPlaignant, pp.Adresse);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            txb_searsh.Clear();
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