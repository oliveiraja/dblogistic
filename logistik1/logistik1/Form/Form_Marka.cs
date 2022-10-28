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
    public partial class Form_Marka : Form
    {
        public Form_Marka()
        {
            InitializeComponent();
            LoadSubKategoria();
            LoadMarka();
            btncancel.PerformClick();
        }

        //method load subkategoria
        private void LoadSubKategoria()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_SubKategoria_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbskat.DisplayMember = "SUB KATEGORIA";
            cmbskat.ValueMember = "Id";
            cmbskat.DataSource = dt;
        }

        //method load marka
        private void LoadMarka()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Marka_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvSasan.DataSource = dt;
        }

        //method savemarka
        private void SaveMarka()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Marka_Insert", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("SubKategoriaId", SqlDbType.Int).Value = cmbskat.SelectedValue.ToString();
            //int SubKategoriaId = Convert.ToInt32(cmbskat.Text.Trim());
            sda.SelectCommand.Parameters.Add("Naran", SqlDbType.VarChar).Value = txtnaran.Text;
            sda.SelectCommand.ExecuteReader();
            LoadMarka();
            btncancel.PerformClick();
        }

        //method update marka
        private void UpdateMarka()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Marka_Update", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("Id", SqlDbType.Int).Value = txtid.Text;
            //sda.SelectCommand.Parameters.Add("SubKategoriaId", SqlDbType.Int).Value = cmbskat.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("Naran", SqlDbType.VarChar).Value = txtnaran.Text;
            sda.SelectCommand.ExecuteReader();
            LoadMarka();
            btncancel.PerformClick();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            cmbskat.Text = "";
            txtnaran.Text = "";
            txtid.Text = "";
            txtctrl.Text = "0";
            btnsave.Enabled = true;
            btnsave.Text = "Save";
            txtid.Visible = false;
            txtctrl.Visible = false;
            cmbskat.Focus();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtnaran.Text != "")
            {
                if (txtctrl.Text == "0")
                {
                    SaveMarka();
                }
                else
                {
                    UpdateMarka();
                    btnsave.Text = "Save";
                }
            }
            else
            {
                MessageBox.Show("Prienxe informasaun molok rai dados!");
                cmbskat.Focus();
            }
            
        }

        
        private void Form_Marka_Load(object sender, EventArgs e)
        {
            btncancel.PerformClick();
        }

        private void cmbskat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgvSasan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSasan.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                cmbskat.Text = row.Cells[1].Value.ToString();
                txtnaran.Text = row.Cells[2].Value.ToString();
                txtctrl.Text = "1";
                btnsave.Text = "Update";

            }
        }
    }
}
