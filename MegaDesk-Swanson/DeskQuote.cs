using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MegaDesk_Swanson
{
    public enum ShippingType
    {
        Rush3Day, 
        Rush5Day, 
        Rush7Day, 
        NoRush
    }
    class DeskQuote
    {
        public DateTime DateQuote { get; set; }

        public Desk Desk { get; set; }

        public string CustomerName { get; set; }

        public decimal QuoteAmount { get; set; }

        public ShippingType Shipping { get; set; }

        public static int GetRushOrder(ShippingType selection, decimal sizeOfDesk)
        {
            
            //This is where you will read in the file and then get the total price from that.
            
            string[] rushOrder = File.ReadAllLines(@"rushOrderPrices.txt");
            string[,] shippingPriceArray = new string[3, 3];
            int number = 0;

            //Fill two dementional array with the values from rushOrderPrices.txt.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    shippingPriceArray[i, j] = rushOrder[number];
                    number++;

                }

            }

            //Creating a variable to know what rush day they need.  
            int rushDays;
            int sizeOfDeskGroup;
            string shippingPrice;

            switch (selection)
            {
                case ShippingType.Rush3Day:
                    rushDays = 0;
                    break;
                case ShippingType.Rush5Day:
                    rushDays = 1;
                    break;
                case ShippingType.Rush7Day:
                    rushDays = 2;
                    break;
                default:
                    rushDays = 0;
                    break;
            }

            if (sizeOfDesk < 1000)
            {
                sizeOfDeskGroup = 0;
            }
            else if (sizeOfDesk <= 2000)
            {
                sizeOfDeskGroup = 1;
            }
            else sizeOfDeskGroup = 2;

            //If NoRush, then price = 0, otherwise it's equal to the number in the array. 

            if(selection == ShippingType.NoRush)
            {
                shippingPrice = "0";
            }
            else
            {
                shippingPrice = shippingPriceArray[rushDays, sizeOfDeskGroup];
            }

            Int64.Parse(shippingPrice);

            Console.WriteLine("Shipping Price: " + shippingPrice);

            return Convert.ToInt32(shippingPrice);
        }


        public static int GetQuoteAmount(DesktopMaterial SurfaceMaterial, int NumOfDrawers, decimal Width, decimal Depth, int ShippingPrice )
        {
            int BaseDeskPrice = 200;
            int MaterialPrice;
            int DrawerPrice = 50;
            decimal SurfaceArea = Width * Depth;
            int ExtraSurfaceAreaPrice = 0;
            if(SurfaceArea > 1000)
            {
                ExtraSurfaceAreaPrice = Convert.ToInt32(SurfaceArea) - 1000;
            }
            switch (Convert.ToString(SurfaceMaterial))
            {
                case "Laminate": MaterialPrice = 100;
                    break;
                case "Oak": MaterialPrice = 200;
                    break;
                case "Pine": MaterialPrice = 50;
                    break;
                case "Rosewood": MaterialPrice = 300;
                    break;
                case "Veneer": MaterialPrice = 125;
                    break;
                default: MaterialPrice = 100;
                    break;

            }
            int TotalPrice = BaseDeskPrice + MaterialPrice + (NumOfDrawers * DrawerPrice) + ShippingPrice + ExtraSurfaceAreaPrice;
            Console.WriteLine("Total Price: " + TotalPrice);
            return TotalPrice;
        }

    }
}
