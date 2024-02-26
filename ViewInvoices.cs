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
namespace CSC240_09_01EnterInvoices_jrm
{
    public partial class ViewInvoicesForm : Form
    {
        const char DELIM = ',';
        const string FILENAME = @"C:\CSharp\Chapter14\Invoices.txt";
        string recordIn;
        string[] fields;
        static FileStream file = new FileStream(FILENAME,
            FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(file);
        public ViewInvoicesForm()
        {
            InitializeComponent();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader = new StreamReader(file);
                recordIn = reader.ReadLine();
                fields = recordIn.Split(DELIM);
                vInvoiceBox.Text = fields[0];
                vNameBox.Text = fields[1];
                vAmountBox.Text = fields[2];
            }
            catch (NullReferenceException)
            {
                viewPromptLabel.Text = "You have viewed \nall the records.";
                viewButton.Enabled = false;
            }
        }
    }
}
