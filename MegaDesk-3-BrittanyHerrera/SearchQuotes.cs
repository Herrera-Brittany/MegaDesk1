using System;
using System.Windows.Forms;

namespace MegaDesk_3_BrittanyHerrera
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            {
                var ShowMainMenu = (MainMenu)Tag;
                ShowMainMenu.Show();
                this.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    


