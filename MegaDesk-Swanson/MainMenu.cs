using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Swanson
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            //var addQuoteForm = new AddQuote(); //Creates a new method of the class AddQuote (which is a form)
            //addQuoteForm.Tag = this;
            //addQuoteForm.Show(); //This actually shows the form when you click the button.

            var addQuoteForm = new AddQuote(this);
            addQuoteForm.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {

            var addViewQuotesForm = new ViewAllQuotes(this);
            addViewQuotesForm.Show();

            this.Hide();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            var addViewSearchQuotes = new SearchQuotes(this);
            addViewSearchQuotes.Show();
            this.Hide();
        }
    }
}
