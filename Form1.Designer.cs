using System.IO;
namespace CSC240_09_01EnterInvoices_jrm
{
    partial class InvoiceForm
    {
        const string DELIM = ",";
        const string FILENAME =
            @"C:\CSharp\Chapter14\Invoices.txt";
        int num;
        string name;
        double amount;
        static FileStream outFile = new
            FileStream(FILENAME, FileMode.Create,
            FileAccess.Write);
        StreamWriter writer = new StreamWriter(outFile);

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            invoicePromptLabel = new Label();
            invoiceNumberLabel = new Label();
            lastNameLabel = new Label();
            invoiceAmountLabel = new Label();
            invoiceBox = new TextBox();
            nameBox = new TextBox();
            amountBox = new TextBox();
            enterButton = new Button();
            SuspendLayout();
            // 
            // invoicePromptLabel
            // 
            invoicePromptLabel.AutoSize = true;
            invoicePromptLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            invoicePromptLabel.Location = new Point(85, 116);
            invoicePromptLabel.Name = "invoicePromptLabel";
            invoicePromptLabel.Size = new Size(411, 65);
            invoicePromptLabel.TabIndex = 0;
            invoicePromptLabel.Text = "Enter Invoice Data";
            // 
            // invoiceNumberLabel
            // 
            invoiceNumberLabel.AutoSize = true;
            invoiceNumberLabel.Location = new Point(109, 253);
            invoiceNumberLabel.Name = "invoiceNumberLabel";
            invoiceNumberLabel.Size = new Size(267, 48);
            invoiceNumberLabel.TabIndex = 1;
            invoiceNumberLabel.Text = "Invoice number";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(109, 332);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(180, 48);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last name";
            // 
            // invoiceAmountLabel
            // 
            invoiceAmountLabel.AutoSize = true;
            invoiceAmountLabel.Location = new Point(109, 413);
            invoiceAmountLabel.Name = "invoiceAmountLabel";
            invoiceAmountLabel.Size = new Size(147, 48);
            invoiceAmountLabel.TabIndex = 3;
            invoiceAmountLabel.Text = "Amount";
            // 
            // invoiceBox
            // 
            invoiceBox.Location = new Point(467, 253);
            invoiceBox.Name = "invoiceBox";
            invoiceBox.Size = new Size(300, 55);
            invoiceBox.TabIndex = 4;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(467, 332);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(300, 55);
            nameBox.TabIndex = 5;
            // 
            // amountBox
            // 
            amountBox.Location = new Point(467, 413);
            amountBox.Name = "amountBox";
            amountBox.Size = new Size(300, 55);
            amountBox.TabIndex = 6;
            // 
            // enterButton
            // 
            enterButton.Location = new Point(467, 524);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(265, 69);
            enterButton.TabIndex = 7;
            enterButton.Text = "Enter Record";
            enterButton.UseVisualStyleBackColor = true;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 761);
            Controls.Add(enterButton);
            Controls.Add(amountBox);
            Controls.Add(nameBox);
            Controls.Add(invoiceBox);
            Controls.Add(invoiceAmountLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(invoiceNumberLabel);
            Controls.Add(invoicePromptLabel);
            Name = "InvoiceForm";
            Text = "Invoice Data";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label invoicePromptLabel;
        private Label invoiceNumberLabel;
        private Label lastNameLabel;
        private Label invoiceAmountLabel;
        private TextBox invoiceBox;
        private TextBox nameBox;
        private TextBox amountBox;
        private Button enterButton;
    }
}
