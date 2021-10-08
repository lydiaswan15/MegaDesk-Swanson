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

        public static int GetRushOrder(ShippingType selection)
        {
            /*
            //This is where you will read in the file and then get the total price from that.

            StreamReader reader = new StreamReader("rushOrderPrices.txt");

            
            string[] rushOrder = File.ReadAllLines(@"rushOrderPrices.txt");
            string[,] shippingPrice = new string[3, 3];

           for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(rushOrder[i]);
                /* for(int j = 0; j < 3; j++)
                {
                    for(int k = 0; k < 3; k++)
                    {
                        shippingPrice[1, 1] = rushOrder[i];
                    }
          
         
                } 

            }

            Console.WriteLine(shippingPrice[1, 2]); */
           
            return 2; 

        }


    }
}
