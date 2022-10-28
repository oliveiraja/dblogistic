using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logistik1
{
    public partial class Frmparameters : Form
    {
        public Frmparameters()
        {
            InitializeComponent();
        }

        private void btnkategori_Click(object sender, EventArgs e)
        {
            pnlcentral.Controls.Clear();
            Form_Kategoria fp = new Form_Kategoria();
            fp.TopLevel = false;
            pnlcentral.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();
        }

        private void btnsubkategori_Click(object sender, EventArgs e)
        {
            pnlcentral.Controls.Clear();
            Form_SubKategoria fp = new Form_SubKategoria();
            fp.TopLevel = false;
            pnlcentral.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();
        }

        private void btnmarka_Click(object sender, EventArgs e)
        {
            pnlcentral.Controls.Clear();
            Form_Marka fp = new Form_Marka();
            fp.TopLevel = false;
            pnlcentral.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();
        }

        private void btnmodelu_Click(object sender, EventArgs e)
        {
            pnlcentral.Controls.Clear();
            Modelu fp = new Modelu();
            fp.TopLevel = false;
            pnlcentral.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();
            
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            pnlcentral.Controls.Clear();
            Form_departemento fp = new Form_departemento();
            fp.TopLevel = false;
            pnlcentral.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();

        }

        private void btnarmajen_Click(object sender, EventArgs e)
        {
            pnlcentral.Controls.Clear();
            Form_armajen fp = new Form_armajen();
            fp.TopLevel = false;
            pnlcentral.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
           // Menu ss = new Menu();
            //ss.Show();
        }

        private void btnkodigo_Click(object sender, EventArgs e)
        {
            pnlcentral.Controls.Clear();
            Frmkodigo fp = new Frmkodigo();
            fp.TopLevel = false;
            pnlcentral.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();
        }
    }
}
