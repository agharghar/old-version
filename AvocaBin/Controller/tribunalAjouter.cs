using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvocaBin.Operation;
using System.Data.SqlClient;
using AvocaBin.Models;
namespace AvocaBin.Controller
{
    public partial class tribunalAjouter : Form
    {
         public delegate void DoEvent(string a);
         public event DoEvent fm_Refresh_typeTribunal;
         SqlConnection cnx = connection.getConnection();
         الموضوع ma = new الموضوع();
        
        public tribunalAjouter()
        {
            InitializeComponent();
        }

        public tribunalAjouter(الموضوع ma)
        {
            Cause_Operations co = new Cause_Operations();
            InitializeComponent();
            this.ma = ma;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                if (textBox1.Text != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnx;
                    cmd.CommandText = "insert into tribunal(tribunal) values(@tribunal)";
                    SqlParameter p = new SqlParameter("@tribunal", textBox1.Text);
                    cmd.Parameters.Add(p);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم اظافة المحكمة بنجاح", "الاظافة", MessageBoxButtons.OK);
                    cnx.Close();
                    this.Close();
                    history.AddHistory(" المحكمة", "الاظافة", textBox1.Text);
                    cnx.Close(); ;
                    ma.gettribunal();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("يجب ملا الخانة","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tribunalAjouter_Load(object sender, EventArgs e)
        {

        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
