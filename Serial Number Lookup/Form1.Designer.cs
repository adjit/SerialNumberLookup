namespace Serial_Number_Lookup
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.serialNumberInput = new System.Windows.Forms.TextBox();
            this.lookupButton = new System.Windows.Forms.Button();
            this.invoiceNumberOutput = new System.Windows.Forms.TextBox();
            this.openInvoice = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Number:";
            // 
            // serialNumberInput
            // 
            this.serialNumberInput.Location = new System.Drawing.Point(95, 10);
            this.serialNumberInput.Name = "serialNumberInput";
            this.serialNumberInput.Size = new System.Drawing.Size(177, 20);
            this.serialNumberInput.TabIndex = 1;
            // 
            // lookupButton
            // 
            this.lookupButton.Location = new System.Drawing.Point(197, 36);
            this.lookupButton.Name = "lookupButton";
            this.lookupButton.Size = new System.Drawing.Size(75, 23);
            this.lookupButton.TabIndex = 2;
            this.lookupButton.Text = "Ok";
            this.lookupButton.UseVisualStyleBackColor = true;
            this.lookupButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // invoiceNumberOutput
            // 
            this.invoiceNumberOutput.BackColor = System.Drawing.SystemColors.Control;
            this.invoiceNumberOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invoiceNumberOutput.Location = new System.Drawing.Point(16, 41);
            this.invoiceNumberOutput.Name = "invoiceNumberOutput";
            this.invoiceNumberOutput.Size = new System.Drawing.Size(175, 13);
            this.invoiceNumberOutput.TabIndex = 3;
            this.invoiceNumberOutput.TextChanged += new System.EventHandler(this.invoiceNumberOutput_TextChanged);
            // 
            // openInvoice
            // 
            this.openInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openInvoice.AutoSize = true;
            this.openInvoice.Enabled = false;
            this.openInvoice.Location = new System.Drawing.Point(12, 62);
            this.openInvoice.Name = "openInvoice";
            this.openInvoice.Size = new System.Drawing.Size(92, 23);
            this.openInvoice.TabIndex = 4;
            this.openInvoice.Text = "Open Invoice(s)";
            this.openInvoice.UseVisualStyleBackColor = true;
            this.openInvoice.Click += new System.EventHandler(this.openInvoice_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Opens all listed invoices";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 97);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openInvoice);
            this.Controls.Add(this.invoiceNumberOutput);
            this.Controls.Add(this.lookupButton);
            this.Controls.Add(this.serialNumberInput);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Serial Number Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serialNumberInput;
        private System.Windows.Forms.Button lookupButton;
        private System.Windows.Forms.TextBox invoiceNumberOutput;
        private System.Windows.Forms.Button openInvoice;
        private System.Windows.Forms.Label label2;
    }
}

