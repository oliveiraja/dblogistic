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
    public partial class Form_departemento : Form
    {
        public Form_departemento()
        {
            InitializeComponent();
            LoadDepartemento();
            btndelete.Enabled = false;
            txtndept.Focus();
            txtid.Visible = false;
            txtctrl.Visible = false;
            txtctrl.Text = "0";

        }

        //method load departemento
        private void LoadDepartemento()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Departemento_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvSasan.DataSource = dt;
        }

        //method save Departemento
        private void SaveDepartemento()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Departemento_Insert", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("naran", SqlDbType.VarChar).Value = txtndept.Text;
            sda.SelectCommand.ExecuteReader();
            LoadDepartemento();
            btncancel.PerformClick();
        }

        //method update Departemento
        private void UpdateDepartemento()
        { 
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Departemento_Update",kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("id", SqlDbType.Int).Value = txtid.Text;
            sda.SelectCommand.Parameters.Add("naran", SqlDbType.VarChar).Value = txtndept.Text;
            sda.SelectCommand.ExecuteReader();
            LoadDepartemento();
            btncancel.PerformClick();
        }

        //method delete Departemento
        private void DeleteDepartemento()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter ("usp_T_Departemento_Delete",kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("id",SqlDbType.Int).Value = txtid.Text;
            sda.SelectCommand.ExecuteReader();
            LoadDepartemento();
            btncancel.PerformClick();
        }

        //save ka update Departemento
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtndept.Text != "")
            {
                if (txtctrl.Text == "0")
                {
                    SaveDepartemento();
                }
                else
                {
                    UpdateDepartemento();
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
            txtndept.Text = "";
            txtid.Text = "";
            txtctrl.Text = "0";
            btndelete.Enabled = false;
            btnsave.Enabled = true;
            btnsave.Text = "Save";
            txtndept.Focus();
        }

        private void dgvSasan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSasan.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtndept.Text = row.Cells[1].Value.ToString();
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
                DeleteDepartemento();
            }
            else
            {
                btncancel.PerformClick();
            }
           
        }
    }
}
