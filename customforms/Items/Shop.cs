using customforms.DataDB;
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
            dataBase = DataBase.GetInstance();
        }
        private void Shop_Load(object sender, EventArgs e)
        {
            shopGamesListBox.DataSource = GetData();
            shopGamesListBox.DisplayMember = "title";
        }
        private DataTable dtGames;
        private DataBase dataBase;
        private List<Game> games;

        private int GetGameId(string gameTitle)
        {
            foreach(Game game in games) 
            {
                if(game.title==gameTitle)
                {
                    return game.id;
                }
            }
            return -1;
        }
        private DataTable GetData()
        {

            dtGames = new DataTable();
             games = dataBase.GetAllGames();
            dtGames.Columns.Add("title", typeof(string));

            foreach (Game game in games)
            {
                dtGames.Rows.Add(game.title);
            }

            return dtGames;
        }
        private void shopsearchBox_TextChanged(object sender, EventArgs e)
        {
            DataView dvGames = dtGames.DefaultView;
            dvGames.RowFilter = "title LIKE '%" + shopSearchBox.Text + "%'";
        }

        private void shopGamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("b");
        }

        private void shopGamesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("a");
        }

        private void shopGamesListBox_Enter(object sender, EventArgs e)
        {
           
        }

        private void shopGamesListBox_DoubleClick(object sender, EventArgs e)
        {
            GameBought(shopGamesListBox.Text);
        }
        private void GameBought(string gameTitle)
        {
            bool found=false;
            int gameId=-1;
            foreach(Game game in dataBase.GetCurrentGames() )
            {
                if (game.title==gameTitle)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Kupiono");
            }
                
            MessageBox.Show(GetGameId(gameTitle).ToString());
        }
    }
}
