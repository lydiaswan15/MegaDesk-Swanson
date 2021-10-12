using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Swanson
{
    public partial class SearchQuotes : Form
    {
        private Form _mainMenu;
        public SearchQuotes(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;

            //populate shipping combo box
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial))
                .Cast<DesktopMaterial>()
                .ToList();

            cmbSurfaceMaterial.DataSource = materials;

            //sets the default to none
            cmbSurfaceMaterial.SelectedIndex = -1;
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DesktopMaterial material = new DesktopMaterial();
            material = (DesktopMaterial)cmbSurfaceMaterial.SelectedValue;

            if (File.Exists(@"quotes.json"))
            {
                string myJsonString = File.ReadAllText(@"quotes.json");
                var quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(myJsonString);
                List<DeskQuote> specificMaterial = new List<DeskQuote>();

                for(int i = 0; i < quotes.Count; i++)
                {
                    if(quotes[i].Desk.SurfaceMaterial == material)
                    {
                        specificMaterial.Add(quotes[i]);
                    }
                }

                dataGridView1.DataSource = specificMaterial.Select(d => new
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
