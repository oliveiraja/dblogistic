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
    public partial class Modelu : Form
    {
        public Modelu()
        {
            InitializeComponent();
            LoadMarka();
            LoadModelu();
            btncancel.PerformClick();
        }

        //method load marka
        private void LoadMarka()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Marka_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbmarka.DisplayMember = "MARKA";
            cmbmarka.ValueMember = "Id";
            cmbmarka.DataSource = dt;
        }

        //method load modelu
        private void LoadModelu()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Modelu_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvSasan.DataSource = dt;
        }

        //method save modelu
        private void SaveModelu()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Modelu_Insert", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("MarkaId", SqlDbType.Int).Value = cmbmarka.SelectedValue.ToString();
           // int MarkaId = Convert.ToInt32(cmbmarka.SelectedValue.ToString());
            sda.SelectCommand.Parameters.Add("Naran", SqlDbType.VarChar).Value = txtnaran.Text;           
            sda.SelectCommand.ExecuteReader();
            LoadModelu();
            btncancel.PerformClick();
        }

        //method update modelu
        private void UpdateModelu()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Modelu_Update", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("Id", SqlDbType.Int).Value = txtid.Text;
           // sda.SelectCommand.Parameters.Add("MarkaId", SqlDbType.Int).Value = cmbmarka.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("Naran", SqlDbType.VarChar).Value = txtnaran.Text;
            sda.SelectCommand.ExecuteReader();
            LoadModelu();
            btncancel.PerformClick();
        }
                           
        private void dgvSasan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSasan.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                cmbmarka.Text = row.Cells[1].Value.ToString();
                txtnaran.Text = row.Cells[2].Value.ToString();
                txtctrl.Text = "1";
                btnsave.Text = "Update";

            }          
        }

        private void Modelu_Load(object sender, EventArgs e)
        {
            btncancel.PerformClick();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            if (txtnaran.Text != "")
            {
                if (txtctrl.Text == "0")
                {
                    SaveModelu();
                }
                else
                {
                    UpdateModelu();
                    btnsave.Text = "Save";
                }
            }
            else
            {
                MessageBox.Show("Prienxe informasaun molok rai dados!");
                txtnaran.Focus();
            }
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            cmbmarka.Text = "";
            txtnaran.Text = "";
            txtid.Text = "";
            txtctrl.Text = "0";
            btnsave.Enabled = true;
            btnsave.Text = "Save";
            txtid.Visible = false;
            txtctrl.Visible = false;
            cmbmarka.Focus();
        }

        private void cmbmarka_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }                   
    }
}
