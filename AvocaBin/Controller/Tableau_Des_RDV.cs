using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
//using AvocaBin.Controller;
using AvocaBin.Operation;
using System.Data.SqlClient;
using AvocaBin.Models;

namespace AvocaBin
{
    public partial class Tableau_Des_RDV : DevExpress.XtraEditors.XtraForm
    {

        SqlConnection cnx = connection.getConnection();
        public Tableau_Des_RDV()
        {
            InitializeComponent();
        }

        
        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (txtBoxCinRDV.Text != "")
            {
                try
                {
                    if (cnx.State == ConnectionState.Closed)
                    {
                        cnx.Open();
                    }

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "update RDV set DateRDV='" + dateTimePickerDateRDV.Value + "', Nom='" + txtBoxNomRDV.Text + "', Cause='" + txtDescriptionRDV.Text + "' where CinRDV='" + txtBoxCinRDV.Text + "' ";
                    cmd.Connection = cnx;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ثم التعديل بنجاح ", "التعديل", MessageBoxButtons.OK);
                    txtBoxCinRDV.Clear();
                    dateTimePickerDateRDV.Text = "";
                    txtBoxNomRDV.Clear();
                    txtDescriptionRDV.Clear();
                    history.AddHistory(" جدول المواعيد", "التعديل", txtBoxCinRDV.Text);
                    cnx.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("المرجوا اختيار الموعد المراد التعديل عليه");
            }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (txtBoxCinRDV.Text != "")
            {
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "delete from RDV where CinRDV='" + txtBoxCinRDV.Text + "'";
                cmd.Connection = cnx;
                cmd.ExecuteReader();
                MessageBox.Show("ثم الحدف بنجاح ", "الحدف", MessageBoxButtons.OK);
                txtBoxCinRDV.Clear();
                dateTimePickerDateRDV.Text = "";
                txtBoxNomRDV.Clear();
                txtDescriptionRDV.Clear();
                history.AddHistory(" جدول المواعيد", "الحدف", txtBoxCinRDV.Text);
                cnx.Close();
            }
            else
            {
                MessageBox.Show(" المرجوا اختيار الموعد المراد حدفه");
            }
        }

        private void Tableau_Des_RDV_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from RDV";
                cmd.Connection = cnx;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["CinRDV"].ToString(), dr["Nom"].ToString(), dr["DateRDV"].ToString(), dr["Cause"].ToString());
                }
                dr.Close();
                cnx.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            txtBoxCinRDV.Clear();
            dateTimePickerDateRDV.Text = "";
            txtBoxNomRDV.Clear();
            txtDescriptionRDV.Clear();
        }

        private void txtDescriptionRDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (txtBoxCinRDV.Text != "")
            {
                try
                {
                    if (cnx.State == ConnectionState.Closed)
                    {
                        cnx.Open();
                    }

                    SqlCommand cmd = new SqlCommand();
                    //cmd.CommandText = "insert into RDV(CinRDV,DateRDV,Nom,Cause) values(@cin,@date,@nom,@cause)";
                    cmd.CommandText = "insert into RDV values('" + txtBoxCinRDV.Text + "','" + dateTimePickerDateRDV.Value + "','" + txtBoxNomRDV.Text + "','" + txtDescriptionRDV.Text + "')";

                    cmd.Connection = cnx;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("الاضافة ثمث بنجاح ", "الاضافة", MessageBoxButtons.OK);
                    history.AddHistory(" جدول المواعيد", "الاضافة", txtBoxCinRDV.Text);

                    cnx.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(" المرجوا ادخال البيانات ");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from RDV where DateRDV BETWEEN '"+dateTimePickerDeRDV.Value.ToString()+"' and '"+dateTimePickerARDV.Value.ToString()+"'";
                cmd.Connection = cnx;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["CinRDV"].ToString(),dr["Nom"].ToString(),dr["DateRDV"].ToString(),dr["Cause"].ToString());
                }
                dr.Close();
                history.AddHistory(" جدول المواعيد", "البحث", txtBoxCinRDV.Text);
                cnx.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtBoxCinRDV.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateTimePickerDateRDV.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBoxNomRDV.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();;
            txtDescriptionRDV.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from RDV";
                cmd.Connection = cnx;
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dr.Close();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNomRDV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnx;
                cmd.Parameters.AddWithValue("@nom", txtNomRDV.Text);
                cmd.Parameters.AddWithValue("@cin", txtNomRDV.Text);
                cmd.CommandText = "select * from RDV where Nom=@nom or CinRDV=@cin";
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dr.Close();
                cmd.Parameters.Clear();
                cnx.Close();

        }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            txtNomRDV.Clear();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {

        }
    }
}