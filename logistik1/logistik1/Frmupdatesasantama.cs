using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;

namespace logistik1
{
    public partial class Frmupdatesasantama : Form
    {
        public Frmupdatesasantama()
        {
            InitializeComponent();
            loadsasantama();
            loadsupplier();
            loadkategori();
            loadsubkategori();
            LoadMarka();
            LoadModelu();
            loadkondisaun();
            loadarmajen();
        }

        private void btnaltera_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=DIVA;Initial Catalog=lisdb;integrated security=true");
            if (txtobservasaun.Text != "")
            {
                KoneksaunDb kon = new KoneksaunDb();
                SqlDataAdapter sda = new SqlDataAdapter("usp_T_SasanTama_UpdateE", kon.Koneksaun());
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.Add("Id", SqlDbType.Int).Value = txtid.Text;
                sda.SelectCommand.Parameters.Add("Data_Tama", SqlDbType.Date).Value = dateTimePicker1.Value;
                sda.SelectCommand.Parameters.Add("SupplierId", SqlDbType.Int).Value = cmbsupplier.SelectedValue.ToString();
                //sda.SelectCommand.Parameters.Add("sasanID", SqlDbType.Int).Value = txtSasanidTuan.Text;
                sda.SelectCommand.Parameters.Add("KategoriaId", SqlDbType.Int).Value = cmbkat.SelectedValue.ToString();
                sda.SelectCommand.Parameters.Add("SubKategoriaId", SqlDbType.Int).Value = cmbskat.SelectedValue.ToString();
                sda.SelectCommand.Parameters.Add("MarkaId", SqlDbType.Int).Value = cmbmarka.SelectedValue.ToString();
                sda.SelectCommand.Parameters.Add("ModeluId", SqlDbType.Int).Value = cmbmodelu.SelectedValue.ToString();
                sda.SelectCommand.Parameters.Add("observasaun", SqlDbType.VarChar).Value = txtobservasaun.Text.Trim();
                sda.SelectCommand.Parameters.Add("kondisaun_sasan", SqlDbType.Int).Value = cmbkondisaun.SelectedValue.ToString();
                sda.SelectCommand.Parameters.Add("Qtd", SqlDbType.Int).Value = txtqtd.Text;
                sda.SelectCommand.Parameters.Add("Presu", SqlDbType.Decimal).Value = txtpresu.Text;
                sda.SelectCommand.Parameters.Add("ArmajenId", SqlDbType.Int).Value = cmbarmajen.SelectedValue.ToString();
                //sda.SelectCommand.Parameters.Add("SasanId", SqlDbType.Int).Value = cmbkat.SelectedValue.ToString();
                //sda.SelectCommand.ExecuteReader();
                // LoadSasanTama();
                //btnReset.PerformClick();
                sda.SelectCommand.ExecuteNonQuery();
                btnReset.PerformClick();
                MessageBox.Show("Dadus Suceisu Update Ona");
                con.Close();
            }
            
            }
        private void loadsasantama()
        {
            //KoneksaunDb con = new KoneksaunDb();
            //SqlDataAdapter sda = new SqlDataAdapter("usp_T_SasanTama_View", con.Koneksaun());
            //sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
        }

        private void loadsupplier()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Supplier_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbsupplier.DisplayMember = "Naran";
            cmbsupplier.ValueMember = "Id";
            cmbsupplier.DataSource = dt;
        }
        private void loadkategori()
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
        private void loadsubkategori()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_SubKategoria_ViewID", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("kategoriaId", SqlDbType.Int).Value = txtkatid.Text;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select SubKategoria--" };
            dt.Rows.InsertAt(dr, 0);
            cmbskat.DisplayMember = "SUB KATEGORIA";
            cmbskat.ValueMember = "ID";
            cmbskat.DataSource = dt;
            cmbmarka.Text = "";
        }
        private void LoadMarka()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Marka_ViewID", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("subkategoriaId", SqlDbType.Int).Value = txtskatid.Text;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbmarka.DisplayMember = "MARKA";
            cmbmarka.ValueMember = "ID";
            cmbmarka.DataSource = dt;
            cmbmodelu.Text = "";
        }
        private void LoadModelu()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Modelu_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
           // sda.SelectCommand.Parameters.Add("MarkaId", SqlDbType.Int).Value = txtmarkaid.Text;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbmodelu.DisplayMember = "MODELU";
            cmbmodelu.ValueMember = "ID";
            cmbmodelu.DataSource = dt;
        }
        private void loadkondisaun()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_kondisaunSasan_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "" };
            dt.Rows.InsertAt(dr, 0);
            cmbkondisaun.DisplayMember = "KONDISAUN_SASAN";
            cmbkondisaun.ValueMember = "ID";
            cmbkondisaun.DataSource = dt;
        }
        private void loadarmajen()
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

        private void btnTaka_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbkat_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtkatid.Text = cmbkat.SelectedValue.ToString();
            loadsubkategori();

        }

        private void cmbskat_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtskatid.Text = cmbskat.SelectedValue.ToString();
            LoadMarka();

        }

        private void cmbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmarkaid.Text = cmbmarka.SelectedValue.ToString();
            LoadModelu();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbsupplier.Text = "";
            cmbkat.Text = "";
            cmbskat.Text = "";
            cmbmarka.Text = "";
            cmbmodelu.Text = "";
            cmbkondisaun.Text = "";
            txtobservasaun.Text = "";
            txtqtd.Text = "";
            txtpresu.Text = "";
            txttotal.Text = "";
            cmbarmajen.Text = "";
            btnaltera.Enabled = true;
            //btndelete.Enabled = false;
            btnaltera.Text = "Altera";
            txtid.Text = "";
            txtctrl.Text = "0";
            //txtSasanidTuan.Text = "";
            txtctrl.Visible = false;
            txtid.Visible = false;
            dateTimePicker1.Focus();

        }

        private void txtpresu_TextChanged(object sender, EventArgs e)
        {
            if (txtpresu.Text.Length > 0 && txtqtd.Text.Length > 0)
            {
                txttotal.Text = (Convert.ToInt32(txtqtd.Text) * Convert.ToDecimal(txtpresu.Text)).ToString();
            }
            else if (txtpresu.Text.Length > 0 && txtqtd.Text.Length == 0)
            {
                txttotal.Text = txtpresu.Text;
            }
            else if (txtqtd.Text.Length > 0 && txtpresu.Text.Length == 0)
            {
                txttotal.Text = txtqtd.Text;
            }
            else if (txtqtd.Text.Length == 0 && txtpresu.Text.Length == 0)
            {
                txttotal.Text = "0";
            }
            }
        }
}
