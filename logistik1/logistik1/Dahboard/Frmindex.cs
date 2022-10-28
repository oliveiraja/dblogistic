using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;


using System.Net;
using System.Windows.Forms.DataVisualization.Charting;

namespace logistik1
{
    public partial class Frmindex : Form
    {
        public static Frmindex frmPs;
        string maxres = "";
        public Frmindex()

        {
            InitializeComponent();
            frmPs = this;
            CtrlsSira();
            Loadsasan();
            loadDG();
            pnlMenuVertical.Width = 250;
            pictureBox1.Size = new System.Drawing.Size(246, 196);

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        int LX, LY;
        private void btnSlide_Click(object sender, EventArgs e)
        {

        }
        private void Loadsasan()
        {
          //  KoneksaunDb kon = new KoneksaunDb();
          //  SqlDataAdapter sda = new SqlDataAdapter("usp_T_ArmajenStock_View", kon.Koneksaun());
          //  sda.SelectCommand.CommandType = CommandType.StoredProcedure;
          //  DataTable dt = new DataTable();
          //  sda.Fill(dt);
          //  dgvDashboard.DataSource = dt;
          //  List<SqlParameter> sqlParams = new List<SqlParameter>();
          //  sqlParams.Add(new SqlParameter("Total", lblttl.Text));
          //  // sqlParams.Add(new SqlParameter("linguaId"));
          ////  DataTable dt = DAL.ExecSP("usp_T_ArmajenStock_View", sqlParams);
          //  DataView dv = new DataView(dt);
          //  //txtnewttl.Text = dt.Parameters["@newNISS"].Value.ToString();
          //  lblttl.Text = txtnewttl.Text + "Total" + txtnewttl.Text;
          //  lblttl.Visible = true;
          //  dgvDashboard.DataSource = dv;
          //  dgvDashboard.DataSource = dt;
          //  dgvDashboard.BorderStyle = BorderStyle.None;
          //  dgvDashboard.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
          //  dgvDashboard.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
          //  dgvDashboard.DefaultCellStyle.SelectionBackColor = Color.Black;
          //  dgvDashboard.BackgroundColor = Color.WhiteSmoke;
          //  dgvDashboard.EnableHeadersVisualStyles = false;
          //  dgvDashboard.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
          //  dgvDashboard.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
          //  dgvDashboard.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        void loadDG()
        {
            //DataTable dt = DAL.ExecSPx("usp_tusersONLINEE");
            //dgDash.DataSource = dt;
            //dgDash.CellBorderStyle = DataGridViewCellBorderStyle.None;
            //dgDash.Columns[0].HeaderText = DAL.GetString("0001371");
        }

            private void pbMaximize_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            pbRestore.Visible = true;
            pbMaximize.Visible = false;
            maxres = "0";
        }

        private void pbRestore_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1120, 665);
            this.Location = new Point(LX, LY);
            pbRestore.Visible = false;
            pbMaximize.Visible = true;
            maxres = "1";
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnltitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (maxres == "1")
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsasantama_Click(object sender, EventArgs e)
        {
            //paneldashboard.Controls.Clear();
            //Homesasantama fp = new Homesasantama();
            //fp.TopLevel = false;
            //paneldashboard.Controls.Add(fp);
            //fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //fp.Dock = DockStyle.Fill;
            //fp.Show();

            pnlselected_v.Visible = true;


        }

        private void btnsai_Click(object sender, EventArgs e)
        {
            //paneldashboard.Controls.Clear();
            //homeatk fp = new homeatk();
            //fp.TopLevel = false;
            //paneldashboard.Controls.Add(fp);
            //fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //fp.Dock = DockStyle.Fill;
            //fp.Show();
            pnlselected.Visible = true;
          //  btnpatrimoni.Visible = true;

        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnparametrus_Click(object sender, EventArgs e)
        {
            paneldashboard.Controls.Clear();
            Menuparameter fp = new Menuparameter();
            fp.TopLevel = false;
            paneldashboard.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();

        }

        private void btnSlide_Click_1(object sender, EventArgs e)
        {

            if (pnlMenuVertical.Width == 250)
            {
                pnlMenuVertical.Width = 42;
                pictureBox1.Size = new System.Drawing.Size(38, 45);

            }
            else
            {
                pnlMenuVertical.Width = 250;
                pictureBox1.Size = new System.Drawing.Size(247, 178);
            }
        }

        private void pbMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pbRestore_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(1120, 665);
            this.Location = new Point(LX, LY);
            pbRestore.Visible = false;
            pbMaximize.Visible = true;
            maxres = "1";
        }

