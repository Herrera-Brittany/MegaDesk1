using System;
using System.Windows.Forms;

namespace MegaDesk_3_BrittanyHerrera
{
    public partial class AddQuote : Form
    {
        #region Declarations 


        string CustomerName = String.Empty;
        int Width = 0;
        int Depth = 0;
        int NumberofDrawers = 0; // number of desk drawers 
        string DesktopMaterial = ""; // "" versus String.Empty desktop material selection 
        int RushDays = 0; // rush order selection in days 
        int DeskQuoteTotal = 0; // desk quote total 


        #endregion

        public AddQuote()
        {
            InitializeComponent();
        }

        private void DisplayQuote_button(object sender, EventArgs e)
        {
            AddQuote AddQuoteForm = new AddQuote
            {
                Tag = this
            };
            AddQuoteForm.Show(this);
            this.Hide();
        }
        //public AddQuote(int width, int depth, int drawers, string material, int rushDays)
       // {
            // Constructor when object is built - set attribute values
            // Desk.Width = width;
            //Desk.Depth = depth;
            // Desk.NumberOfDrawers = drawers;
            // Desk.DesktopMaterial = material;
            // RushDays = rushDays;

            // calculate Surface Area member variable for use in multiple functions
            //SurfaceArea = Desk.Width * Desk.Depth;
        }
        //public int SurfaceAreaCost()
        //{
        // Determine if additional cost is warranted with desk areas greater than the desktop size threshold
        // if (SurfaceArea > SIZE_THRESHOLD)
        //{
        //     return (SurfaceArea - SIZE_THRESHOLD) * PRICE_PER_SURFACEAREA;
        //   }
        //else
        // {
        //    return 0;
        //  }


        //public int DrawerCost()

        // return NumberOfDrawers * PRICE_PER_DRAWER;



        // public int SurfaceMaterialCost()
    }
            switch (DesktopMaterial())
            {
                case "Oak":
                    return 100;
                case "Pine":
                    return 50;
                case "Rosewood":
                    return 300;
                case "Veneer":
                    return 125;
                case "Laminate":
                    return 100;

                default:
                    return -1;
            }

        }

        //private static DesktopMaterial() => VScrollBar;

        public int RushOrderCost
        { 
            switch
            { 
                //   if (RUSH1 == true)

                //      return 60;
                //  }
                //  else if (RUSH2 == true)
                //  {
                // return 40;
                //  }
                //  else if (RUSH3 == true)
                //  {
                //     return 30;


                int a = 0;

                /* check the boolean condition */
                if (a == 3 && a < 1000)
                {
                    /* if condition is true then print the following */
                    Console.WriteLine(60);
                }
                else if (a == 3 && a > 1000 && a < 2000)
                {
                    /* if else if condition is true */
                    Console.WriteLine(70);
                }
                else if (a == 3 && a > 2000)
                {
                    /* if else if condition is true  */
                    Console.WriteLine(80);
                }
                else if (a == 5 && a < 1000)
                {
                    /* if else if condition is true */
                    Console.WriteLine(40);
                }
                else if (a == 5 && a > 1000 && a < 2000)
                {
                    /* if else if condition is true  */
                    Console.WriteLine(50);
                }
                else if (a == 5 && a > 2000)
                {
                    /* if else if condition is true */
                    Console.WriteLine(60);
                }
                else if (a == 7 && a < 1000)
                {
                    /* if else if condition is true  */
                    Console.WriteLine(30);
                }
                else if (a == 7 && a > 1000 && a < 2000)
                {
                    /* if else if condition is true  */
                    Console.WriteLine(35);
                }
                else if (a == 7 && a > 2000)
                {
                    /* if else if condition is true */
                    Console.WriteLine(40);
                }

                else
                {
                    /* if none of the conditions is true */
                    Console.WriteLine("None of the values is matching");
                }
                Console.WriteLine("Exact value of a is: {0}", a);
                Console.ReadLine();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var MainMenu = (MainMenu)Tag;
            MainMenu.Show();
            Close();
        }

        private void OrderNow_button(object sender, EventArgs e)
        {

            DisplayQuote NewDisplayQuoteForm = new DisplayQuote
            {
                Tag = this
            };
            NewDisplayQuoteForm.Show(this);
            this.Hide();
         
                }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
    }
}