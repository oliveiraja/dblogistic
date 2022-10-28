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
    public partial class Frmautenticatio : Form
    {
        public Frmautenticatio()
        {
            InitializeComponent();
            Loadautentication();
            txtid.Visible = false;
            txtctrl.Visible = false;
            txtctrl.Text = "0";
            btnkancel.PerformClick();
            btnkancel.PerformClick();
       
        }
        private void Loadautentication()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Registo_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dvgautentication.DataSource = dt;
        }
        private void Saveautenticatio()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Registo_Insert", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("NaranUsers", SqlDbType.VarChar).Value = txtnaran.Text;
            sda.SelectCommand.Parameters.Add("password", SqlDbType.VarChar).Value = DAL.Encrypt(txtpass.Text);
            sda.SelectCommand.Parameters.Add("email", SqlDbType.VarChar).Value = txtemail.Text;
            sda.SelectCommand.Parameters.Add("funsaun", SqlDbType.VarChar).Value = txtfunsaun.Text;
            sda.SelectCommand.ExecuteReader();
            Loadautentication();
            btnkancel.PerformClick();
       
        }
        private void Updateautenticatio()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Registo_Update", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("Id", SqlDbType.Int).Value = txtid.Text;
            sda.SelectCommand.Parameters.Add("NaranUsers", SqlDbType.VarChar).Value = txtnaran.Text;
            sda.SelectCommand.Parameters.Add("password", SqlDbType.VarChar).Value = txtpass.Text;
            sda.SelectCommand.Parameters.Add("email", SqlDbType.VarChar).Value = txtemail.Text;
            sda.SelectCommand.Parameters.Add("funsaun", SqlDbType.VarChar).Value = txtfunsaun.Text;

            sda.SelectCommand.ExecuteReader();
            Loadautentication();
            btnkancel.PerformClick();
        }

        private void btnrai_Click(object sender, EventArgs e)
        {
            if (txtnaran.Text != "")
            {
                if (txtctrl.Text == "0")
                {
                    Saveautenticatio();
                }
                else
                {
                    Updateautenticatio();
                    btnrai.Text = "Save";
                }
            }
            else
            {
                MessageBox.Show("Prienxe informasaun molok rai dados!");
                txtnaran.Focus();
            }
            
        }

        private void btnkancel_Click(object sender, EventArgs e)
        {
            txtnaran.Text = "";
            txtid.Text = "";
            txtemail.Text = "";
            txtpass.Text = "";
            txtfunsaun.Text = "";
            txtctrl.Text = "0";
            btnrai.Enabled = true;
            btnrai.Text = "Save";
            txtid.Visible = false;
            txtctrl.Visible = false;
            txtnaran.Focus();
       
        }

        private void dvgautentication_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dvgautentication.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtnaran.Text = row.Cells[1].Value.ToString();
                txtpass.Text = row.Cells[2].Value.ToString();
                txtemail.Text = row.Cells[3].Value.ToString();
                txtfunsaun.Text = row.Cells[4].Value.ToString();

                txtctrl.Text = "1";
                btnrai.Text = "Update";
            }

        }
    }
}
