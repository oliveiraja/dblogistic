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
    public partial class Homesasantama : Form
    {
        public static Homesasantama frmPs;
        public Homesasantama()
        {
            InitializeComponent();
            frmPs = this;
            pnlContent.Controls.Clear();
            listasasantama fp = new listasasantama();
            fp.TopLevel = false;
            pnlContent.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();
        }

        private void btninskrisaunx_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            Form_sasantama fp = new Form_sasantama();
            fp.TopLevel = false;
            pnlContent.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();

        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            listasasantama fp = new listasasantama();
            fp.TopLevel = false;
            pnlContent.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();
        }
    }
}
