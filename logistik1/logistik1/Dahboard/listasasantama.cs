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
//using Microsoft.Office.Interop.Excel;

namespace logistik1
{
    public partial class listasasantama : Form
    {
        public static listasasantama frmPs;
        public listasasantama()
        {
            InitializeComponent();
            loadsearch();
            frmPs = this;
        }
        

        private void loadsearch()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
           sqlParams.Add(new SqlParameter("Find", txtseacrh.Text));
            // sqlParams.Add(new SqlParameter("linguaId"));
            DataTable dt = DAL.ExecSP("usp_search_Cek", sqlParams);
            DataView dv = new DataView(dt);
            dgvsasantama.DataSource = dv;
            dgvsasantama.DataSource = dt;
            dgvsasantama.BorderStyle = BorderStyle.None;
            dgvsasantama.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvsasantama.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvsasantama.DefaultCellStyle.SelectionBackColor = Color.Black;
            dgvsasantama.BackgroundColor = Color.WhiteSmoke;
            dgvsasantama.EnableHeadersVisualStyles = false;
            dgvsasantama.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvsasantama.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvsasantama.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void txtseacrh_TextChanged(object sender, EventArgs e)
        {
            {


                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("Find", txtseacrh.Text));
                // sqlParams.Add(new SqlParameter("linguaId"));
                DataTable dt = DAL.ExecSP("usp_search_Cek", sqlParams);
                DataView dv = new DataView(dt);
                dgvsasantama.DataSource = dv;
                

            }
        }

        private void dgvsasantama_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frmupdatesasantama f2 = new Frmupdatesasantama();
             f2.txtid.Text = this.dgvsasantama.CurrentRow.Cells[0].Value.ToString();
          //  f2.dateTimePicker1.Text = this.dgvsasantama.CurrentRow.Cells[1].Value.ToString();
            f2.cmbsupplier.Text = this.dgvsasantama.CurrentRow.Cells[2].Value.ToString();
            f2.cmbkat.Text = this.dgvsasantama.CurrentRow.Cells[3].Value.ToString();
            f2.cmbskat.Text = this.dgvsasantama.CurrentRow.Cells[4].Value.ToString();
            f2.cmbmarka.Text = this.dgvsasantama.CurrentRow.Cells[5].Value.ToString();
            f2.cmbmodelu.Text = this.dgvsasantama.CurrentRow.Cells[6].Value.ToString();
           // f2.txtqtd.Text = this.dgvsasantama.CurrentRow.Cells[7].Value.ToString();
           // f2.txtobservasaun.Text = this.dgvsasantama.CurrentRow.Cells[7].Value.ToString();
            //f2.txtpresu.Text = this.dgvsasantama.CurrentRow.Cells[7].Value.ToString();
            //f2.txttotal.Text = this.dgvsasantama.CurrentRow.Cells[8].Value.ToString();
            //f2.txtobservasaun.Text = this.dgvsasantama.CurrentRow.Cells[9].Value.ToString();
            //f2.cmbkondisaun.Text = this.dgvsasantama.CurrentRow.Cells[10].Value.ToString();
            //f2.cmbarmajen.Text = this.dgvsasantama.CurrentRow.Cells[11].Value.ToString();
            
           f2.Show();


        }

        private void listasasantama_Load(object sender, EventArgs e)
        {
           
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            Frmcek f2 = new Frmcek();
            f2.Show();
        }
    }
}
