using System; 
using System.ComponentModel; 
using System.Drawing; 
using System.IO; 
using System.Windows.Forms; 
 
 
 namespace MegaDesk1
 { 
     public partial class AddQuote : Form 
     { 
         #region Declarations 
 
 
         string CustomerName = String.Empty; 
         int DeskWidth = 0; 
         int DeskDepth = 0;  
         int Drawers = 0; // number of desk drawers 
         string Material = ""; // "" versus String.Empty desktop material selection 
         int RushOrderDays = 0; // rush order selection in days 
         int DeskQuoteTotal = 0; // desk quote total 
 
 
         #endregion 
 
 
         public AddQuote()
         { 
             InitializeComponent(); 
         } 
 
 
         private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
         { 
             var ReturnMainMenu = (MainMenu)Tag; 
             ReturnMainMenu.Show(); 
             this.Close(); 
         } 
 

         private void WidthTextBox_Validating(object sender, CancelEventArgs e)
         { 
             if (int.TryParse(WidthTextBox.Text, out int WidthInput)) 
             { 
                 if (WidthInput<Desk.MINWIDTH || WidthInput> Desk.MAXWIDTH) 
                 { 
                     MessageBox.Show("Please enter a width from 24 to 96 inches."); 
                     WidthTextBox.Text = String.Empty; 
                     WidthTextBox.BackColor = Color.LightSalmon; 
                     WidthTextBox.Focus(); 
                 } 
                 else 
                 { 
                     WidthTextBox.BackColor = Color.White; 
                 } 
             } 
             else 
             { 
                 MessageBox.Show("Please enter a valid width measurement as a whole number."); 
                 WidthTextBox.Text = ""; 
                 WidthTextBox.BackColor = Color.LightSalmon; 
                 WidthTextBox.Focus(); 
             } 
         } 
 
 
         private void DepthTextBox_KeyPress(object sender, KeyPressEventArgs e)
         { 
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) 
             { 
                 e.Handled = true; 
             } 
 
 
         } 
         private void DepthTextBox_Validating(object sender, CancelEventArgs e)
         { 
             if (int.TryParse(DepthTextBox.Text, out int height)) 
             { 
                 if (height<Desk.MINDEPTH || height> Desk.MAXDEPTH) 
                 { 
                     MessageBox.Show("Please enter a width from 24 to 48 inches."); 
                     DepthTextBox.Text = String.Empty; 
                     DepthTextBox.BackColor = Color.LightSalmon; 
                     DepthTextBox.Focus(); 
                 } 
             } 
             else 
             { 
                 MessageBox.Show("Please enter a valid width measurement as a whole number."); 
                 DepthTextBox.Text = ""; 
                 DepthTextBox.BackColor = Color.LightSalmon; 
                 DepthTextBox.Focus(); 
             } 
         } 
 

         private void AddDeskButton_Click(object sender, EventArgs e)
         { 
             // Input 
             try 
             { 
                 CustomerName = customerNameTextBox.Text; 
                 DeskWidth = int.Parse(WidthTextBox.Text); 
                 DeskDepth = int.Parse(DepthTextBox.Text); 
                 Drawers = int.Parse(NumDrawersComboBox.SelectedItem.ToString()); 
                 Material = DesktopMaterialComboBox.SelectedItem.ToString(); 
 
 
                 // Get rush order selection 
                 if (RushThreeRadio.Checked) 
                 { 
                     RushOrderDays = 3; 
                 } 
                 if (RushFiveRadio.Checked) 
                 { 
                     RushOrderDays = 5; 
                 } 
                 if (RushSevenRadio.Checked) 
                 { 
                     RushOrderDays = 7; 
                 } 
 
 
                 // Create new DeskQuote object and calculate total 
 

                 DeskQuote NewOrder = new DeskQuote(DeskWidth, DeskDepth, Drawers, Material, RushOrderDays); 
                 DeskQuoteTotal = NewOrder.CalculateQuoteTotal(); 
             } 
             catch (Exception ex) 
             { 
                 MessageBox.Show(ex.Message, "Check input methods"); 
                 throw; 
             } 
 
 
             #region Display To Screen 
              // Show confirmation page on new screen named DeskQuoteView 
              var MainMenu = (MainMenu)Tag; // need to bring along a reference tag to the main menu form 
              DeskQuoteView newOrderView = new DeskQuoteView(CustomerName, DateTime.Now.Date, DeskWidth, DeskDepth, Drawers, Material, RushOrderDays, DeskQuoteTotal) { Tag = MainMenu };           
              newOrderView.Show(); 
              this.Close(); 
             #endregion 
 
 
         } 
 
 
         private void ReturnButton_Click(object sender, EventArgs e)
         { 
             var ShowMainMenu = (MainMenu)Tag; 
             ShowMainMenu.Show(); 
             this.Close(); 
         } 
     } 
 } 

