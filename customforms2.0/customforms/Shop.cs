using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace customforms
{
    public partial class Shop : UserControl
    {
        public Shop()
        {
            InitializeComponent();
        }
        private void Shop_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = GetData();
            listBox1.DisplayMember = "Game";
        }
        private DataTable dtGames;
        
        private DataTable GetData()
        {
            dtGames = new DataTable();

            dtGames.Columns.Add("Game", typeof(string));
            dtGames.Rows.Add("amogus");
            dtGames.Rows.Add("Borderlands");
            dtGames.Rows.Add("Borderlands 2");
            dtGames.Rows.Add("Borderlands 3");
            dtGames.Rows.Add("Gorilla Tag");
            dtGames.Rows.Add("Left4Dead2");
            return dtGames;
        }
        private void shopsearchBox_TextChanged(object sender, EventArgs e)
        {
            DataView dvGames = dtGames.DefaultView;
            dvGames.RowFilter = "Game LIKE '%" + shopsearchBox.Text + "%'";
        }

        
    }
}
