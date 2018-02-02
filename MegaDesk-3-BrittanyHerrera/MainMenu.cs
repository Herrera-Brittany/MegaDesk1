using System;
using System.Windows.Forms;

namespace MegaDesk_3_BrittanyHerrera
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote AddNewQuoteForm = new AddQuote
            {
                Tag = this
            };
            AddNewQuoteForm.Show(this);
            this.Hide();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
