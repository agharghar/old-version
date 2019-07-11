using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvocaBin.Models.Plaintes;
using AvocaBin.Operation;
using System.Data.SqlClient;
using AvocaBin.Models;

namespace AvocaBin.Controller
{
    public partial class DecisionForm : Form
    {
        PlaintesOperations op;
        String idplainte;
        شكاية plainte;
        SqlConnection cn = connection.getConnection();
        
       
        
        public DecisionForm()
        {
            op = new PlaintesOperations();
            InitializeComponent();
        }
        public DecisionForm(String idplainte, شكاية plainte)
        {
            op = new PlaintesOperations();
            InitializeComponent();
            this.idplainte = idplainte;
            this.plainte = plainte;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
          
            label3.Text = idplainte;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //if (cn.State == ConnectionState.Closed)
            //{
            //    cn.Open();
            //}
            Decision ds=new Decision();
            ds.Decision1=textBox1.Text;
            ds.Id_plainte=idplainte;
            op.addDecisionPlainte(ds);
            plainte.setDataListbox(ds.Id_plainte);
            history.AddHistory("اجراء الشكاية", "اضافة", idplainte);
            this.Close();

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
