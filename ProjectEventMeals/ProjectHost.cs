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
using System.Xml.Linq;

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
            showAllCategories("");
            showAllGuestsSelections();
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
        private void sendDetails(string category)
        {
            if (!connect()) return;
            string insert = "if not exists(select * from Categories where category_name=@category_name)\r\n\tbegin\r\n\t\tinsert into Categories values(@category_name)\r\n\t\tend";
            SqlCommand cmd = new SqlCommand(insert, connection);

            cmd.Parameters.AddWithValue("@category_name", category);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            sendDetails(txtCategory.Text);
            txtCategory.Text = "";
        }
        private void showAllCategories(string category)
        {
            listCategories.Items.Clear();
            if (!connect()) return;
            string select = "select category_name from Categories where category_name like '%" + category + "%'";
            SqlCommand cmd = new SqlCommand(select, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listCategories.Items.Add(reader[0].ToString());
                }
            }
            connection.Close();
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            showAllCategories(txtCategory.Text);
        }
        private void showAllGuestsSelections()
        {
            string select = "SELECT item_name as 'פריט', COUNT(*) as 'מספר הזמנות'\r\nFROM Items\r\nGROUP BY item_name";

            SqlDataAdapter adapter = new SqlDataAdapter(select, ConnectionString);
            //יצירת טבלה זמנית בזכרון והכנסת הנתונים אליה
            DataTable data = new DataTable();
            adapter.Fill(data);

            dataGridView1.DataSource = data;
        }
    }
}
