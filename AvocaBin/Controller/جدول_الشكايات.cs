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
    public partial class جدول_الشكايات : DevExpress.XtraEditors.XtraForm
    {
        PlaintesOperations op;
        public جدول_الشكايات()
        {
            op = new PlaintesOperations();
            InitializeComponent();
        }

        private void جدول_الشكايات_Load(object sender, EventArgs e)
        {
            getDataTable();
        }

        public void getDataTable()
        {
            dataGridView1.Rows.Clear();
            op = new PlaintesOperations();

            List<Plainte> plaintes = op.getAllPlante();
            foreach (Plainte pp in plaintes)
            {
                try
                {
                    dataGridView1.Rows.Add(pp.IdPlainte,pp.DateCreation,pp.TypeTribunal,pp.TypePlaint);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                String idplainte = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Plainte p = op.getPlanteById(idplainte).First();
                Plaignant plaignant = op.getPlaignantByCinAndId(p.IdPlaignant.ToString()).First();
                List<PlainteParPlaignant> ppp = op.getPlainteParPlaintes(p.IdPlainte);
                dataGridView2.Rows.Clear();
                foreach (var par in getParplaintes(ppp))
                {
                    dataGridView2.Rows.Add(par.IdParPlaignant, par.Nom, par.TypeParPlaignant);
                }
                lblnom.Text = plaignant.Nom;
                lbltype.Text = plaignant.TypePlaignant;
            }
        }

        private List<Par_plaignant> getParplaintes(List<PlainteParPlaignant> ppp) {
            List<Par_plaignant> parplains = new List<Par_plaignant>();
            foreach (PlainteParPlaignant item in ppp)
            {
                Par_plaignant pp = op.getParPlaignantByIdAndCIN(item.IdParPlaignant.ToString()).First();
                parplains.Add(pp);
                
            }
            return parplains;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButtonSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                MessageBoxManager.Yes = "نعم";
                MessageBoxManager.No = "لا";
                MessageBoxManager.Register();
                DialogResult dr = MessageBox.Show("هل أنت متأكد من الحذف ؟؟", "تنبيه", MessageBoxButtons.YesNo);
                MessageBoxManager.Unregister();
                if (dr == DialogResult.Yes)
                {
                    op.deletePlainte(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    getDataTable();
                    history.AddHistory(" جدول الشكايات ", "الحدف", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                }
                else
                {
                }
            }
        }

        private void simpleButtonModification_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                String idplaint = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                شكاية plai = new شكاية(idplaint);
                plai.Show();
                this.Close();
                history.AddHistory(" جدول الشكايات ", "التعديل", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void simpleButtonAjouter_Click(object sender, EventArgs e)
        {
            شكاية plai = new شكاية();
            plai.Show();
            this.Close();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            op = new PlaintesOperations();
            dataGridView1.Rows.Clear();
            List<Plainte> plaintes = op.getPlanteById(textBox1.Text);
            foreach (Plainte pp in plaintes)
            {
                try
                {
                    dataGridView1.Rows.Add(pp.IdPlainte, pp.DateCreation, pp.TypeTribunal, pp.TypePlaint);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnImpr_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                String idplaint = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Form2 f = new Form2(idplaint);

                f.Show();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            PrintAllPlaintes f = new PrintAllPlaintes();

            f.Show();
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