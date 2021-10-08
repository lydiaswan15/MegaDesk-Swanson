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
               /*
                using(StreamReader reader = new StreamReader(quotesFile))
                {
                    string quotes = reader.ReadToEnd();

                    // This uses Newtonsoft.json

                    //List<DeskQuote> deskQuote = JsonConvert.DeserializeObject<List<DesQuote>>(quotes);

                    List<DeskQuote> deskQuotes = JsonSerializer.Deserialize<List<DeskQuote>>(quotes);

                    dataGridView1.DataSource = DeskQuote.Select(d => new
                    {

                        Date = d.QuoteDate,
                        Customer = d.CustomerName,
                        Depth = d.DeskQuote,
                        Width = d.Desk.Width,
                        Drawers = d.DeskNumberOfDrawers,
                        SurfaceMaterial = d.DeskMaterial,
                        DeliveryType = d.DeliverType,
                        QuoteAmount = d.QUotePrice.ToString("c")
                    }
                    ).ToList();
                }
               */
            }
        }
    }
}
