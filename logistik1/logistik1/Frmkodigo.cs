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
    public partial class Frmkodigo : Form
    {
        public Frmkodigo()
        {
            InitializeComponent();
            LoadKodigo();
            btndelete.Enabled = false;
            txtkodigo.Focus();
            txtid.Visible = false;
            txtctrl.Visible = false;
            txtctrl.Text = "0";

        }
        private void LoadKodigo()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Kodigo_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvkodigo.DataSource = dt;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtkodigo.Text != "")
            {
                if (txtctrl.Text == "0")
                {
                    SaveKodigo();
                }
                else
                {
                    UpdateKodigo();
                    btnsave.Text = "Save";
                }
            }
            else
            {
                MessageBox.Show("Prienxe informasaun molok rai dados!");

            }
            
        }
        private void SaveKodigo()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Kodigo_Insert", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("Kodigo", SqlDbType.VarChar).Value = txtkodigo.Text;
            sda.SelectCommand.ExecuteReader();
            LoadKodigo();
            btncancel.PerformClick();


        }
        private void UpdateKodigo()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Kodigo_Update", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("Id", SqlDbType.Int).Value = txtid.Text;
            sda.SelectCommand.Parameters.Add("Kodigo", SqlDbType.VarChar).Value = txtkodigo.Text;
            sda.SelectCommand.ExecuteReader();
            LoadKodigo();
            btncancel.PerformClick();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtkodigo.Text = "";
            txtid.Text = "";
            txtctrl.Text = "0";
            btndelete.Enabled = false;
            btnsave.Enabled = true;
            btnsave.Text = "Save";
            txtkodigo.Focus();
        }

        private void dgvkodigo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvkodigo.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtkodigo.Text = row.Cells[1].Value.ToString();
                txtctrl.Text = "1";
                btndelete.Enabled = true;
                btnsave.Text = "Update";
            }

            }
        }
    }
