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
//using System.Xml.Schema;
using System.IO;
using System.Runtime.InteropServices;
using System.Configuration;
//using System.IO;

namespace logistik1
{
    // ErrorProvider epSS = new ErrorProvider();
    public partial class Form_sasantama : Form
    {

        public Form_sasantama()
        {
            InitializeComponent();
            LoadSupplier();
            //LoadKategoria();
            //LoadSubKategoria();
            //LoadMarka();
            //LoadModelu();
            txtSasanidTuan.Visible = false;
            LoadArmajen();
            Loadkondisaun();
            LoadSasanTama();
            btnReset.PerformClick();
        }

        //method load supplier
        private void LoadSupplier()
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

        
        private void LoadKategoria()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_Kategoria_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            //sda.SelectCommand.Parameters.Add("Kodigo", SqlDbType.Int).Value = txtkodigo.Text;
            DataTable dt = new DataTable();
            sda.Fill(dt);

            cmbkat.DisplayMember = "KATEGORIA";
            cmbkat.ValueMember = "ID";
            cmbkat.DataSource = dt;


        }

        //method load subkategoria
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

        //method load Marka
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

        //method load Modelu
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
        private void Loadkondisaun()
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
        private void LoadSasanTama()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_SasanTama_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            // dgvsasan.DataSource = dt;
            //Columns[12].Visible = false;
        }

        //method save sasan
        private void SaveSasan()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_SasanTama_Insert", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("Data_Tama", SqlDbType.Date).Value = dateTimePicker1.Value;
            sda.SelectCommand.Parameters.Add("SupplierId", SqlDbType.Int).Value = cmbsupplier.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("Kodigo", SqlDbType.Int).Value = txtkodigo.Text;
            sda.SelectCommand.Parameters.Add("KategoriaId", SqlDbType.Int).Value = cmbkat.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("SubKategoriaId", SqlDbType.Int).Value = cmbskat.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("MarkaId", SqlDbType.Int).Value = cmbmarka.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("ModeluId", SqlDbType.Int).Value = cmbmodelu.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("observasaun", SqlDbType.VarChar).Value = txtobservasaun.Text;
            sda.SelectCommand.Parameters.Add("kondisaun_sasan", SqlDbType.Int).Value = cmbkondisaun.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("Qtd", SqlDbType.Int).Value = txtqtd.Text;
            //sda.SelectCommand.Parameters.Add("Id", SqlDbType.Int).Value = lbl3
            sda.SelectCommand.Parameters.Add("Presu", SqlDbType.Decimal).Value = txtpresu.Text;
            sda.SelectCommand.Parameters.Add("ipcomp", SqlDbType.VarChar).Value = DAL.GetIPAddress();
            sda.SelectCommand.Parameters.Add("compname", SqlDbType.VarChar).Value = Environment.MachineName;
            sda.SelectCommand.Parameters.Add("ArmajenId", SqlDbType.Int).Value = cmbarmajen.SelectedValue.ToString();
            sda.SelectCommand.ExecuteReader();
            LoadSasanTama();
            btnReset.PerformClick();
        }

        //method update sasan
        private void UpdateSasan()
        {
            //    KoneksaunDb kon = new KoneksaunDb();
            //    SqlDataAdapter sda = new SqlDataAdapter("usp_T_Sasantama_UpdateE", kon.Koneksaun());
            //    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            //    sda.SelectCommand.Parameters.Add("Id", SqlDbType.Int).Value = txtid.Text;
            //    sda.SelectCommand.Parameters.Add("Data_Tama", SqlDbType.Date).Value = dateTimePicker1.Value;
            //    sda.SelectCommand.Parameters.Add("SupplierId", SqlDbType.Int).Value = cmbsupplier.SelectedValue.ToString();
            //    //sda.SelectCommand.Parameters.Add("sasanID", SqlDbType.Int).Value = txtSasanidTuan.Text;
            //    sda.SelectCommand.Parameters.Add("KategoriaId", SqlDbType.Int).Value = cmbkat.SelectedValue.ToString();
            //    sda.SelectCommand.Parameters.Add("SubKategoriaId", SqlDbType.Int).Value = cmbskat.SelectedValue.ToString();
            //    sda.SelectCommand.Parameters.Add("MarkaId", SqlDbType.Int).Value = cmbmarka.SelectedValue.ToString();
            //    sda.SelectCommand.Parameters.Add("ModeluId", SqlDbType.Int).Value = cmbmodelu.SelectedValue.ToString();
            //    //sda.SelectCommand.Parameters.Add("observasaun", SqlDbType.VarChar).Value = txtobservasaun.Text.Trim();
            //    sda.SelectCommand.Parameters.Add("kondisaun_sasan", SqlDbType.VarChar).Value = cmbkondisaun.Text.Trim();
            //    sda.SelectCommand.Parameters.Add("Qtd", SqlDbType.Int).Value = txtqtd.Text;
            //    sda.SelectCommand.Parameters.Add("Presu", SqlDbType.Decimal).Value = txtpresu.Text;
            //    sda.SelectCommand.Parameters.Add("ArmajenId", SqlDbType.Int).Value = cmbarmajen.SelectedValue.ToString();
            //    //sda.SelectCommand.Parameters.Add("SasanId", SqlDbType.Int).Value = cmbkat.SelectedValue.ToString();
            //    //sda.SelectCommand.ExecuteReader();
            //    LoadSasanTama();
            //    btnReset.PerformClick();
        }

        //method delete sasan
        private void DeleteSasan()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_SasanTama_Delete", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("id", SqlDbType.Int).Value = txtid.Text;
            sda.SelectCommand.Parameters.Add("sasanId", SqlDbType.Int).Value = cmbkat.SelectedValue.ToString();
            sda.SelectCommand.Parameters.Add("armajenID", SqlDbType.Int).Value = cmbarmajen.SelectedValue.ToString();
            sda.SelectCommand.ExecuteReader();
            LoadSasanTama();
            //btncancel.PerformClick();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //if (cmbsupplier.Text != ""  || cmbkat.Text != "" || cmbskat.Text != "" || cmbmarka.Text != "" || cmbmodelu.Text != "" ||txtkondisaun.Text!=""||  txtobservasaun.Text!="" ||    txtqtd.Text != "" || txtpresu.Text != "" || cmbarmajen.Text != "")
            //{
            //    if (txtctrl.Text == "0")
            //    {
            //        SaveSasan();                   
            //    }
            //    else
            //    {
            //        UpdateSasan();                               
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Prienxe informasaun molok rai dados!");
            //}
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            //cmbsupplier.Text = "";
            //cmbkat.Text = "";
            //cmbskat.Text = "";
            //cmbmarka.Text = "";
            //cmbmodelu.Text = "";
            //txtkondisaun.Text = "";
            //txtobservasaun.Text = "";
            //txtqtd.Text = "";
            //txtpresu.Text = "";
            //txttotal.Text = "";
            //cmbarmajen.Text = "";
            //btnsave.Enabled = true;
            //btndelete.Enabled = false;
            //btnsave.Text = "Save"; 
            //txtid.Text = "";
            //txtctrl.Text = "0";
            ////txtSasanidTuan.Text = "";
            //txtctrl.Visible = false;
            //txtid.Visible = false;
            //dateTimePicker1.Focus();
        }

        private void Form_sasantama_Load(object sender, EventArgs e)
        {
            btnReset.PerformClick();
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
                btnReset.PerformClick();
            }
        }

        private void dgvsasan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (e.RowIndex >= 0)
            //{

            //    DataGridViewRow row = this.dgvsasan.Rows[e.RowIndex];
            //    txtid.Text = row.Cells[0].Value.ToString();
            //    dateTimePicker1.Value=Convert.ToDateTime(row.Cells[1].Value.ToString());
            //    cmbsupplier.Text = row.Cells[2].Value.ToString();
            //    //cmbsasan.Text = row.Cells[3].Value.ToString();
            //    cmbkat.Text = row.Cells[3].Value.ToString();
            //    cmbskat.Text = row.Cells[4].Value.ToString();
            //    cmbmarka.Text = row.Cells[5].Value.ToString();
            //    cmbmodelu.Text = row.Cells[6].Value.ToString();
            //    txtobservasaun.Text = row.Cells[7].Value.ToString();
            //    txtkondisaun.Text = row.Cells[8].Value.ToString();
            //    txtqtd.Text = row.Cells[9].Value.ToString();
            //    txtpresu.Text = row.Cells[10].Value.ToString();
            //    txttotal.Text = row.Cells[11].Value.ToString();
            //    cmbarmajen.Text = row.Cells[12].Value.ToString();
            //    //txtSasanidTuan.Text = row.Cells[11].Value.ToString();
            //    txtctrl.Text = "1";
            //    btndelete.Enabled = true;
            //    btnsave.Text = "Update";
            //  //  dgvsasan.DataSource = dt;
            //    dgvsasan.BorderStyle = BorderStyle.None;
            //    dgvsasan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            //    dgvsasan.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //    dgvsasan.DefaultCellStyle.SelectionBackColor = Color.Black;
            //    dgvsasan.BackgroundColor = Color.WhiteSmoke;
            //    dgvsasan.EnableHeadersVisualStyles = false;
            //    dgvsasan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //    dgvsasan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            //    dgvsasan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }

        private void txtpresu_KeyPress(object sender, KeyPressEventArgs e)
        {

            //  e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'); 

        }

        private void cmbsupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbsasan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void cmbarmajen_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txttotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnref_Click(object sender, EventArgs e)
        {
            //LoadSasanTama();
        }

        private void cmbsasan_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                int KategoriaId = Convert.ToInt32(cmbkat.SelectedValue.ToString());
                LoadSubKategoria();

            }
        }

        private void cmbkat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbskat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbmarka_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbmodelu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtpresu_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbkat_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void cmbskat_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        private void cmbkat_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtkatid.Text = cmbkat.SelectedValue.ToString();
            LoadSubKategoria();

        }

        private void cmbmarka_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtpresu_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
        }

        private void btnrai_Click_1(object sender, EventArgs e)
        {

        }

        private void txtpresu_TextChanged_2(object sender, EventArgs e)
        {


        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbkat_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            txtkatid.Text = cmbkat.SelectedValue.ToString();
            LoadSubKategoria();
        }

        private void cmbskat_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void cmbmarka_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void cmbkat_SelectedIndexChanged_3(object sender, EventArgs e)
        {
            txtkatid.Text = cmbkat.SelectedValue.ToString();
            LoadSubKategoria();
        }

        private void cmbskat_SelectedIndexChanged_3(object sender, EventArgs e)
        {
            txtskatid.Text = cmbskat.SelectedValue.ToString();
            LoadMarka();
        }

        private void cmbmarka_SelectedIndexChanged_3(object sender, EventArgs e)
        {
            txtmarkaid.Text = cmbmarka.SelectedValue.ToString();
            LoadModelu();
        }

        private void btnTaka_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click_2(object sender, EventArgs e)
        {
            txtkodigo.Text = "";
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
            btnrai.Enabled = true;
            //btndelete.Enabled = false;
            btnrai.Text = "Save";
            txtid.Text = "";
            txtctrl.Text = "0";
            //txtSasanidTuan.Text = "";
            txtctrl.Visible = false;
            txtid.Visible = false;
            dateTimePicker1.Focus();
        }

        private void btnrai_Click_2(object sender, EventArgs e)
        {
            if (cmbsupplier.Text != "" || cmbkat.Text != "" || cmbskat.Text != "" || cmbmarka.Text != "" || cmbmodelu.Text != "" || cmbkondisaun.Text != "" || txtqtd.Text != "" || txtpresu.Text != "" || cmbarmajen.Text != "" || txtobservasaun.Text != "")
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

        private void txtpresu_TextChanged_3(object sender, EventArgs e)
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

        private void txtkodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtkodigo.Text))
                {
                    MessageBox.Show("Dadus Refere existi Ona Iha Sistema");
                }
                int checkInt;
                if (!int.TryParse(txtkodigo.Text, out checkInt))
                {
                    MessageBox.Show("Halo Favor Ferevika");
                }
                else
                {

                    {
                        List<SqlParameter> sqlParams = new List<SqlParameter>();
                        sqlParams.Add(new SqlParameter("Kodigo", txtkodigo.Text));

                        DataTable dtx = DAL.ExecSP("usp_sasantamaCHECK", sqlParams);
                        if (dtx.Rows.Count > 0)
                        {

                            {
                              //   txtkodigo.Text = dtx.Rows[0]["Kodigo"].ToString();

                                LoadKategoria();
                                cmbkat.SelectedValue = int.Parse(dtx.Rows[0]["KategoriaId"].ToString());
                                LoadSubKategoria();
                                cmbskat.SelectedValue = int.Parse(dtx.Rows[0]["SubKategoriaId"].ToString());
                                LoadMarka();
                                cmbmarka.SelectedValue = int.Parse(dtx.Rows[0]["MarkaId"].ToString());
                               LoadModelu();
                                cmbmodelu.SelectedValue = int.Parse(dtx.Rows[0]["ModeluId"].ToString());

                            }


                        }
                    }
                }
            }
        }




        private void txtkodigo_Leave(object sender, EventArgs e)
        {
            //List<SqlParameter> sqlParams = new List<SqlParameter>();
            //sqlParams.Add(new SqlParameter("Kodigo", txtkodigo.Text));
            //DataTable dt = DAL.ExecSP("usp_transporteCHECK", sqlParams);
            //if (dt.Rows.Count > 0)
            //{
            //    // MessageBox.Show(DAL.GetString("00021210"), DAL.GetString("0002082"));
            //    // epSS.SetError(this.txtkodigo, DAL.GetString("0002080"));
            //}
            //else
            //{
            //    // epSS.Clear();
            //}
            }
    }
}

    



