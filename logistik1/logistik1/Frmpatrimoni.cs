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
using System.Runtime.InteropServices;

namespace logistik1
{
    public partial class Frmpatrimoni : Form
    {
        public Frmpatrimoni()
        {
            InitializeComponent();
            LoadDepartemento();
            Loadkategori();
            Loadkondisaunsasan();
            //  LoadSubkategori();
            //Loadmarka
            // LoadModelu();
            txtid.Visible = false;
            txtctrl.Visible = false;
            // txtsasanidtuan.Visible = false;
            txtctrl.Text = "0";
            Loadpatrimoni();
            btnReset.PerformClick();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private void LoadDepartemento()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Departemento_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "" };
            dt.Rows.InsertAt(dr, 0);
            cmbdeparatmento.DisplayMember = "Naran";
            cmbdeparatmento.ValueMember = "Id";
            cmbdeparatmento.DataSource = dt;
        }
        private void Loadkategori()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Kategoria_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //DataRow dr;
            //dr = dt.NewRow();
            //dr.ItemArray = new object[] { 0, "" };
            //dt.Rows.InsertAt(dr, 0);
            cmbkat.DisplayMember = "KATEGORIA";
            cmbkat.ValueMember = "ID";
            cmbkat.DataSource = dt;
        }
        private void Loadpatrimoni()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Sasanpatrimoni_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
        
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
            dr.ItemArray = new object[] { 0, "" };
            dt.Rows.InsertAt(dr, 0);
            cmbskat.DisplayMember = "SUB KATEGORIA";
            cmbskat.ValueMember = "ID";
            cmbskat.DataSource = dt;
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
            cmbmodelu.Text = "";
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
            cmbmodelu.DisplayMember = "MODELU";
            cmbmodelu.ValueMember = "ID";
            cmbmodelu.DataSource = dt;
        }
        private void Loadkondisaunsasan()
        {
            //KoneksaunDb kon = new KoneksaunDb();
            //SqlDataAdapter sda = new SqlDataAdapter("usp_T_kondisaunSasan_View", kon.Koneksaun());
            //sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //DataRow dr;
            //dr = dt.NewRow();
            //dr.ItemArray = new object[] { 0, "" };
            //dt.Rows.InsertAt(dr, 0);
            //cmbkondisaun.DisplayMember = "KONDISAUN_SASAN";
            //cmbkondisaun.ValueMember = "ID";
            //cmbkondisaun.DataSource = dt;

        }

        private void btnrai_Click(object sender, EventArgs e)
        {
            if (cmbdeparatmento.Text != "" || txtkodigo.Text != ""||  txtnobarcode.Text!=""|| cmbkat.Text != "" || cmbskat.Text != "" || cmbmarka.Text != "" || cmbmodelu.Text != "" ||   txtdescrisaun.Text != ""  || txtkodigo.Text!=""
                ||txtfontes.Text!=""|| datetinanprodusan.Text!="" || txtqtd.Text!="")
               
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
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Sasanpatrimoni_Insert", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("Data_Tama", SqlDbType.Date).Value = dateTimePicker1.Value;
            sda.SelectCommand.Parameters.Add("Kodigo", SqlDbType.Int).Value = txtkodigo.Text;
            sda.SelectCommand.Parameters.Add("Nobarcode", SqlDbType.VarChar).Value = txtnobarcode.Text;
            sda.SelectCommand.Parameters.Add("Descrisaun", SqlDbType.VarChar).Value = txtdescrisaun.Text;
            sda.SelectCommand.Parameters.Add("Noserial", SqlDbType.VarChar).Value = txtkodigo.Text;
            sda.SelectCommand.Parameters.Add("Fontes", SqlDbType.VarChar).Value = txtfontes.Text;
            sda.SelectCommand.Parameters.Add("tinan_produsan", SqlDbType.Date).Value = datetinanprodusan.Value;
           // sda.SelectCommand.Parameters.Add("kondisaun_sasan", SqlDbType.Int).Value = cmbkondisaun.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("DepartamentoId", SqlDbType.Int).Value = cmbdeparatmento.SelectedValue.ToString();
           // sda.SelectCommand.Parameters.Add("naran_utilizador", SqlDbType.VarChar).Value = txtnaranutilizador.Text;
            sda.SelectCommand.Parameters.Add("KategoriaId", SqlDbType.Int).Value = cmbkat.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("SubKategoriaId", SqlDbType.Int).Value = cmbskat.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("MarkaId", SqlDbType.Int).Value = cmbmarka.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("ModeluId", SqlDbType.Int).Value = cmbmodelu.SelectedValue.ToString();
            //sda.SelectCommand.Parameters.Add("observasaun", SqlDbType.VarChar).Value = txtobservasaun.Text;
            sda.SelectCommand.Parameters.Add("Qtd", SqlDbType.Int).Value = txtqtd.Text;
          //  SqlParameter msg = sda.SelectCommand.Parameters.Add("msg", SqlDbType.VarChar, 100);
          //  msg.Direction = ParameterDirection.Output;
            sda.SelectCommand.ExecuteReader();
            //MessageBox.Show(msg.Value.ToString());
            Loadpatrimoni();
            btnReset.PerformClick();
        }

        private void cmbkat_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtkatid.Text = cmbkat.SelectedValue.ToString();
            LoadSubkategori();

        }

        private void cmbskat_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtskatid.Text = cmbskat.SelectedValue.ToString();
            Loadmarka();

        }

        private void cmbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmarkaid.Text = cmbmarka.SelectedValue.ToString();
            Loadmodelu();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //cmbarmajen.Text = "";
            dateTimePicker1.Text = "";
            txtnobarcode.Text = "";
            cmbkat.Text = "";
            cmbskat.Text = "";
            cmbmarka.Text = "";
            cmbmodelu.Text = "";
            txtdescrisaun.Text = "";
            txtkodigo.Text = "";
            txtfontes.Text = "";
           // txtnaranutilizador.Text = "";
            cmbdeparatmento.Text = "";
           // cmbkondisaun.Text = "";
           // txtobservasaun.Text = "";
            txtqtd.Text = "";
            btnrai.Enabled = true;

            btnrai.Text = "Save";
            txtid.Text = "";
            txtctrl.Text = "0";
            txtctrl.Visible = false;
            txtid.Visible = false;
            datetinanprodusan.Focus();
        }

        private void btnTaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnltitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

    }

