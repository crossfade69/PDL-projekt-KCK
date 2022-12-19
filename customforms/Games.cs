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
    public partial class Games : UserControl
    {
        public Games()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listbox1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = GetData();
            listBox1.DisplayMember = "Game";
        }
        private DataTable GetData()
        {
            DataTable dtGames = new DataTable();

            dtGames.Columns.Add("Game", typeof(string));
            dtGames.Rows.Add("amogus");

            return dtGames;
        }
    }
}
