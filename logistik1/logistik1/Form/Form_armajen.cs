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
    public partial class Form_armajen : Form
    {
        public Form_armajen()
        {
            InitializeComponent();
            LoadArmajen();
            btndelete.Enabled = false;
            txtnarmajen.Focus();
            txtid.Visible = false;
            txtctrl.Visible = false;
            txtctrl.Text = "0";

        }

        //method load Armajen
        private void LoadArmajen()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Armajen_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvSupplier.DataSource = dt;
        }

        //method save Armajen
        private void SaveArmajen()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Armajen_Insert", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("naran", SqlDbType.VarChar).Value = txtnarmajen.Text;
            sda.SelectCommand.ExecuteReader();
            LoadArmajen();
            btncancel.PerformClick();
        }

        //method update Armajen
        private void UpdateArmajen()
        { 
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Armajen_Update", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("id", SqlDbType.Int).Value = txtid.Text;
            sda.SelectCommand.Parameters.Add("naran", SqlDbType.VarChar).Value = txtnarmajen.Text;
            sda.SelectCommand.ExecuteReader();
            LoadArmajen();
            btncancel.PerformClick();
        }

        //method delete Armajen
        private void DeleteArmajen()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Armajen_Delete", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("id",SqlDbType.Int).Value = txtid.Text;
            sda.SelectCommand.ExecuteReader();
            LoadArmajen();
            btncancel.PerformClick();
        }

        //save ka update Armajen
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtnarmajen.Text != "")
            {
                if (txtctrl.Text == "0")
                {
                    SaveArmajen();
                }
                else
                {
                    UpdateArmajen();
                    btnsave.Text = "Save";                    
                }
            }
            else
            {
                MessageBox.Show("Prienxe informasaun molok rai dados!");
            }
        }

        //cancel entry foun,update no delete
        private void btncancel_Click(object sender, EventArgs e)
        {
            txtnarmajen.Text = "";
            txtid.Text = "";
            txtctrl.Text = "0";
            btndelete.Enabled = false;
            btnsave.Enabled = true;
            btnsave.Text = "Save";
            txtnarmajen.Focus();
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSupplier.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtnarmajen.Text = row.Cells[1].Value.ToString();
                txtctrl.Text = "1";
                btndelete.Enabled = true;
                btnsave.Text = "Update";
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ita hakarak delete dadus ida ne'e?", "Delete " + this.Text, MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                DeleteArmajen();
            }
            else
            {
                btncancel.PerformClick();
            }

        }

        private void Form_armajen_Load(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtctrl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
