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
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Sockets;


namespace logistik1
{
    public partial class Frmlogin : Form
    {
        SqlConnection con = new SqlConnection("Data source = DIVA; Initial Catalog = lisdb; integrated security = true");

        //  SqlConnection Kon = new SqlConnection("Data source=DIVAANDRADE;Initial Catalog=LIS;user=user1;password=53cuR3dadmin3");
        //  public static Menu mdbj;
        // public string connectionString;
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtemail.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Please fill the username or pssword");
                txtemail.Focus();
            }
            else
            {

                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("email", txtemail.Text));
              //  sqlParams.Add(new SqlParameter("uPwd", ByteConverter.GetString(encryptedData)));
                sqlParams.Add(new SqlParameter("uPwd", DAL.Encrypt(txtpassword.Text)));
                DataTable dt = DAL.ExecSP("usp_tusersVALIDATE", sqlParams);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["funsaun"].ToString() == "admin")
                        {
                            MessageBox.Show("Login Sucesu! Bem Vindo ba Sistema!");
                            Frmindex admin = new Frmindex();
                            {

                                admin.btnsasantama.Visible = true;
                                admin.btnatk.Visible = true;
                                admin.btnpatrimoni.Visible = true;
                               // admin.btnTraballador.Visible = true;

                                admin.btnparametrus.Visible = true;
                                admin.btnutilizador.Visible = true;
                                
                            }
                            admin.Show();
                            this.Hide();
                            con.Close();
                        }
                        if (dr["funsaun"].ToString() == "client")
                        {
                            MessageBox.Show("Login Success! Welcome User!");
                            Frmindex client = new Frmindex();
                            {
                                client.btnsasantama.Visible = true;
                                client.btnatk.Visible = false;
                                client.btnpatrimoni.Visible = false;
                               // client.btnidentifikasaun.Visible = true;

                                client.btnutilizador.Visible = false;
                                client.btnparametrus.Visible = false;
                            }

                            client.Show();
                            this.Hide();
                            con.Close();

                        }
                        else if (dr["funsaun"].ToString() == "user")
                        {
                            MessageBox.Show("Login Success! Welcome User!");
                            Frmindex user = new Frmindex();
                            {
                                user.btnsasantama.Visible = true;
                                user.btnatk.Visible = true;
                                user.btnpatrimoni.Visible = true;
                                //user.btnidentifikasaun.Visible = true;

                                user.btnutilizador.Visible = false;
                                user.btnparametrus.Visible = false;
                            }

                            user.Show();
                            this.Hide();
                            con.Close();
                        }
                    }
                }
            }


        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {
           // Frmlogin log = new Frmlogin();
            //log.Show();
           //log.MdiParent = this;
           // mdbj = this;

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
                          
                   
            
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
