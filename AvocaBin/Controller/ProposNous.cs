using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvocaBin.Controller;

namespace AvocaBin.Controller
{
    public partial class ProposNous : Form
    {
        public ProposNous()
        {
            InitializeComponent();
        }

        private void simpleButtonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProposNous_Load(object sender, EventArgs e)
        {
            label5.Text = "تاريخ الانتهاء "+Properties.Settings.Default.DateFinal.ToShortDateString();
        }
    }
}
