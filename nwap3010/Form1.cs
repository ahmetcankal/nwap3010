
using System.Data.SqlClient;

namespace nwap3010
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string constr = "Data Source=10.10.88.248;Initial Catalog=dbnwind;Persist Security Info=True;User ID=sa;Password=sanane";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
           con=new SqlConnection(constr);
           con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"insert into Products(ProductName) values('{txturunad.Text.ToString()}')";   
            cmd.ExecuteNonQuery();

            con.Close();




        }



    }
}