using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;

using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
namespace logistik1
{
    class DAL
    {
        //public static string zsiss;
        //public static string zniss;
        //public static string znissx;
        public static string znissee;
        //public static string zId;
        //public static string zNaran;
        //public static int linguaId;
        public static int cek;
        //public static int cform;
        //public static string zasesu;
        //public static int zlogId;
        //public static int zrole;
        //public static string zuname;
        //public static int zlog;

        public static string strConnect = ("Data source=JARRANHADO-PC\\SQLEXPRESSCUSTOM; Initial Catalog=lisdb; User ID=sa; Password=53cuR3d1n55");
       // public static string strConnect = ("Data source = JOSEARRANHADO\\SQLEXPRESS; Initial Catalog = lisdb; integrated security = true");


        public static DataTable ExecSP(string spName, List<SqlParameter> sqlParams = null)
        {

            SqlConnection conn = new SqlConnection();

            DataTable dt = new DataTable();

            try
            {
                //connect to the database
                conn = new SqlConnection(strConnect);
                conn.Open();

                //build sql command / query 
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(sqlParams.ToArray());

                //execute the command
                SqlCommand command = conn.CreateCommand();
                SqlDataReader dr = cmd.ExecuteReader();

                //fill datatable
                dt.Load(dr);



            }
            catch (Exception ex)
            {
                //throw ex;
            }
            finally
            {
                //no matter what happened this will run
                conn.Close();
            }

            return dt;
        }
        public static string GetIPAddress()
        {
            string ipAddress = null;

            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("127.0.0.1", 65530); //Google public DNS and port
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                ipAddress = endPoint.Address.ToString();
            }

            return ipAddress;
        }



        public static string Encrypt(string encryptString)
        {
            string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";  //we can change the code converstion key as per our requirement    
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }






        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";  //we can change the code converstion key as per our requirement, but the decryption key should be same as encryption key    
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }





        public static Form IsFormAlreadyOpen(Type FormType)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.GetType() == FormType)
                    return OpenForm;
            }

            return null;
        }
    }
}

















