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
    public partial class tribunalSuprimer : Form
    {
        SqlConnection cnx = connection.getConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public tribunalSuprimer()
        {
            InitializeComponent();
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            textBoxSupprimer.Clear();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSupprimer.Text != "")
                {


                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnx;
                    cmd.CommandText = "delete from tribunal where tribunal='" + textBoxSupprimer.Text + "'";
                    if (cnx.State == ConnectionState.Closed)
                    {
                        cnx.Open();
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ثم حدف المحكمة بنجاح", "الحدف", MessageBoxButtons.OK);
                    history.AddHistory(" المحكمة", "حدف", textBoxSupprimer.Text);
                    dataGridView1.Rows.Clear();
                    cmd.CommandText = "select * from tribunal";
                    cmd.Connection = cnx;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(dr[0].ToString());
                    }
                    dr.Close();
                    cnx.Close();
                }
                else
                {
                    MessageBox.Show("يجب اختيار السطر المراد حدفه من جدول المحاكم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tribunalSuprimer_Load(object sender, EventArgs e)
        {
            try
            {

                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                dataGridView1.Rows.Clear();
                cmd.Connection = cnx;
                cmd.CommandText = "select * from tribunal";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0].ToString());
                }
                dr.Close();
                cnx.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBoxSupprimer.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
