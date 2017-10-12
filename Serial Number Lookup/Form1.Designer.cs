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
            this.invoiceList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openStandaloneInvoice = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trackingNumberInput = new System.Windows.Forms.TextBox();
            this.trackingNumberLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Number:";
            // 
            // serialNumberInput
            // 
            this.serialNumberInput.Location = new System.Drawing.Point(88, 15);
            this.serialNumberInput.Name = "serialNumberInput";
            this.serialNumberInput.Size = new System.Drawing.Size(166, 20);
            this.serialNumberInput.TabIndex = 1;
            // 
            // lookupButton
            // 
            this.lookupButton.Location = new System.Drawing.Point(179, 73);
            this.lookupButton.Name = "lookupButton";
            this.lookupButton.Size = new System.Drawing.Size(75, 23);
            this.lookupButton.TabIndex = 2;
            this.lookupButton.Text = "Ok";
            this.lookupButton.UseVisualStyleBackColor = true;
            this.lookupButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // invoiceNumberOutput
            // 
            this.invoiceNumberOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.invoiceNumberOutput.Location = new System.Drawing.Point(6, 19);
            this.invoiceNumberOutput.Name = "invoiceNumberOutput";
            this.invoiceNumberOutput.Size = new System.Drawing.Size(156, 20);
            this.invoiceNumberOutput.TabIndex = 3;
            this.invoiceNumberOutput.TextChanged += new System.EventHandler(this.invoiceNumberOutput_TextChanged);
            // 
            // openInvoice
            // 
            this.openInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openInvoice.AutoSize = true;
            this.openInvoice.Enabled = false;
            this.openInvoice.Location = new System.Drawing.Point(168, 19);
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
            this.label2.Location = new System.Drawing.Point(162, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Opens all selected\r\ninvoices";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invoiceList
            // 
            this.invoiceList.FormattingEnabled = true;
            this.invoiceList.Location = new System.Drawing.Point(6, 19);
            this.invoiceList.Name = "invoiceList";
            this.invoiceList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.invoiceList.Size = new System.Drawing.Size(150, 95);
            this.invoiceList.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.invoiceList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.openInvoice);
            this.groupBox1.Location = new System.Drawing.Point(6, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice LIst";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.openStandaloneInvoice);
            this.groupBox2.Controls.Add(this.invoiceNumberOutput);
            this.groupBox2.Location = new System.Drawing.Point(6, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 50);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get Specific Invoice";
            // 
            // openStandaloneInvoice
            // 
            this.openStandaloneInvoice.Enabled = false;
            this.openStandaloneInvoice.Location = new System.Drawing.Point(168, 17);
            this.openStandaloneInvoice.Name = "openStandaloneInvoice";
            this.openStandaloneInvoice.Size = new System.Drawing.Size(92, 23);
            this.openStandaloneInvoice.TabIndex = 1;
            this.openStandaloneInvoice.Text = "Open Invoice";
            this.openStandaloneInvoice.UseVisualStyleBackColor = true;
            this.openStandaloneInvoice.Click += new System.EventHandler(this.openStandaloneInvoice_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.trackingNumberInput);
            this.groupBox3.Controls.Add(this.trackingNumberLabel);
            this.groupBox3.Controls.Add(this.lookupButton);
            this.groupBox3.Controls.Add(this.serialNumberInput);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 107);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lookup";
            // 
            // trackingNumberInput
            // 
            this.trackingNumberInput.Location = new System.Drawing.Point(104, 47);
            this.trackingNumberInput.Name = "trackingNumberInput";
            this.trackingNumberInput.Size = new System.Drawing.Size(150, 20);
            this.trackingNumberInput.TabIndex = 4;
            // 
            // trackingNumberLabel
            // 
            this.trackingNumberLabel.AutoSize = true;
            this.trackingNumberLabel.Location = new System.Drawing.Point(6, 50);
            this.trackingNumberLabel.Name = "trackingNumberLabel";
            this.trackingNumberLabel.Size = new System.Drawing.Size(92, 13);
            this.trackingNumberLabel.TabIndex = 3;
            this.trackingNumberLabel.Text = "Tracking Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "OR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 314);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 353);
            this.Name = "Form1";
            this.Text = "Invoice Lookup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serialNumberInput;
        private System.Windows.Forms.Button lookupButton;
        private System.Windows.Forms.TextBox invoiceNumberOutput;
        private System.Windows.Forms.Button openInvoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox invoiceList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button openStandaloneInvoice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox trackingNumberInput;
        private System.Windows.Forms.Label trackingNumberLabel;
        private System.Windows.Forms.Label label3;
    }
}

