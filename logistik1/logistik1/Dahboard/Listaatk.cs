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
    public partial class Listaatk : Form
    {
        public static Listaatk frmPs;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        public Listaatk()
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

        private void Listaatk_Load(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }
        private void Loadsearch()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            //sqlParams.Add(new SqlParameter("Find", txtseacrh.Text));
            // sqlParams.Add(new SqlParameter("linguaId"));
            DataTable dt = DAL.ExecSP("usp_T_SasanAtk_View", sqlParams);
            DataView dv = new DataView(dt);
            dgvsasanatk.DataSource = dv;
            dgvsasanatk.DataSource = dt;
            dgvsasanatk.BorderStyle = BorderStyle.None;
            dgvsasanatk.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvsasanatk.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvsasanatk.DefaultCellStyle.SelectionBackColor = Color.Black;
            dgvsasanatk.BackgroundColor = Color.WhiteSmoke;
            dgvsasanatk.EnableHeadersVisualStyles = false;
            dgvsasanatk.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvsasanatk.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvsasanatk.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
    }
}
