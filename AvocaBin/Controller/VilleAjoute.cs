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
using AvocaBin.Models;

namespace AvocaBin.Controller
{
    public partial class VilleAjoute : Form
    {
        SqlConnection cnx = connection.getConnection();
        public VilleAjoute()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {


                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnx;
                    cmd.CommandText = "insert into ville(ville) values(@ville)";
                    SqlParameter p = new SqlParameter("@ville", textBox1.Text);
                    cmd.Parameters.Add(p);
                    if (cnx.State == ConnectionState.Closed)
                    {
                        cnx.Open();
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ثم اظافة المدينة بنجاح", "الاظافة", MessageBoxButtons.OK);
                    history.AddHistory(" المحكمة", "الاظافة", textBox1.Text);
                    cnx.Close();
                }
                else
                {
                            MessageBox.Show("يجب ملا الخانة");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
