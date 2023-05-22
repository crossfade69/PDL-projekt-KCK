using customforms.DataDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
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
        string path = @"C:\Users\Bartek\Desktop\PDL";
        public Games()
        {
            dataBase = DataBase.GetInstance();
            InitializeComponent();

        }
        public void SelectNewDirectory()
        {

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    path = fbd.SelectedPath;
                }
            }



        }
        public void CheckForDirectory()
        {
            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                MessageBox.Show("The directory was created successfully.");


            }
            catch (Exception e)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
            finally { }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            
        }


        private DataTable GetData()
        {
            DataTable dtGames = new DataTable();
            dtGames.Columns.Add("title", typeof(string));
            foreach (Game game in games)
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

            CheckForDirectory();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectNewDirectory();
        }

        private void shownGamesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           

            ProcessStartInfo info = new ProcessStartInfo(@"C:\Program Files (x86)\Steam\steamapps\common\Heroes of Might & Magic III - HD Edition\HOMM3 2.0");
   
            info.UseShellExecute = false;

            Process whatever = Process.Start(info);
        }
    }

}
