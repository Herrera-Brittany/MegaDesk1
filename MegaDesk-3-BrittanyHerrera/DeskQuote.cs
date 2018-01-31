using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            SurfaceArea = Desk.Width * Desk.Depth;
        }
        public int SurfaceAreaCost()
        {
            // Determine if additional cost is warranted with desk areas greater than the desktop size threshold
            if (SurfaceArea > SIZE_THRESHOLD)
            {
                return (SurfaceArea - SIZE_THRESHOLD) * PRICE_PER_SURFACEAREA;
            }
            else
            {
                return 0;
            }
            public int DrawerCost() { }
            public int SurfaceMaterialCost() { }
            public int RushOrderCost() { }

            public int CalculateQuoteTotal()
            {
                return PRICE_BASE + SurfaceAreaCost() + DrawerCost() + SurfaceMaterialCost() + RushOrderCost();
            }

        }

    } }


        

