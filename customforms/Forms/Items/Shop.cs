using Microsoft.Extensions.Logging;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace customforms
{
    public partial class Shop : UserControl
    {
        public Shop()
        {
            InitializeComponent();
            dataBase=DataBase.GetInstance();
        }
        private void Shop_Load(object sender, EventArgs e)
        {
            shopGamesListBox.DataSource = GetData();
            shopGamesListBox.DisplayMember = "Game";
        }
        private DataTable dtGames;
        private DataBase dataBase;

        private DataTable GetData()
        {

            return dtGames;
        }
        private void shopsearchBox_TextChanged(object sender, EventArgs e)
        {
            DataView dvGames = dtGames.DefaultView;
            dvGames.RowFilter = "Game LIKE '%" + shopSearchBox.Text + "%'";
        }


    }
}
