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

namespace logistik1
{
    public partial class Form_armajenstock : Form
    {
        public Form_armajenstock()
        {
            InitializeComponent();
            LoadArmajenStock();
        }

        //method load ArmajenStock
        private void LoadArmajenStock()
        {
            KoneksaunDb kon = new KoneksaunDb();
            SqlDataAdapter sda = new SqlDataAdapter("usp_T_ArmajenStock_View", kon.Koneksaun());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvsasan.DataSource = dt;
        }

        private void dgvsasan_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            LoadArmajenStock();
        }
    }
}
