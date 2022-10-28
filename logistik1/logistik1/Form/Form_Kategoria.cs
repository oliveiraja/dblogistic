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
    public partial class Form_Kategoria : Form
    {
        public Form_Kategoria()
        {
            InitializeComponent();
            LoadKategoria();
            btncancel.PerformClick();
        }

        //Method loadkategoria
        private void LoadKategoria()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Kategoria_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvSasan.DataSource = dt;
        }

        //Method savekategoria
        private void SaveKategoria()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Kategoria_insert", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
           // sda.SelectCommand.Parameters.Add("Kodigo", SqlDbType.Int).Value = txtkodigo.Text;
            sda.SelectCommand.Parameters.Add("Naran", SqlDbType.VarChar).Value = txtnaran.Text;
            sda.SelectCommand.ExecuteReader();
            LoadKategoria();
            btncancel.PerformClick();
        }

        //Method updatekategoria()
        private void UpdateKategoria()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Kategoria_Update", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("Id", SqlDbType.Int).Value = txtid.Text;
           //  sda.SelectCommand.Parameters.Add("Kodigo", SqlDbType.Int).Value = txtkodigo.Text;
             sda.SelectCommand.Parameters.Add("Naran", SqlDbType.VarChar).Value = txtnaran.Text;
            sda.SelectCommand.ExecuteReader();
            LoadKategoria();
            btncancel.PerformClick();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtnaran.Text != "")
            {
                if (txtctrl.Text == "0")
                {
                    SaveKategoria();
                }
                else
                {
                    UpdateKategoria();
                    btnsave.Text = "Save";
                }
            }
            else
            {
                MessageBox.Show("Prienxe informasaun molok rai dados!");
                txtnaran.Focus();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtnaran.Text = "";
            txtid.Text = "";
            txtctrl.Text = "0";            
            btnsave.Enabled = true;
            btnsave.Text = "Save";
            txtid.Visible = false;
            txtctrl.Visible = false;
            txtnaran.Focus();
        }

        private void dgvSasan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSasan.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtnaran.Text = row.Cells[1].Value.ToString();
                txtctrl.Text = "1";
                btnsave.Text = "Update";

            }           
        }

        private void Form_Kategoria_Load(object sender, EventArgs e)
        {
            btncancel.PerformClick();
        }

        private void btnskat_Click(object sender, EventArgs e)
        {
                     
        }
    }
}
