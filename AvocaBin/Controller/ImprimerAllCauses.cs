﻿using System;
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
    public partial class ImprimerAllCauses : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da1 = new SqlDataAdapter();
        datasate_adv ds = new datasate_adv();
        SqlConnection cn = connection.getConnection();
        string id;
        
        public ImprimerAllCauses(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        //public ImprimerAllCauses()
        //{
        //    // TODO: Complete member initialization
        //}

        private void ImprimerAllCauses_Load(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed) { cn.Open(); }
            cmd = new SqlCommand("select c.id_cause,cl.nom ,ad.nom_adv,c.num_cause_tribunal ,c.type_cause ,c.ville,c.tribunal  from cause c,client_cause cl,adversaire_cause ad where( c.id_cause like '%"+id+"%' and c.etat='non archivé'  and c.id_client=cl.id_client_cause and c.id_adv=ad.id_adversaire_cause) or ( c.num_cause_tribunal like '%"+id+"%' and  c.etat='non archivé'  and c.id_client=cl.id_client_cause and c.id_adv=ad.id_adversaire_cause) or ( cl.nom like '%"+id+"%' and c.etat='non archivé'  and  c.id_client=cl.id_client_cause and c.id_adv=ad.id_adversaire_cause) or ( cl.cin like '%"+id+"%' and c.etat='non archivé'  and  c.id_client=cl.id_client_cause and c.id_adv=ad.id_adversaire_cause)order by date_session ASC", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "cause");
            cmd1 = new SqlCommand("select top(1)*from avocat", cn);
            da1 = new SqlDataAdapter(cmd1);
            da1.Fill(ds, "avocat");
            RepAllCauses i = new RepAllCauses();
            i.SetDataSource(ds);
            crystalReportViewer1.ReportSource = i;
            cn.Close();
           
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        //internal void Show(DataSet1 das)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
