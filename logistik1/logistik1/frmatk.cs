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
    public partial class frmatk : Form
    {
        public frmatk()
        {
            InitializeComponent();
            LoadArmajen();
            Loadkategori();
            //  LoadSubkategori();
            //Loadmarka
            // LoadModelu();
            txtid.Visible = false;
            txtctrl.Visible = false;
            // txtsasanidtuan.Visible = false;
            txtctrl.Text = "0";
            Loadsasanatk();
            btnReset.PerformClick();
        }
        private void Loadsasanatk()
        {

        }
        private void Loadkategori()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Kategoria_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
           // sda.SelectCommand.Parameters.Add("KategoriaId", SqlDbType.Int).Value = txtkatid.Text;
            DataTable dt = new DataTable();
            sda.Fill(dt);
           // DataRow dr;
           // dr = dt.NewRow();
           //// dr.ItemArray = new object[] { 0, "-- KODIGO--" };
           // dt.Rows.InsertAt(dr, 0);

            cmbkategori.DisplayMember = "KATEGORIA";
            cmbkategori.ValueMember = "ID";
            cmbkategori.DataSource = dt;

        }
        private void LoadSubkategori()
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
        private void Loadmarka()
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
        private void Loadmodelu()
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

        private void cmbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtkatid.Text = cmbkategori.SelectedValue.ToString();
            LoadSubkategori();

        }

        private void cmbsubkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtskatid.Text = cmbsubkategori.SelectedValue.ToString();
            Loadmarka();

        }

        private void cmbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmarkaid.Text = cmbmarka.SelectedValue.ToString();
            Loadmodelu();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnrai_Click(object sender, EventArgs e)
        {
            if (cmbarmajen.Text != ""  || cmbkategori.Text != "" || cmbsubkategori.Text != "" || cmbmarka.Text != "" || cmbmodelo.Text != "" || txtqtd.Text != ""||txtunidade.Text!=""|| txtobservasaun.Text!="")

            {
                if (txtctrl.Text == "0")
                {

                    SaveSasan();
                }
                else
                {
                   // UpdateSasan();
                }
            }
            else
            {
                MessageBox.Show("Prienxe informasaun molok rai dados!");
            }
        }
        private void SaveSasan()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Sasanatk_Insert", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("Data_Tama", SqlDbType.DateTime).Value = dateTimePicker1.Value;
            sda.SelectCommand.Parameters.Add("KategoriaId", SqlDbType.Int).Value = cmbkategori.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("SubKategoriaId", SqlDbType.Int).Value = cmbsubkategori.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("MarkaId", SqlDbType.Int).Value = cmbmarka.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("ModeluId", SqlDbType.Int).Value = cmbmodelo.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("Qtd", SqlDbType.Int).Value = txtqtd.Text;
            sda.SelectCommand.Parameters.Add("Unidade", SqlDbType.VarChar).Value = txtunidade.Text;
            sda.SelectCommand.Parameters.Add("observasaun", SqlDbType.VarChar).Value = txtobservasaun.Text;
            sda.SelectCommand.Parameters.Add("ipcomp", SqlDbType.VarChar).Value = DAL.GetIPAddress();
            sda.SelectCommand.Parameters.Add("compname", SqlDbType.VarChar).Value = Environment.MachineName;
            sda.SelectCommand.Parameters.Add("ArmajenId", SqlDbType.Int).Value = cmbarmajen.SelectedValue.ToString();

            // SqlParameter msg = sda.SelectCommand.Parameters.Add("msg", SqlDbType.VarChar, 100);
            // msg.Direction = ParameterDirection.Output;
            sda.SelectCommand.ExecuteReader();
           // MessageBox.Show(msg.Value.ToString());
            Loadsasanatk();
            btnReset.PerformClick();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbarmajen.Text = "";
            cmbkategori.Text = "";
            cmbsubkategori.Text = "";
            cmbmarka.Text = "";
            cmbmodelo.Text = "";
            txtqtd.Text = "";
            txtunidade.Text = "";
            txtobservasaun.Text = "";
            btnrai.Enabled = true;
            btnrai.Text = "Save";
            txtid.Text = "";
            txtctrl.Text = "0";
            txtctrl.Visible = false;
            txtid.Visible = false;
            dateTimePicker1.Focus();

        }

        private void btnTaka_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
