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

namespace LIS
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            displaysasan();
            btndeletesasan.Enabled=false;
            txtidsasan.Visible=false;
            txtctrlsasan.Visible=false;
            txtnsasan.Focus();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnsavesasan_Click(object sender, EventArgs e)
        {
            koneksaun kon = new koneksaun();

            if (txtnsasan.Text != "" && txtctrlsasan.Text == "0")
         
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = ("usp_T_SasanInsert");               
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@naran", txtnsasan.Text);              
                cmd.ExecuteNonQuery();
                displaysasan();
                txtnsasan.Text = "";
            }
            else
                    if (txtidsasan.Text != "0")
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "usp_T_SasanUpdate";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", txtidsasan.Text);                       
                        cmd.ExecuteNonQuery();
                        displaysasan();
                        txtnsasan.Text = "";
                        txtctrlsasan.Text = "0";

                    }
              else
                    {
                        MessageBox.Show("Prienxe Naran Sasan");
                        txtnsasan.Focus();
                    }
            
        }

        private void btnsavesupplier_Click(object sender, EventArgs e)
        {

        }
  
        //Display data in Datagridview
        private void displaysasan()
        {
            koneksaun kon = new koneksaun();
            SqlDataAdapter sda = new SqlDataAdapter("usp_sasanSelect",kon.Activekon());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            sda.Fill(dt);
            DGsasan.DataSource = dt;

        }

        //clear data
        private void ClearData()
        {
            txtnsasan.Text ="";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btndeletesasan_Click(object sender, EventArgs e)
        {
            koneksaun kon = new koneksaun();
            if (txtidsasan.Text != "0")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "usp_T_SasanDelete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",txtidsasan.Text);
                cmd.ExecuteNonQuery();
                displaysasan();
                txtnsasan.Text="";
                txtctrlsasan.Text = "0" ;
                btndeletesasan.Enabled=false;

            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btncancelsasan_Click(object sender, EventArgs e)
        {
            txtnsasan.Text = "";
            txtidsasan.Text = "";
            txtctrlsasan.Text = "0";
            btnsavesasan.Text = "Save";
            btnsavesasan .Enabled=true;
            btndeletesasan.Enabled=false;

        }

        private void btnsavearmajen_Click(object sender, EventArgs e)
        {

        }
    }
}