        private void pbMaximize_Click_1(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            pbRestore.Visible = true;
            pbMaximize.Visible = false;
            maxres = "0";
        }

        private void pbExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnltitle_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (maxres == "1")
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }

        }

        private void btnpatrimoni_Click(object sender, EventArgs e)
        {
            paneldashboard.Controls.Clear();
            homepatrimoni fp = new homepatrimoni();
            fp.TopLevel = false;
            paneldashboard.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();
            //Frmpatrimoni s2 = new Frmpatrimoni();
            //   s2.Show();
            pnlselected.Visible = false;
        }

        private void Frmindex_Load(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            pbRestore.Visible = true;
            pbMaximize.Visible = false;
            maxres = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //paneldashboard.Controls.Clear();
            Frmindex fp = new Frmindex();
            //fp.TopLevel = false;
            //paneldashboard.Controls.Add(fp);
            //fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //fp.Dock = DockStyle.Fill;
            fp.Show();
            Hide();
        }

        private void btnutilizador_Click(object sender, EventArgs e)
        {
            paneldashboard.Controls.Clear();
            Frmautenticatio fp = new Frmautenticatio();
            fp.TopLevel = false;
            paneldashboard.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();
        }

        private void btnatk_Click(object sender, EventArgs e)
        {

            paneldashboard.Controls.Clear();
            h_atk fp = new h_atk();
            fp.TopLevel = false;
            paneldashboard.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();

            pnlselected.Visible = false;
        }

        private void btnsasantama__Click(object sender, EventArgs e)
        {
            paneldashboard.Controls.Clear();
            Homesasantama fp = new Homesasantama();
            fp.TopLevel = false;
            paneldashboard.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();

        }

        private void btnsasansai_Click(object sender, EventArgs e)
        {
            paneldashboard.Controls.Clear();
            Frmmenusai fp = new Frmmenusai();
            fp.TopLevel = false;
            paneldashboard.Controls.Add(fp);
            fp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            fp.Show();
            pnlselected_v.Visible = false;

        }

        void CtrlsSira()
        {

            //string var = DateTime.Now.ToString("tt");
            if (DateTime.Now.Hour < 12)
            {
                //lblUser.Text = DAL.GetString("00010") + ", " + DAL.zuname;
            }
            else if (DateTime.Now.Hour < 17)
            {
                //lblUser.Text = DAL.GetString("00011") + ", " + DAL.zuname;
            }
            else
            {
                //  lblUser.Text = DAL.GetString("00012") + ", " + DAL.zuname;
            }
            //lblReg.Text = DAL.GetString("0001310");
            //lblReg_ltotal.Text = DAL.GetString("0001311");
            //lblSector.Text = DAL.GetString("0001320");
            //lblSector_ltotal.Text = DAL.GetString("0001321");
            //lblGender.Text = DAL.GetString("0001330");
            //lblGender_ltotal.Text = DAL.GetString("0001331");
            //lblNat.Text = DAL.GetString("0001340");
            //lblNat_ltotal.Text = DAL.GetString("0001341");
            //lblOnline.Text = DAL.GetString("0001370");
            //lblasesu.Text = DAL.GetString("000076");
            //lbldesign.Text = "©2018 " + DAL.GetString("000073");
           
            //loadDG();
            chartType();


            void chartType()
            {
                //Employer
                //chartEE.Titles[0].Text = DAL.GetString("0001350");
                //chartEE.Series["Employer"].XValueMember = "EE";
                //chartEE.Series["Employer"].YValueMembers = "Total";
                //chartEE.Series["Employer"].IsValueShownAsLabel = true;
                //chartEE.Series["Employer"].Label = "#PERCENT";
                //chartEE.Series["Employer"].LegendText = "#VALX";
                //List<SqlParameter> sqlParamsx = new List<SqlParameter>();
                ////sqlParamsx.Add(new SqlParameter("lingua", DAL.linguaId));
                //DataTable dt = DAL.ExecSP("usp_getTotalsasantama", sqlParamsx);
                //chartEE.DataSource = dt;
                //chartEE.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                //chartEE.Series[0]["PieLabelStyle"] = "Outside";
                //chartEE.ChartAreas[0].Area3DStyle.Enable3D = true;
                //chartEE.ChartAreas[0].Area3DStyle.Inclination = 10;

            }
        }
   }
    }

