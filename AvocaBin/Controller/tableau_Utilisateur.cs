using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvocaBin;
using System.Data.SqlClient;

namespace AvocaBin.Controller
{

    public partial class tableau_Utilisateur : Form
    {
        //Cause_Operations co = new Cause_Operations();
        SqlConnection cn = connection.getConnection();
        DataSet ds;
        SqlCommand cmd;
        SqlDataAdapter dr;
        public tableau_Utilisateur()
        {
            InitializeComponent();
        }

        private void tableau_Utilisateur_Load(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            cmd = new SqlCommand("select * from Utilisateur", cn);
            dr = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dr.Fill(ds, "utilisateurs");
            dataGridView1.DataSource = ds.Tables["utilisateurs"];
            cn.Close();
           // testdata();
        }
    }
}
