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
using System.Runtime.InteropServices;

namespace logistik1
{
    
    public partial class listapatrimoni : Form
    {
        public static listapatrimoni frmPs;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        public listapatrimoni()
        {
            InitializeComponent();
            Loadsearch();
            frmPs = this;
        }
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        int LX, LY;
        private void Loadsearch()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_ArmajenStock_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvsasanpatrimoni.DataSource = dt;
            List<SqlParameter> sqlParams = new List<SqlParameter>();
           // sqlParams.Add(new SqlParameter("Total", lblttl.Text));
            // sqlParams.Add(new SqlParameter("linguaId"));
            //  DataTable dt = DAL.ExecSP("usp_T_ArmajenStock_View", sqlParams);
            DataView dv = new DataView(dt);
            //txtnewttl.Text = dt.Parameters["@newNISS"].Value.ToString();
            //lblttl.Text = txtnewttl.Text + "Total" + txtnewttl.Text;
            //lblttl.Visible = true;
            dgvsasanpatrimoni.DataSource = dv;
            dgvsasanpatrimoni.DataSource = dt;
            dgvsasanpatrimoni.BorderStyle = BorderStyle.None;
            dgvsasanpatrimoni.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvsasanpatrimoni.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvsasanpatrimoni.DefaultCellStyle.SelectionBackColor = Color.Black;
            dgvsasanpatrimoni.BackgroundColor = Color.WhiteSmoke;
            dgvsasanpatrimoni.EnableHeadersVisualStyles = false;
            dgvsasanpatrimoni.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvsasanpatrimoni.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvsasanpatrimoni.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void txtseacrh_TextChanged(object sender, EventArgs e)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("Find", txtseacrh.Text));
            // sqlParams.Add(new SqlParameter("linguaId"));
            DataTable dt = DAL.ExecSP("usp_search_Stock ", sqlParams);
            DataView dv = new DataView(dt);
            dgvsasanpatrimoni.DataSource  = dv;

        }

        private void listapatrimoni_Load(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
           // this.aREATableAdapter.fill(this.wATerandPOWERDATASet.Area);
        }

        private void dgvsasanpatrimoni_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbExcel_Click(object sender, EventArgs e)
        {
            Microsoft. Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
          //  worksheet.Name = DAL.GetString("00030") + " - " + DAL.znissee;
            
            


            for (int i = 1; i < dgvsasanpatrimoni.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvsasanpatrimoni.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvsasanpatrimoni.Rows.Count; i++)
            {
                for (int j = 0; j < dgvsasanpatrimoni.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvsasanpatrimoni.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialog = new SaveFileDialog();
             //saveFileDialog.FileName = DAL.GetString("00030") + " - " + DAL.znissee;
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
    }
    }


