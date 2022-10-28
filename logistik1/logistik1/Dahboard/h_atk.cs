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
    
    public partial class h_atk : Form
    {
        public static h_atk frmPs;
        public h_atk()
        {
            InitializeComponent();
            frmPs = this;
            pnlContent.Controls.Clear();
            Listaatk fp = new Listaatk();
            fp.TopLevel = false;
            pnlContent.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            Listaatk fp = new Listaatk();
            fp.TopLevel = false;
            pnlContent.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();
        }

        private void btninskrisaunx_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            frmatk fp = new frmatk();
            fp.TopLevel = false;
            pnlContent.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();
        }
    }
}
