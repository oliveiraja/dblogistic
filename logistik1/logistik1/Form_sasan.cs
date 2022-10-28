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
    public partial class Form_sasan : Form
    {
        public Form_sasan()
        {
            InitializeComponent();
            LoadSasan();            
        }

        //method load sasan
        private void LoadSasan()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Sasan_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvSasan.DataSource = dt;
        }

        //method save sasan
        private void SaveSasan()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Sasan_Insert", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("naran", SqlDbType.VarChar).Value = txtnsasan.Text;
            sda.SelectCommand.ExecuteReader();
            LoadSasan();
            btncancel.PerformClick();
        }

        //method update sasan
        private void UpdateSasan()
        { 
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Sasan_Update",kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("id", SqlDbType.Int).Value = txtid.Text;
            sda.SelectCommand.Parameters.Add("naran", SqlDbType.VarChar).Value = txtnsasan.Text;
            sda.SelectCommand.ExecuteReader();
            LoadSasan();
            btncancel.PerformClick();
        }

        //method delete sasan
        private void DeleteSasan()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter ("usp_T_Sasan_Delete",kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("id",SqlDbType.Int).Value = txtid.Text;
            sda.SelectCommand.ExecuteReader();
            LoadSasan();
            btncancel.PerformClick();
        }

        //save ka update sasan
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtnsasan.Text != "")
            {
                if (txtctrl.Text == "0")
                {
                    SaveSasan();
                }
                else
                {
                    UpdateSasan();
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
            txtnsasan.Text = "";
            txtid.Text = "";
            txtctrl.Text = "0";
            btndelete.Enabled = false;
            btnsave.Enabled = true;
            btnsave.Text = "Save";
            txtid.Visible = false;
            txtctrl.Visible = false;            
            txtnsasan.Focus();
        }

        private void dgvSasan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSasan.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtnsasan.Text = row.Cells[1].Value.ToString();
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
                DeleteSasan();
            }
            else
            {
                btncancel.PerformClick();
            }
        }

        private void Form_sasan_Load(object sender, EventArgs e)
        {
            btncancel.PerformClick();
        }

        
    }
}
