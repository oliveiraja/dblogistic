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
    public partial class Frmpatrimon : Form
    {
        public Frmpatrimon()
        {
            InitializeComponent();
            LoadDepartemento();
            Loadkategori();
            //LoadSubkategoria();
            //LoadMarka();
            //LoadModelu();
             Loadpatrimoni();
            Loadarmajen();
            txtid.Visible = false;
            txtctrl.Visible = false;
           txtctrl.Text = "0";
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
        private void Loadpatrimoni()
        {
            KoneksaunDb con = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Sasanpatrimoni_View", con.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dvgpatrimoni.DataSource = dt;
            dvgpatrimoni.BorderStyle = BorderStyle.None;
            dvgpatrimoni.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dvgpatrimoni.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dvgpatrimoni.DefaultCellStyle.SelectionBackColor = Color.Black;
            dvgpatrimoni.BackgroundColor = Color.WhiteSmoke;
            dvgpatrimoni.EnableHeadersVisualStyles = false;
            dvgpatrimoni.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dvgpatrimoni.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dvgpatrimoni.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        private void Loadkategori()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Kategoria_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "" };
            dt.Rows.InsertAt(dr, 0);
            cmbkat.DisplayMember = "KATEGORIA";
            cmbkat.ValueMember = "ID";
            cmbkat.DataSource = dt;
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
            dr.ItemArray = new object[] { 0, "" };
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
            cmbmodelu.DisplayMember = "MODELU";
            cmbmodelu.ValueMember = "ID";
            cmbmodelu.DataSource = dt;
        }
        private void Loadarmajen()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtnomatrikula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtobservasaun_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtfontes_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbkat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbskat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTaka_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            txtnobarcode.Text = "";
           txtdescrisaun.Text = "";
            txtnomatrikula.Text = "";
            txtnomesin.Text = "";
            txtnoserial.Text = "";
            txtfontes.Text = "";
            cmbdeparatmento.Text = "";
            txtnaranutilizador.Text = "";
            cmbarmajen.Text = "";
            txtobservasaun.Text = "";
            btnrai.Enabled = true;
            btnrai.Text = "Save";
            txtid.Text = "";
            txtctrl.Text = "0";
            txtctrl.Visible = false;
            txtid.Visible = false;
            tinanmanufactur.Focus();
        }

        private void btnrai_Click(object sender, EventArgs e)
        {
            if (cmbdeparatmento.Text != "" || txtnobarcode.Text != ""   || txtdescrisaun.Text != "" || txtnoserial.Text != ""
                || txtfontes.Text != "" || tinanmanufactur.Text != "" || txtnaranutilizador.Text != "" || txtobservasaun.Text != "" || txtkodigo.Text != "")

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
            SqlDataAdapter sda = new SqlDataAdapter("usp_Transporte_Insert", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
          //  sda.SelectCommand.Parameters.Add("Data_Tama", SqlDbType.Date).Value = tinanmanufactur.Value;
            sda.SelectCommand.Parameters.Add("Kodigo", SqlDbType.Int).Value = txtkodigo.Text;
            sda.SelectCommand.Parameters.Add("Nobarcode", SqlDbType.VarChar).Value = txtnobarcode.Text;
            sda.SelectCommand.Parameters.Add("Descrisaun", SqlDbType.VarChar).Value = txtdescrisaun.Text;
            sda.SelectCommand.Parameters.Add("Nomatrikula", SqlDbType.VarChar).Value = txtnomatrikula.Text;
            sda.SelectCommand.Parameters.Add("KategoriaId", SqlDbType.Int).Value = cmbkat.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("SubkategoriaId", SqlDbType.Int).Value = cmbskat.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("MarkaId", SqlDbType.Int).Value = cmbmarka.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("ModeluId", SqlDbType.Int).Value = cmbmodelu.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("Nomesin", SqlDbType.VarChar).Value = txtnomesin.Text;
            sda.SelectCommand.Parameters.Add("Noserial", SqlDbType.VarChar).Value = txtnoserial.Text;
            sda.SelectCommand.Parameters.Add("Fontes", SqlDbType.VarChar).Value = txtfontes.Text;
            sda.SelectCommand.Parameters.Add("tinan_produsan", SqlDbType.Date).Value = tinanmanufactur.Value;
            sda.SelectCommand.Parameters.Add("DepartamentoId", SqlDbType.Int).Value = cmbdeparatmento.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("naran_utilizador", SqlDbType.VarChar).Value = txtnaranutilizador.Text;
           sda.SelectCommand.Parameters.Add("aramajenId", SqlDbType.Int).Value = cmbarmajen.SelectedValue.ToString();
           
            sda.SelectCommand.ExecuteReader();
            //MessageBox.Show(msg.Value.ToString());
            Loadpatrimoni();
            btnReset.PerformClick();
        }

        private void btnpatrimoni_Click(object sender, EventArgs e)
        {
            DAL.cek = 0;
            Frmpatrimoni f2 = new Frmpatrimoni();
            f2.Show();
        }

        private void panelfuncionario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void dvgpatrimoni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dvgpatrimoni.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtkodigo.Text = row.Cells[1].Value.ToString();
                txtnobarcode.Text = row.Cells[2].Value.ToString();
                txtkodigo.Text = row.Cells[3].Value.ToString();

                txtdescrisaun.Text = row.Cells[8].Value.ToString();
                txtnomatrikula.Text = row.Cells[9].Value.ToString();
                txtnomesin.Text = row.Cells[11].Value.ToString();
                txtnoserial.Text = row.Cells[12].Value.ToString();
                txtfontes.Text = row.Cells[13].Value.ToString();
               // tinanmanufactur.Text = row.Cells[14].Value.ToString();
                cmbdeparatmento.Text = row.Cells[15].Value.ToString();
                txtnaranutilizador.Text = row.Cells[16].Value.ToString();
              //  cmbarmajen.Text = row.Cells[17].Value.ToString();
                //txtobservasaun.Text = row.Cells[18].Value.ToString();

                txtctrl.Text = "1";
                // btndelete.Enabled = true;
                btnrai.Text = "Update";


            }

        }

        private void cmbkat_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtkatid.Text = cmbkat.SelectedValue.ToString();
            LoadSubKategoria();
        }

        private void cmbskat_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtskatid.Text = cmbskat.SelectedValue.ToString();
            LoadMarka();
        }

        private void cmbmarka_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtmarkaid.Text = cmbmarka.SelectedValue.ToString();
            LoadModelu();
        }

        private void tinanmanufactur_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

                    
                

