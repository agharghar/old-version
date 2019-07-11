using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvocaBin.Controller;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace AvocaBin.Controller
{
    public partial class Avocat : Form
    {
        int a;
        SqlConnection cnx = connection.getConnection();
        public Avocat()
        {
            InitializeComponent();
        }

        private void معلوماتعناToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProposNous p = new ProposNous();
            p.Show();
        }
        string imagLocation = "";



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cnx.State == ConnectionState.Closed)
            {
                cnx.Open();
            }
            
            if (txtNomAvocat.Text != "" && txtAdresseAvocat.Text != "" && !(String.IsNullOrEmpty(imagLocation)) && txtAutoriteAvocat.Text!="")
            {
                byte[] image = null;
                FileStream stream = new FileStream(imagLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(stream);
                image = br.ReadBytes((int)stream.Length);
                SqlCommand cmd = new SqlCommand("insert into avocat values('" + txtNomAvocat.Text + "','" + txtAdresseAvocat.Text + "',@logo,'" + txtAutoriteAvocat.Text + "') ", cnx);
                cmd.Connection = cnx;
                cmd.Parameters.Add(new SqlParameter("@logo", image));
                int n = cmd.ExecuteNonQuery();
                MessageBox.Show("ثم تحميل الصورة ");
                cnx.Close();
            }
            else
            {
                MessageBox.Show("يجب ملئ البيانات ");
            }
            
            



           
            
        }

        private void btnDownLoadImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Images (*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG)|*.BMP;*.JPG;*.PNG;*.JPEG;*.GIF|" + "All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imagLocation = dlg.FileName.ToString();
                pictureBoxAvocat.ImageLocation = imagLocation;
            }


           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void Avocat_Load(object sender, EventArgs e)
        {
          
                
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}