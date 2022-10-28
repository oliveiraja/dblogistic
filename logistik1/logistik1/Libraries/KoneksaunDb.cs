using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace logistik1
{
    public class KoneksaunDb
    {
        SqlConnection Kon = new SqlConnection("Data source=JARRANHADO-PC\\SQLEXPRESSCUSTOM; Initial Catalog=lisdb; User ID=sa; Password=53cuR3d1n55");
     // SqlConnection Kon = new SqlConnection("Data source=JOSEARRANHADO\\SQLEXPRESS;Initial Catalog = lisdb; integrated security = true");

        public SqlConnection Koneksaun()
        {
            if (Kon.State == ConnectionState.Closed)
            {
                Kon.Open();
            }
            return Kon;
        }
    }
}
