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
    public partial class Form_SubKategoria : Form
    {
        public Form_SubKategoria()
        {
            InitializeComponent();
            LoadKategoria();
            LoadSubKategoria();
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
            cmbkat.DisplayMember = "KATEGORIA";
            cmbkat.ValueMember = "ID";
            cmbkat.DataSource = dt;
        }

        //Method loadsubkategoria ba data grid
        private void LoadSubKategoria()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_SubKategoria_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgvSasan.DataSource = dt;

        }

        //Method savesubkategoria
        private void SaveSubKategoria()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_SubKategoria_Insert", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("KategoriaId", SqlDbType.Int).Value = cmbkat.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("Naran", SqlDbType.VarChar).Value = txtnaran.Text;
            //  int KategoriaId = Convert.ToInt32(cmbkat.SelectedValue.ToString());
            sda.SelectCommand.ExecuteReader();
            LoadSubKategoria();
            btncancel.PerformClick();
        }

        //Method updatekategoria()
        private void UpdateSubKategoria()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_SubKategoria_Update", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("Id", SqlDbType.Int).Value = txtid.Text;
            sda.SelectCommand.Parameters.Add("KategoriaId", SqlDbType.Int).Value = cmbkat.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("Naran", SqlDbType.VarChar).Value = txtnaran.Text;
            sda.SelectCommand.ExecuteReader();
            LoadSubKategoria();
            btncancel.PerformClick();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtnaran.Text != "")
            {
                if (txtctrl.Text == "0")
                {
                    SaveSubKategoria();
                }
                else
                {
                    UpdateSubKategoria();
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
            cmbkat.Text = "";
            txtnaran.Text = "";
            txtid.Text = "";
            txtctrl.Text = "0";
            btnsave.Enabled = true;
            btnsave.Text = "Save";
            txtid.Visible = false;
            txtctrl.Visible = false;
            cmbkat.Focus();
        }

        private void dgvSasan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSasan.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                cmbkat.Text = row.Cells[1].Value.ToString();
                txtnaran.Text = row.Cells[2].Value.ToString();
                txtctrl.Text = "1";
                btnsave.Text = "Update";

            }
        }

        private void Form_Kategoria_Load(object sender, EventArgs e)
        {
            btncancel.PerformClick();
        }

        private void cmbkat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbkat.SelectedValue.ToString() != null)
            {
                int KategoriaId = Convert.ToInt32(cmbkat.SelectedValue.ToString());
            }
        }

        private void cmbkat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgvSasan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_Marka f2 = new Form_Marka();
            // f2.textid.Text = this.dgvSasan.CurrentRow.Cells[0].Value.ToString();
            f2.txtid.Text = this.dgvSasan.CurrentRow.Cells[0].Value.ToString();
            f2.txtnaran.Text = this.dgvSasan.CurrentRow.Cells[1].Value.ToString();
            f2.cmbskat.Text = this.dgvSasan.CurrentRow.Cells[2].Value.ToString();
            //f2.txtidcard.Text = this.dgvRH.CurrentRow.Cells[2].Value.ToString();
            f2.Show();

        }

        private void dgvSasan_DoubleClick(object sender, EventArgs e)
        {
           }
    }

        
    
}
