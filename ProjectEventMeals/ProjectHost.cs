using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEventMeals
{
    public partial class ProjectHost : Form
    {
        string ConnectionString = "data source=localhost\\SQLEXPRESS; initial catalog=Event_Meals; Integrated Security=true;";
        public SqlConnection connection;
        public ProjectHost()
        {
            InitializeComponent();
            connection = new SqlConnection(ConnectionString);
        }
        public bool connect()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }
        private string sendDetails(string category)
        {
            if (!connect())
                return "החיבור לא הצליח";
            string insert = "declare @answer varchar(100)\r\n\r\nif not exists(select * from Categories where category_name=@category_name)\r\n\tbegin\r\n\t\tinsert into Categories values(@category_name)\r\n\t\tselect @answer = 'קטגוריה נוספה בהצלחה'\r\n\tend\r\nelse\r\n\tbegin\r\n\t\tselect @answer = 'קטגוריה כבר קיימת'\r\n\tend\r\n\r\nselect @anwser";
            SqlCommand cmd = new SqlCommand(insert, connection);

            cmd.Parameters.AddWithValue("@category_name", category);
            string answer = cmd.ExecuteScalar().ToString();
            connection.Close();
            return answer;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
