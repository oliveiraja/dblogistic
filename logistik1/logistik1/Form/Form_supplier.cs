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
    public partial class Form_supplier : Form
    {
        public Form_supplier()
        {
            InitializeComponent();
            LoadSupplier();
            btndelete.Enabled = false;
            txtnsupplier.Focus();
            txtid.Visible = false;
            txtctrl.Visible = false;
            txtctrl.Text = "0";

        }

        //method load Supplier
        private void LoadSupplier()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Supplier_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvSupplier.DataSource = dt;
        }

        //method save Supplier
        private void SaveSupplier()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Supplier_Insert", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("naran", SqlDbType.VarChar).Value = txtnsupplier.Text;
            sda.SelectCommand.ExecuteReader();
            LoadSupplier();
            btncancel.PerformClick();
        }

        //method update Supplier
        private void UpdateSupplier()
        { 
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Supplier_Update",kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("id", SqlDbType.Int).Value = txtid.Text;
            sda.SelectCommand.Parameters.Add("naran", SqlDbType.VarChar).Value = txtnsupplier.Text;
            sda.SelectCommand.ExecuteReader();
            LoadSupplier();
            btncancel.PerformClick();
        }

        //method delete Supplier
        private void DeleteSupplier()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter ("usp_T_Supplier_Delete",kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("id",SqlDbType.Int).Value = txtid.Text;
            sda.SelectCommand.ExecuteReader();
            LoadSupplier();
            btncancel.PerformClick();
        }

        //save ka update sasan
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtnsupplier.Text != "")
            {
                if (txtctrl.Text == "0")
                {
                    SaveSupplier();
                }
                else
                {
                    UpdateSupplier();
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
            txtnsupplier.Text = "";
            txtid.Text = "";
            txtctrl.Text = "0";
            btndelete.Enabled = false;
            btnsave.Enabled = true;
            btnsave.Text = "Save";
            txtnsupplier.Focus();
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSupplier.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtnsupplier.Text = row.Cells[1].Value.ToString();
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
                DeleteSupplier();
            }
            else
            {
                btncancel.PerformClick();
            }

        }
    }
}
