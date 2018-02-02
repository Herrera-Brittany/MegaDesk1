using System;


namespace MegaDesk_3_BrittanyHerrera
{


    class DeskQuote
    {

        private int RushDays = 0;
        public Desk Desk = new Desk();

        private int SurfaceArea = 0; // used in multiple functions


        // Constants (future source is some data source)
        private const int PRICE_BASE = 200;
        private const int SIZE_THRESHOLD = 1000;  // inches squared
        private const int PRICE_PER_DRAWER = 50;
        private const int PRICE_PER_SURFACEAREA = 1; // extra cost per square inch greater than desktop size threshold
        private const int RUSH1 = 3; private const int RUSH2 = 5; private const int RUSH3 = 7; // Rush order days options
        private const int RUSH_THRESHOLD = 2000; // inches squared - see problem specs for rush order costs


        public DeskQuote(int width, int depth, int drawers, string material, int rushDays)
        {
            // Constructor when object is built - set attribute values
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumberOfDrawers = drawers;
            Desk.DesktopMaterial = material;
            RushDays = rushDays;

            // calculate Surface Area member variable for use in multiple functions
            // SurfaceArea = Desk.Width * Desk.Depth;

        }
    }
}
        //  public int CalculateQuoteTotal()
        //{ 
        //}
        //public int SurfaceAreaCost()
        //{
        //   // Determine if additional cost is warranted with desk areas greater than the desktop size threshold
        // if (SurfaceArea > SIZE_THRESHOLD)
        //{
        //      return (SurfaceArea - SIZE_THRESHOLD) * PRICE_PER_SURFACEAREA;
        //}
        // else
        //  {
        //       return 0;
        //  }
   // }

  //  public int DrawerCost()
   // {
    //    return Desk.NumberOfDrawers * PRICE_PER_DRAWER;

//    }

  //  public int MaterialCost()
 //   {
   //     switch (Desk.DesktopMaterial)
     //   {
     //       case "Oak":
      //          return 100;
       //     case "Pine":
        //        return 50;
        //    case "Rosewood":
          //      return 300;
      //      case "Veneer":
       //         return 125;
        //    case "Laminate":
        //        return 100;

          //  default:
            //    return -1;
        //}

    //}
//}

       // public int RushOrderCost()
        //{
         //   if (RUSH1 == true)
          //  {
          //      return 60;
          //  }
          //  else if (RUSH2 == true)
          //  {
        //        return 40;
          //  }
          //  else if (RUSH3 == true)
          //  {
           //     return 30;
         //   }

     //   int a = 0;

            /* check the boolean condition */
       //     if (a == 3 && a < 1000)
         //   {
                /* if condition is true then print the following */
           //     Console.WriteLine(60);
           // }
           // else if (a == 3 && a > 999 && a < 2000)
           // {
                /* if else if condition is true */
             //   Console.WriteLine(70);
           // }
            //else if (a == 3 && a > 2000)
            //{
                /* if else if condition is true  */
              //  Console.WriteLine(80);
           // }
            //else if (a == 5 && a < 1000)
            //{
                /* if else if condition is true */
              //  Console.WriteLine(40);
           // }
            //else if (a == 5 && a > 999 && a < 2000)
            //{
                /* if else if condition is true  */
             //   Console.WriteLine(50);
           // }
         //   else if (a == 5 && a > 2000)
           // {
                /* if else if condition is true */
             //   Console.WriteLine(60);
        //    }
          //  else if (a == 7 && a < 1000)
           // {
                /* if else if condition is true  */
             //   Console.WriteLine(30);
           // }
           // else if (a == 7 && a > 999 && a < 2000)
            //{
                /* if else if condition is true  */
            //    Console.WriteLine(35);
           // }
            //else if (a == 7 && a > 2000)
            //{
                /* if else if condition is true */
            //    Console.WriteLine(40);
           // }

           // else
            //{
                /* if none of the conditions is true */
              //  Console.WriteLine("None of the values is matching");
          //  }
           // Console.WriteLine("Exact value of a is: {0}", a);
            //Console.ReadLine();
        //}
    //}
    //public interface[,] GetRushOrderPrices()
    

    



        

