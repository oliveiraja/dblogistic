using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace LIS
{
    public class koneksaun
    {

        SqlConnection kon = new SqlConnection("Data source=DIVAANDRADE10;Initial Catalog=LIS;Integrated Security=true;");
       
        public SqlConnection Activekon()
    {
            if(kon.State==ConnectionState.Closed)
            {
                kon.Open();
            }
            return kon;
    }
    }
}