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


namespace logistik1
{
    public partial class listasasansai : Form
    {
        public static listasasansai frmPs;
        public listasasansai()
        {
            InitializeComponent();
            loadsearch();
            frmPs = this;
        }
        private void loadsearch()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
           // sqlParams.Add(new SqlParameter("Find", txtseacrh.Text));
            // sqlParams.Add(new SqlParameter("linguaId"));
            DataTable dt = DAL.ExecSP("usp_T_SasanSai_View", sqlParams);
            DataView dv = new DataView(dt);
            dgvsasansai.DataSource = dv;
            dgvsasansai.DataSource = dt;
            dgvsasansai.BorderStyle = BorderStyle.None;
            dgvsasansai.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvsasansai.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvsasansai.DefaultCellStyle.SelectionBackColor = Color.Black;
            dgvsasansai.BackgroundColor = Color.WhiteSmoke;
            dgvsasansai.EnableHeadersVisualStyles = false;
            dgvsasansai.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvsasansai.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvsasansai.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            frmatk f2 = new frmatk();
            f2.Show();
        }
    }
}
