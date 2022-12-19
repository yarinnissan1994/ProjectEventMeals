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

namespace ProjectGuest
{
    public partial class FrmProjectGuests : Form
    {
        public string ConnectionString = "data source=localhost\\SQLEXPRESS; initial catalog=Event_Meals; Integrated Security=true;";
        public SqlConnection connection;
        public FrmProjectGuests()
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
        private void enterGuest(string name)
        {
            if (!connect()) return;
            string insert = "if not exists(select * from guests where name=@guest_name)\r\n\tbegin\r\n\t\tinsert into guests values (@guest_name)\r\n\tend";
            try
            {
                SqlCommand cmd = new SqlCommand(insert, connection);

                cmd.Parameters.AddWithValue("@guest_name", name);
                int num = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        private void showAllGuest(string name)
        {
            listGuests.Items.Clear();
            if (!connect()) return;
            string select = "select name from Guests where name like '%"+name+"%'";
            SqlCommand cmd = new SqlCommand(select, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    listGuests.Items.Add(reader[0].ToString());
                }
            }
            connection.Close();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "") return;
            enterGuest(txtName.Text);
            CreateFormsByCategory(txtName.Text);
            txtName.Text = "";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            showAllGuest(txtName.Text);
        }

        private void listGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = listGuests.Text;
        }
        private void CreateFormsByCategory(string name)
        {
            string select = "select category_name from Categories";
            if (!connect() ) return;
            SqlCommand cmd = new SqlCommand(select, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<GuestsUI> Categories = new List<GuestsUI>();
            int index = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Categories.Add(new GuestsUI(this, name, reader[0].ToString(), index++));
                }
                Categories.First().Brothers = Categories;
                Categories.First().Show();
            }
            connection.Close();
        }
    }
}
