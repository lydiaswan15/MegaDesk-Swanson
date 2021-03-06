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
    public partial class AddQuote : Form
    {
        private Form _mainMenu;
        public AddQuote(Form mainMenu)
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


            // populate shipping times

            List<ShippingType> shippingList = Enum.GetValues(typeof(ShippingType))
               .Cast<ShippingType>()
               .ToList();

            cmbShipping.DataSource = shippingList;

            //sets the default to none
            cmbShipping.SelectedIndex = -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            //converts this.Tag into a form and has it show it. 
            //((Form)this.Tag).Show();

            _mainMenu.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void btn_SaveQuote(object sender, EventArgs e)
        {
            var desk = new Desk();
            desk.Width = numWidth.Value;
            desk.Depth = numDepth.Value;
            desk.NumOfDrawers = (int)nudNumOfDrawers.Value;
            desk.SurfaceMaterial = (DesktopMaterial) cmbSurfaceMaterial.SelectedValue;
            decimal sizeOfDesk = desk.Width * desk.Depth;

            
            var deskQuote = new DeskQuote();
            deskQuote.CustomerName = txtCustomerName.Text;
            deskQuote.DateQuote = DateTime.Now;
            deskQuote.Shipping = (ShippingType)cmbShipping.SelectedItem;
            deskQuote.Desk = desk;
            int ShippingPrice = DeskQuote.GetRushOrder(deskQuote.Shipping, sizeOfDesk);
            deskQuote.QuoteAmount = DeskQuote.GetQuoteAmount(
                desk.SurfaceMaterial, 
                desk.NumOfDrawers, 
                desk.Width, 
                desk.Depth, 
                ShippingPrice);


            string fileName = @"quotes.json";
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Dispose();
                var list = new List<DeskQuote>();
                list.Add(deskQuote);
                string json = JsonConvert.SerializeObject(list);
                File.WriteAllText(fileName, json);
                this.Close();
            }
            else {

                string myJsonString = File.ReadAllText(@"quotes.json");
                var list = JsonConvert.DeserializeObject<List<DeskQuote>>(myJsonString);
                list.Add(deskQuote);
                var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
                File.WriteAllText(@"quotes.json", convertedJson);
                this.Close();
            }
          
            
      
            
            

            
        }
    }
}
