namespace CSC240_09_01EnterInvoices_jrm
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(invoiceBox.Text);
            name = nameBox.Text;
            amount = Convert.ToDouble(amountBox.Text);
            writer.WriteLine(num + DELIM + name + DELIM + amount);
            invoiceBox.Clear();
            nameBox.Clear();
            amountBox.Clear();
            //executed and added 3 invoices to file.
        }
    }
}
