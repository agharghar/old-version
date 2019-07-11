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

namespace AvocaBin.Controller
{
    public partial class ListeTribunal : Form
    {
        SqlConnection cnx = connection.getConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public ListeTribunal()
        {
            
            InitializeComponent();
        }

        private void LesVille_Click(object sender, EventArgs e)
        {
            tribunalAjouter v = new tribunalAjouter();
            v.Show();
        }

        private void الحدفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tribunalSuprimer vs = new tribunalSuprimer();
            vs.Show();
        }

        private void الخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cnx.State==ConnectionState.Closed)
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListeTribunal_Load(object sender, EventArgs e)
        {
            try
            {

                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                // dataGridView1.Rows.Clear();
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
    }
}
