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
using AvocaBin.Operation;
namespace AvocaBin.Controller
{
    public partial class AjalatForm : Form
    {
        Cause_Operations co = new Cause_Operations();
        SqlConnection cn = connection.getConnection();
        DataSet ds;
        SqlCommand cmd;
        SqlDataAdapter dr;
        SqlDataReader reader;
       
        public AjalatForm()
        {
            InitializeComponent();
        }

        private void AjalatForm_Load(object sender, EventArgs e)
        {

            if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
            cmd = new SqlCommand("select c.id_cause as[المرجع],cl.nom as[الموكل],ad.nom_adv as[الخصم],c.num_cause_tribunal as[رقم القضية],c.date_creation as[تاريخ الجلسة],c.ville as[المدينة],c.tribunal as[المحكمة],c.duree as[المدة] from cause c,client_cause cl,adversaire_cause ad,sessione s where c.id_client=cl.id_client_cause and c.id_adv=ad.id_adversaire_cause and s.id_cause=c.id_cause and s.decision='مداولة'order by tribunal ASC", cn);
            dr = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dr.Fill(ds, "causes");
            dataGridView1.DataSource = ds.Tables["causes"];
            cn.Close();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DateTime datemodawala = DateTime.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                TimeSpan dif = datemodawala.Date - DateTime.Now.Date;
                 //MessageBox.Show(dif.Days.ToString());
                //TimeSpan difference = dateDeRecyclage.Date - DateTime.Now.Date ;
               // difference.Days
                int duree=int.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                 if (int.Parse(dif.Days.ToString())<=(duree-5))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red; 
                }
            }
       

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
     
}
