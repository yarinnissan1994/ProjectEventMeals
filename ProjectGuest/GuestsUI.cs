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

namespace ProjectGuest
{
    public partial class GuestsUI : Form
    {
        static List<GuestsUI> brothers;
        FrmProjectGuests parent;
        int index;
        public GuestsUI(FrmProjectGuests Parent, string GuestName, string CategoryName, int ind)
        {
            InitializeComponent();
            parent = Parent;
            lblGuestName.Text = GuestName;
            lblCategory.Text = CategoryName;
            index = ind;
            showAllGuestsSelections();
            showCurrentGuestSelections();
        }
        
        public List<GuestsUI> Brothers 
        { set 
            {
                brothers = value;
            } 
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            brothers[index + 1].Show();
            this.Visible = false;
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            brothers[index - 1].Show();
            this.Visible = false;
        }

        private void GuestsUI_Load(object sender, EventArgs e)
        {
            if (index == 0)
            {
                btPrev.Enabled = false;
            }
            if (index == brothers.Count - 1)
            {
                btNext.Enabled = false;
            }

        }

        private void AddItem(string item)
        {
            string insert = "declare @guest_code int, @category_code int\r\nif exists (select code from Guests where name=@guest_name)\r\n\tbegin\r\n\t\tselect @guest_code = (select code from Guests where name=@guest_name)\r\n\tend\r\nelse\r\n\tbegin\r\n\t\tinsert into guests values (@guest_name)\r\n\t\tselect @guest_code = @@IDENTITY\r\n\tend\r\n\r\nif exists (select code from Categories where category_name=@category_name)\r\n\tbegin\r\n\t\tselect @category_code = (select code from Categories where category_name=@category_name)\r\n\tend\r\n\r\ninsert into Items values (@guest_code, @category_code, @item_name)";
            if (!parent.connect()) return;
            try
            {
                SqlCommand cmd = new SqlCommand(insert, parent.connection);
                cmd.Parameters.AddWithValue("@guest_name", lblGuestName.Text);
                cmd.Parameters.AddWithValue("@category_name", lblCategory.Text);
                cmd.Parameters.AddWithValue("@item_name", txtItem.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            parent.connection.Close();
            showAllGuestsSelections();
            showCurrentGuestSelections();
        }

        private void btInsertItem_Click(object sender, EventArgs e)
        {
            txtItem.Visible = true;
            btOK.Visible = true;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (txtItem.Text != "")
            {
                AddItem(txtItem.Text);
                txtItem.Text = "";
                txtItem.Visible = false;
                btOK.Visible = false;
            }
        }
        private void showAllGuestsSelections()
        {
            string select = "select guests.name as 'שם אורח', categories.category_name as 'שם קטגוריה',\r\nItems.item_name as 'שם פריט' from Items \r\ninner join guests on guests.code=Items.guest_code\r\ninner join Categories on Categories.code=Items.category_code\r\nwhere Categories.category_name ='" + lblCategory.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(select, parent.ConnectionString);
            DataTable dataTable= new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void showCurrentGuestSelections()
        {
            string select = "select guests.name as 'שם אורח', categories.category_name as 'שם קטגוריה',\r\nItems.item_name as 'שם פריט' from Items \r\ninner join guests on guests.code=Items.guest_code\r\ninner join Categories on Categories.code=Items.category_code\r\nwhere Categories.category_name ='" + lblCategory.Text + "' and guests.name = '" + lblGuestName.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(select, parent.ConnectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddItem(dataGridView1[2, e.RowIndex].Value.ToString());
        }
    }
}
