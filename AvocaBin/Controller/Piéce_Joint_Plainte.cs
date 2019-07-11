using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AvocaBin.Operation;
using AvocaBin.Models.Plaintes;
using AvocaBin.Models;
using System.IO;

namespace AvocaBin
{
    public partial class Piéce_Joint_Plainte : DevExpress.XtraEditors.XtraForm
    {
        OpenFileDialog of;
        int u = 0;
        PlaintesOperations op;
        DataSet ds = new DataSet();
        SqlConnection cn = connection.getConnection();
        SqlDataAdapter ad;
        public Piéce_Joint_Plainte()
        {
            of = new OpenFileDialog();
            op = new PlaintesOperations();
            InitializeComponent();
        }
        
        private void Btn_searsh_Click(object sender, EventArgs e)
        {
            if (textBoxIdPlainte.Text != "")
            {
   getDataTable();

            }
            else
            {
                MessageBox.Show("يجب ملئ خانة البحث , للبحث عن الشكايات");
            }
            
        }

        private void Piéce_Joint_Plainte_Load(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            ad = new SqlDataAdapter("select id_plainte from plainte", cn);
            ad.Fill(ds, "id_plainte");

            comboBox1.DataSource = ds.Tables["id_plainte"];
            comboBox1.DisplayMember = "id_plainte";
            //getdata();
        }
        public void getDataTable()
        {
            dataGridView1.Rows.Clear();
            List<PjPlainte> pp = op.getPJPlainte(textBoxIdPlainte.Text);



            foreach (PjPlainte ppj in pp)
            {
                MemoryStream photo = new MemoryStream(ppj.Photo);
                Image img = Image.FromStream(photo);

                dataGridView1.Rows.Add(ppj.Id_pj, ppj.Id_plainte, ppj.Titre, img);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            {
                pictureBox1.Image = (Image)dataGridView1.SelectedRows[0].Cells[3].Value;
            }
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            of.Filter = "Images (*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG)|*.BMP;*.JPG;*.PNG;*.JPEG;*.GIF|" + "All files (*.*)|*.*";
            of.Title = "تحميل الصور :";
            of.Multiselect = true;
            if (of.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("تم تحميل الصورة");
                u = 1;
            }
            else
            {
                MessageBox.Show("لم تحميل الصورة");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //save PJ setup
            if (u == 1 && comboBox1.Text != "")
            {
                foreach (string fileName in of.FileNames)
                {
                    try
                    {
                        FileInfo fi = new FileInfo(fileName);
                        PjPlainte pjplaint = new PjPlainte();
                        byte[] img = null;
                        FileStream f = new FileStream(of.FileName, FileMode.Open);
                        BinaryReader br = new BinaryReader(f);
                        img = br.ReadBytes((int)f.Length);
                        f.Close();


                        pjplaint.Id_plainte = comboBox1.Text;
                            pjplaint.Photo = img;

                        pjplaint.Titre = Path.GetFileName(of.FileName);
                        pjplaint.Date_enregistrement =DateTime.Parse( DateTime.Now.ToShortDateString());
                        //  pjOrder1.id_order = ord.id_order;
                        op.addPjPalainte(pjplaint);
                        MessageBox.Show("تمت إضافة الوثيقة بنجاح");
                        history.AddHistory("وثائق الشكاية", "الاضافة", comboBox1.Text);
                        getDataTable();
                        
                        
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
                u = 0;
            }
            else
            {
                MessageBox.Show("يجب اختيار رقم الشكاية في خانة الشكايات لإضافة الوثيقة");
            }
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            {
                op.deletePJplainte(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                history.AddHistory("وثائق الشكاية", "الحدف", textBoxIdPlainte.Text);
                getDataTable();
                pictureBox1.Image = null;
            }
            else
            {
                MessageBox.Show("الجدول غير ممتلئ");
            }
            
        }
    }
}