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
    public partial class Frmcek : Form
    {
        public Frmcek()
        {
            InitializeComponent();

            LoadKategoria();
            //LoadSubKategoria();
          //  LoadMarka();
            // LoadModelu();
            txtSasanidTuan.Visible = false;
            LoadSasancek();
            txtid.Visible = false;
            txtctrl.Visible = false;
            txtctrl.Text = "0";
            btnReset.PerformClick();

        }
        private void LoadSasancek()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Cek_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);


        }

        private void btnrai_Click(object sender, EventArgs e)
        {
            if (txtkodigo.Text != "" || txtnobarcode.Text != "" || txtdescrisaun.Text != "" || cmbkat.Text != "" || cmbskat.Text != "" || cmbmarka.Text != "" || cmbmodelu.Text != "")
            {
                if (txtctrl.Text == "0")
                {
                    Savesasan();
                }
                else
                {
                    //  Updatesasan();
                }
            }

            else
            {
                MessageBox.Show("Prienxe informasaun molok rai dados!");


            }
 


            }
        private void LoadKategoria()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Kategoria_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
           // sda.SelectCommand.Parameters.Add("Kodigo", SqlDbType.Int).Value = txtkodigo.Text;
            DataTable dt = new DataTable();
            sda.Fill(dt);

            cmbkat.DisplayMember = "KATEGORIA";
            cmbkat.ValueMember = "ID";
            cmbkat.DataSource = dt;
        }
        private void LoadSubKategoria()
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
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Modelu_ViewID", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("MarkaId", SqlDbType.Int).Value = txtmarkaid.Text;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbmodelu.DisplayMember = "MODELU";
            cmbmodelu.ValueMember = "ID";
            cmbmodelu.DataSource = dt;

        }




        private void Savesasan()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("Usp_T_cek_Insert", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("Kodigo", SqlDbType.Int).Value = txtkodigo.Text;
            sda.SelectCommand.Parameters.Add("Nobarcode", SqlDbType.VarChar).Value = txtnobarcode.Text;
            sda.SelectCommand.Parameters.Add("Descrisaun", SqlDbType.VarChar).Value = txtdescrisaun.Text;
            sda.SelectCommand.Parameters.Add("Noserial", SqlDbType.VarChar).Value = txtdescrisaun.Text;
            sda.SelectCommand.Parameters.Add("KategoriaId", SqlDbType.Int).Value = cmbkat.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("SubkategoriaId", SqlDbType.Int).Value = cmbskat.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("MarkaId", SqlDbType.Int).Value = cmbmarka.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("ModeluId", SqlDbType.Int).Value = cmbmodelu.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("Compname", SqlDbType.VarChar).Value = Environment.MachineName;
            sda.SelectCommand.Parameters.Add("IpComp", SqlDbType.VarChar).Value = DAL.GetIPAddress();
            sda.SelectCommand.Parameters.Add("Nomesin", SqlDbType.VarChar).Value = txtnomesin.Text;
            sda.SelectCommand.Parameters.Add("Nomatrikula", SqlDbType.VarChar).Value = txtnomatrikula.Text;
            sda.SelectCommand.Parameters.Add("Utilizador", SqlDbType.VarChar).Value = txtnaranutilizador.Text;
            sda.SelectCommand.ExecuteReader();
            LoadSasancek();
            btnReset.PerformClick();
        }

        private void cmbkat_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtkatid.Text = cmbkat.SelectedValue.ToString();
            LoadSubKategoria();

            
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

        private void btnTaka_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtkodigo.Text = "";
            txtnobarcode.Text = "";
            txtdescrisaun.Text = "";
            txtserialnumber.Text = "";
            
            cmbkat.Text = "";
            cmbskat.Text = "";
            cmbmarka.Text = "";
            cmbmodelu.Text = "";
            txtnomatrikula.Text = "";
            txtnomesin.Text = "";
            txtnaranutilizador.Text = "";
            
            btnrai.Enabled = true;
            //btndelete.Enabled = false;
            btnrai.Text = "Save";
            txtid.Text = "";
            txtctrl.Text = "0";
            //txtSasanidTuan.Text = "";
            txtctrl.Visible = false;
            txtid.Visible = false;
            
        }
    }
    }

