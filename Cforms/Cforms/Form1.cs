using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                if(textBox1.Text.Length > 0)
                {
                    if (listBox1.Items.Contains(textBox1.Text)) 
                    {
                        DialogResult result = MessageBox.Show("Element ju¿ istnieje. Dodaæ mimo to?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                    listBox1.Items.Add(textBox1.Text);
                    AktualizacjaProgres();
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Wartoœæ pusta", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lista jest ju¿ pe³na", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AktualizacjaProgres()
        {
            int i = listBox1.Items.Count;
            progressBar1.Value = i * 10;
        }

        private void usuñ_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if(i != -1)
            {
                listBox1.Items.RemoveAt(i);
                AktualizacjaProgres();
            }
            else 
            {
                MessageBox.Show("Nie zaznaczono elementu", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wyczyœæ_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            AktualizacjaProgres();
        }
    }
}