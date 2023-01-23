using customforms.DataDB;
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

namespace customforms
{
    public partial class Friends : UserControl
    {
        DataBase dataBase;

        public Friends()
        {
            dataBase=DataBase.GetInstance();
            InitializeComponent();

            

            friendsListBox.DataSource = GetData();
            friendsListBox.DisplayMember = "nick";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private DataTable GetData()
        {
            List<User> friends=dataBase.GetCurrentFriends();
            DataTable dtGames = new DataTable();
            dtGames.Columns.Add("nick", typeof(string));
            foreach (User friend in friends)
            {
                dtGames.Rows.Add(friend.nick);
            }
            return dtGames;
        }

    }
}
