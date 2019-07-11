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
    public partial class المشتكون : DevExpress.XtraEditors.XtraForm
    {    PlaintesOperations op;
    شكاية chikaya = new شكاية();
        public المشتكون( شكاية chikaya)
        {
            op=new PlaintesOperations();
            InitializeComponent();
            this.chikaya = chikaya;
        }
        public المشتكون()
        {
            op = new PlaintesOperations();
            InitializeComponent();
           
        }

        private void المشتكون_Load(object sender, EventArgs e)
        {
            cb_genre_plai.Items.Add("طبيعي");
            cb_genre_plai.Items.Add("معنوي");
            getDataTable();
        }

        public void getDataTable()
        {
            dataGridView1.Rows.Clear();

            List<Plaignant> pps = op.getAllPlaignant();
            foreach (Plaignant pp in pps)
            {
                try
                {
                    dataGridView1.Rows.Add(pp.IdPlaignant, pp.Cin,pp.Adresse,pp.Nom,pp.Telephone, pp.RepresentantLegal, pp.RegistreDeCommerce1, pp.TypePlaignant);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cb_genre_plai.Text=="" || txb_name.Text=="")
            {
                MessageBox.Show("المرجو ملا الخانات");
            }
            else
            {
                Plaignant pp = new Plaignant();
                pp.Cin = txb_cin.Text;
                pp.Nom = txb_name.Text;
                pp.RegistreDeCommerce1 = txb_num_societe.Text;
                pp.RepresentantLegal = txb_juridique.Text;
                pp.Adresse = txb_adresse.Text;
                pp.Telephone = txb_tele.Text;
                //  pp.TypeParPlaignant=cb_genre_plai.selectedItem
                pp.TypePlaignant = cb_genre_plai.SelectedItem.ToString();
                op.addPlaignant(pp);
                chikaya.getDataTablePlaignant();
                getDataTable();
                history.AddHistory("المشتكون", "الاضافة", txb_cin.Text);
            }
            
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            clearText();
        }

        public void clearText()
        {
          
            txb_cin.Clear();
            txb_name.Clear();
            txb_num_societe.Clear();
            txb_juridique.Clear();
            txb_adresse.Clear();
            txb_tele.Clear();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Yes = "نعم";
            MessageBoxManager.No = "لا";
            MessageBoxManager.Register();
            DialogResult dr = MessageBox.Show("هل أنت متأكد من الحذف ؟؟", "تنبيه", MessageBoxButtons.YesNo);
            MessageBoxManager.Unregister();
            if (dr == DialogResult.Yes)
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    op.deletePlaignant(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    getDataTable();
                    chikaya.getDataTablePlaignant();
                    history.AddHistory("المشتكون", "الحدف", txb_cin.Text);
                }
                else
                {
                    MessageBox.Show("يجب اختيار مشتكي");
                }
                
            }
            else
            {
            }
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
          
            txb_cin.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txb_adresse.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txb_name.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txb_tele.Text=dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txb_juridique.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txb_num_societe.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            cb_genre_plai.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString(); ;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {

                Plaignant pp = new Plaignant();
                pp.IdPlaignant = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                pp.Cin = txb_cin.Text;
                pp.Nom = txb_name.Text;
                pp.RegistreDeCommerce1 = txb_num_societe.Text;
                pp.RepresentantLegal = txb_juridique.Text;
                pp.Adresse = txb_adresse.Text;
                pp.Telephone = txb_tele.Text;
                //  pp.TypeParPlaignant=cb_genre_plai.selectedItem
                pp.TypePlaignant = cb_genre_plai.SelectedItem.ToString();
                op.updatePlaignant(pp);
                getDataTable();
                chikaya.getDataTablePlaignant();
                history.AddHistory("المشتكون", "التعديل", txb_cin.Text);   
            }
            else
            {
                MessageBox.Show("يجب اختيار مشتكي");
            }
            }

        private void btn_searsh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            // op.getParPlaignantByIdAndCIN(txb_searsh.Text);
            foreach (Plaignant pp in op.getPlaignantByCinAndId(txb_searsh.Text))
            {
                try
                {
                    dataGridView1.Rows.Add(pp.IdPlaignant, pp.Cin, pp.Adresse, pp.Nom, pp.Telephone, pp.RepresentantLegal, pp.RegistreDeCommerce1, pp.TypePlaignant);
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
      
