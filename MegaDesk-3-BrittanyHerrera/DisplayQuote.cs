using System;
using System.Windows.Forms;

namespace MegaDesk_3_BrittanyHerrera
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(string customerName, DateTime Date, int width, int depth, int numOfDrawers, string desktopMaterial, int rushOrderDays, int deskQuote)
        {
            InitializeComponent();
            CustomerName.Text = customerName;
            this.Date.Text = Date.ToString("dd MMM yyyy");
            //Width.GetType = width.() + " inches";
           // depth.GetType = depth.ToString() + " inches";
           // numOfDrawers. = numOfDrawers.ToString();
#pragma warning disable CS1717 // Assignment made to same variable
            desktopMaterial = desktopMaterial;
#pragma warning restore CS1717 // Assignment made to same variable
            if (rushOrderDays == 0)
              {
                Desk.RushDays.Text = "None";
              }
                     else 
            {
                Desk.RushDays.Text = rushOrderDays.ToString() + " days";
              }
              total.Text = String.Format("{0:C}", deskQuote);
              } 
 
       private void DeskOrderView_FormClosed(object sender, FormClosedEventArgs e)
       { 
            this.Close();    
       } 

 
        private void CloseButton_Click(object sender, EventArgs e)
         { 
             var ShowMainMenu = (MainMenu)Tag; 
             ShowMainMenu.Show(); 
             this.Close(); 
         } 
   
        private void cancelQuote_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PayNow_Click(object sender, EventArgs e)
        {

            ThankYou NewThankYouForm = new ThankYou
            {
                Tag = this
            };
            NewThankYouForm.Show(this);
            this.Hide();
        }

        internal void Hide(AddQuote addQuote)
        {
            throw new NotImplementedException();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        private void deskPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
