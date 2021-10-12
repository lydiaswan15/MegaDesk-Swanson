using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_Swanson
{
    public partial class ViewAllQuotes : Form
    {
        private Form _mainMenu;
        public ViewAllQuotes(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;

            loadGrid();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {

        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void loadGrid()
        {
           var quotesFile =  @"quotes.json";

            if(File.Exists(quotesFile))
            {
                    string myJsonString = File.ReadAllText(@"quotes.json");
                    var quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(myJsonString);
                    // This uses Newtonsoft.json

                  //  List<DeskQuote> deskQuotes = quotes;

                    dataGridView1.DataSource = quotes.Select(d => new
                    {

                        Date = d.DateQuote,
                        Customer = d.CustomerName,
                        Depth = d.Desk.Depth,
                        Width = d.Desk.Width,
                        Drawers = d.Desk.NumOfDrawers,
                        SurfaceMaterial = d.Desk.SurfaceMaterial,
                        DeliveryType = d.Shipping,
                        QuoteAmount = d.QuoteAmount.ToString("c")
                    }
                    ).ToList();
                }
               
            
        }
    }
}
