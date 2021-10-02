using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string CustomerName { get; set; }

        public decimal QuoteAmount { get; set; }

        public ShippingType Shipping { get; set; }


    }
}
