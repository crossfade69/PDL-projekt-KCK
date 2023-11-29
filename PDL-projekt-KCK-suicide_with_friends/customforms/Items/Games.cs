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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace customforms
{
    public partial class Games : UserControl
    {
        DataBase dataBase;
        List<Game> games;
        public Games()
        {
            dataBase=DataBase.GetInstance();
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private DataTable GetData()
        {
            DataTable dtGames = new DataTable();
            dtGames.Columns.Add("title",typeof(string));
            foreach(Game game in games) 
            {
                dtGames.Rows.Add(game.title);
            }
            return dtGames;
        }

        private void shownGamesListBox_ControlAdded(object sender, ControlEventArgs e)
        {

        }
        private void games_Load(object sender, EventArgs e)
        {
            
            SqlConnection connection = DataBase.GetConnection();

            games = dataBase.GetCurrentGames();

            shownGamesListBox.DataSource = GetData();
            shownGamesListBox.DisplayMember = "title";




        }
    }
    
}
