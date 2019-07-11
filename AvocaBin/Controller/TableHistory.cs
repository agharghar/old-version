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
    public partial class TableHistory : Form
    {
        public TableHistory()
        {
            InitializeComponent();
        }

        private void TableHistory_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlConnection cnx = connection.getConnection();
                SqlDataReader dr;
                cmd.Connection = cnx;
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                cmd.CommandText = "select * from history";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0].ToString(),dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
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
