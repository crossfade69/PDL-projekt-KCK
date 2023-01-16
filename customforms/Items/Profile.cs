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
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void inventoryprofbutton_Click(object sender, EventArgs e)
        {
            inventoryForm inv = new inventoryForm();
            inv.ShowDialog();
        }

        private void editprofbutton_Click(object sender, EventArgs e)
        {
            editprofileForm ed = new editprofileForm();
            ed.ShowDialog();
        }
    }
}
