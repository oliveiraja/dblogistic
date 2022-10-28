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

    public partial class Frmmenusai : Form
    {
    public static Frmmenusai frmPs;

        public Frmmenusai()
        {
            InitializeComponent();
            frmPs = this;
            pnlContent.Controls.Clear();
            listasasansai fp = new listasasansai();
            fp.TopLevel = false;
            pnlContent.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();
        }

        private void btninskrisaunx_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            Form_sasansai fp = new Form_sasansai();
            fp.TopLevel = false;
            pnlContent.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();

        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            listasasansai fp = new listasasansai();
            fp.TopLevel = false;
            pnlContent.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();

        }
    }
}
