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
    public partial class Form_sasansai : Form
    {
        public Form_sasansai()
        {
            InitializeComponent();
            LoadArmajen();
            LoadDepartemento();
            Loadkategori();
          //  LoadSubkategori();
            //Loadmarka
           // LoadModelu();
            txtid.Visible = false;
            txtctrl.Visible = false;
           // txtsasanidtuan.Visible = false;
            txtctrl.Text = "0";
            LoadSasanSai();
            btnReset.PerformClick();
        }

        //method load departemento
        private void LoadDepartemento()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter  sda = new SqlDataAdapter("usp_T_Departemento_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbdept.DisplayMember = "Naran";
            cmbdept.ValueMember = "Id";
            cmbdept.DataSource = dt;
        }

        //method load sasan
        private void Loadkategori()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Kategoria_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbkategori.DisplayMember = "KATEGORIA";
            cmbkategori.ValueMember = "ID";
            cmbkategori.DataSource = dt;
        }
        private void LoadSubKategoria()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_SubKategoria_ViewID", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("KategoriaId", SqlDbType.Int).Value = txtkatid.Text;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select SubKategoria--" };
            dt.Rows.InsertAt(dr, 0);
            cmbsubkategori.DisplayMember = "SUB KATEGORIA";
            cmbsubkategori.ValueMember = "ID";
            cmbsubkategori.DataSource = dt;
            cmbmarka.Text = "";
       
        }
        private  void Loadmarka()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Marka_ViewID", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("SubKategoriaId", SqlDbType.Int).Value = txtskatid.Text;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Marka--" };
            dt.Rows.InsertAt(dr, 0);
            cmbmarka.DisplayMember = "MARKA";
            cmbmarka.ValueMember = "ID";
            cmbmarka.DataSource = dt;
            cmbmodelo.Text = "";

        }
        private void LoadModelu()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Modelu_ViewID", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("MarkaId", SqlDbType.Int).Value = txtmarkaid.Text;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Modelu--" };
            dt.Rows.InsertAt(dr, 0);
            cmbmodelo.DisplayMember = "MODELU";
            cmbmodelo.ValueMember = "ID";
            cmbmodelo.DataSource = dt;
        }

        //method load armajen
        private void LoadArmajen()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Armajen_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbarmajen.DisplayMember = "Naran";
            cmbarmajen.ValueMember = "Id";
            cmbarmajen.DataSource = dt;
        }

        //method load sasantama
        private void LoadSasanSai()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_SasanSai_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //dgvsasan.DataSource = dt;
          //  dgvsasan.Columns[9].Visible = false;
        }

        //method save sasan
        private void SaveSasan()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_SasanSai_Insert", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("Data_Sai", SqlDbType.DateTime).Value = dateTimePicker1.Value;
            sda.SelectCommand.Parameters.Add("ArmajenId",SqlDbType.Int).Value = cmbarmajen.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("DepartementoId",SqlDbType.Int).Value = cmbdept.SelectedValue.ToString();
            //sda.SelectCommand.Parameters.Add("SasanId",SqlDbType.Int).Value = txtsasanidtuan.Text; 
            sda.SelectCommand.Parameters.Add("KategoriaId",SqlDbType.Int).Value = cmbkategori.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("SubKategoriaId",SqlDbType.Int).Value = cmbsubkategori.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("MarkaId",SqlDbType.Int).Value = cmbmarka.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("ModeluId",SqlDbType.Int).Value = cmbmodelo.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("Qtd",SqlDbType.Int).Value = txtqtd.Text;
            SqlParameter msg = sda.SelectCommand.Parameters.Add("msg", SqlDbType.VarChar, 100);
            msg.Direction = ParameterDirection.Output;
            sda.SelectCommand.ExecuteReader();
            MessageBox.Show(msg.Value.ToString());
            LoadSasanSai();
            btnReset.PerformClick();
        }

        //method update sasan
        private void UpdateSasan()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_SasanSai_Update", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("Id", SqlDbType.Int).Value = txtid.Text;
            sda.SelectCommand.Parameters.Add("Data_Sai", SqlDbType.Date).Value = dateTimePicker1.Value;
            sda.SelectCommand.Parameters.Add("ArmajenId", SqlDbType.Int).Value = cmbarmajen.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("DepartementoId", SqlDbType.Int).Value = cmbdept.SelectedValue.ToString();
           sda.SelectCommand.Parameters.Add("KategoriaId", SqlDbType.Int).Value = cmbkategori.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("SubKategoriaId", SqlDbType.Int).Value = cmbsubkategori.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("MarkaId", SqlDbType.Int).Value = cmbmarka.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("ModeluId", SqlDbType.Int).Value = cmbmodelo.SelectedValue.ToString();
            //sda.SelectCommand.Parameters.Add("SasanId", SqlDbType.Int).Value = cmbkategori.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("Qtd", SqlDbType.Int).Value = txtqtd.Text;    
            sda.SelectCommand.ExecuteReader();
            LoadSasanSai();
            btnReset.PerformClick();
        }

        //method delete sasan
        private void DeleteSasan()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_SasanSai_Delete", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("id", SqlDbType.Int).Value = txtid.Text;
            sda.SelectCommand.Parameters.Add("armajenID", SqlDbType.Int).Value = cmbarmajen.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("departementoId", SqlDbType.Int).Value = cmbdept.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("sasanID", SqlDbType.Int).Value = cmbkategori.SelectedValue.ToString();
            sda.SelectCommand.ExecuteReader();
            LoadSasanSai();
            btnReset.PerformClick();
        }

        private void dgvsasan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void Form_sasansai_Load(object sender, EventArgs e)
        {
            btnReset.PerformClick();
        }

        private void cmbarmajen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbdept_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbsasan_KeyPress(object sender, KeyPressEventArgs e)
        {
           // e.Handled = true;
        }

        private void txtqtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.');
        }

        private void cmbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtkatid.Text = cmbkategori.SelectedValue.ToString();
            LoadSubKategoria();
        }

        private void cmbsubkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtskatid.Text = cmbsubkategori.SelectedValue.ToString();
            Loadmarka();            
       
        }

        private void cmbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmarkaid.Text = cmbmarka.SelectedValue.ToString();
            LoadModelu();

        }

        private void btnrai_Click(object sender, EventArgs e)
        {
            if (cmbarmajen.Text != "" || cmbdept.Text != "" || cmbkategori.Text != "" || cmbsubkategori.Text != "" || cmbmarka.Text != "" || cmbmodelo.Text != "" || txtqtd.Text != "")
            {
                if (txtctrl.Text == "0")
                {

                    SaveSasan();
                }
                else
                {
                    UpdateSasan();
                }
            }
            else
            {
                MessageBox.Show("Prienxe informasaun molok rai dados!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbarmajen.Text = "";
            cmbdept.Text = "";
            cmbkategori.Text = "";
            cmbsubkategori.Text = "";
            cmbmarka.Text = "";
            cmbmodelo.Text = "";
            txtqtd.Text = "";
            btnrai.Enabled = true;
            
            btnrai.Text = "Save";
            txtid.Text = "";
            txtctrl.Text = "0";
            txtctrl.Visible = false;
            txtid.Visible = false;
            dateTimePicker1.Focus();
        }
    }
}
