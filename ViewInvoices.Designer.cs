namespace CSC240_09_01EnterInvoices_jrm
{
    partial class ViewInvoicesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            viewPromptLabel = new Label();
            vinvoiceLabel = new Label();
            vnameLabel = new Label();
            vamountLabel = new Label();
            vInvoiceBox = new TextBox();
            vNameBox = new TextBox();
            vAmountBox = new TextBox();
            viewButton = new Button();
            SuspendLayout();
            // 
            // viewPromptLabel
            // 
            viewPromptLabel.AutoSize = true;
            viewPromptLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewPromptLabel.Location = new Point(126, 82);
            viewPromptLabel.Name = "viewPromptLabel";
            viewPromptLabel.Size = new Size(377, 130);
            viewPromptLabel.TabIndex = 0;
            viewPromptLabel.Text = "Click the button \r\nto view records.";
            // 
            // vinvoiceLabel
            // 
            vinvoiceLabel.AutoSize = true;
            vinvoiceLabel.Location = new Point(126, 264);
            vinvoiceLabel.Name = "vinvoiceLabel";
            vinvoiceLabel.Size = new Size(133, 48);
            vinvoiceLabel.TabIndex = 1;
            vinvoiceLabel.Text = "Invoice";
            // 
            // vnameLabel
            // 
            vnameLabel.AutoSize = true;
            vnameLabel.Location = new Point(126, 346);
            vnameLabel.Name = "vnameLabel";
            vnameLabel.Size = new Size(115, 48);
            vnameLabel.TabIndex = 2;
            vnameLabel.Text = "Name";
            // 
            // vamountLabel
            // 
            vamountLabel.AutoSize = true;
            vamountLabel.Location = new Point(126, 431);
            vamountLabel.Name = "vamountLabel";
            vamountLabel.Size = new Size(147, 48);
            vamountLabel.TabIndex = 3;
            vamountLabel.Text = "Amount";
            // 
            // vInvoiceBox
            // 
            vInvoiceBox.Location = new Point(423, 264);
            vInvoiceBox.Name = "vInvoiceBox";
            vInvoiceBox.Size = new Size(300, 55);
            vInvoiceBox.TabIndex = 4;
            // 
            // vNameBox
            // 
            vNameBox.Location = new Point(423, 346);
            vNameBox.Name = "vNameBox";
            vNameBox.Size = new Size(300, 55);
            vNameBox.TabIndex = 5;
            // 
            // vAmountBox
            // 
            vAmountBox.Location = new Point(423, 431);
            vAmountBox.Name = "vAmountBox";
            vAmountBox.Size = new Size(300, 55);
            vAmountBox.TabIndex = 6;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(628, 114);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(303, 69);
            viewButton.TabIndex = 7;
            viewButton.Text = "View Records";
            viewButton.UseVisualStyleBackColor = true;
            // 
            // ViewInvoicesForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 781);
            Controls.Add(viewButton);
            Controls.Add(vAmountBox);
            Controls.Add(vNameBox);
            Controls.Add(vInvoiceBox);
            Controls.Add(vamountLabel);
            Controls.Add(vnameLabel);
            Controls.Add(vinvoiceLabel);
            Controls.Add(viewPromptLabel);
            Name = "ViewInvoicesForm";
            Text = "Invoice Data";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label viewPromptLabel;
        private Label vinvoiceLabel;
        private Label vnameLabel;
        private Label vamountLabel;
        private TextBox vInvoiceBox;
        private TextBox vNameBox;
        private TextBox vAmountBox;
        private Button viewButton;
    }
}