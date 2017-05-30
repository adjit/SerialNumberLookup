﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Serial_Number_Lookup
{
    public partial class Form1 : Form
    {
        private List<string> invoiceNumbers;

        public Form1()
        {
            InitializeComponent();
            invoiceNumbers = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            invoiceNumbers.Clear();
            string serialNum = serialNumberInput.Text;
            List<string> invoices = new List<string>();
            string connectionString = "Data Source=METRO-GP1;user id=sa;password=frx12gpa;persist security info=True;Integrated Security=False;Initial Catalog=METRO;persistsecurityinfo=True;";
            invoiceNumberOutput.Text = "Searching...";

            if (serialNumberInput.TextLength == 0)
            {
                MessageBox.Show("Please Input a Serial Number");
                return;
            }

            string query = Properties.Settings.Default._dbQuery;
            query = string.Format(query, serialNum);

            SqlConnection dbConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dbConnection;

            dbConnection.Open();
            
            reader = cmd.ExecuteReader();

            int counter = 0;
            string invoiceNumber = "";

            if(reader.HasRows)
            {
                invoiceNumberOutput.Text = "";
                while(reader.Read())
                {
                    counter++;
                    invoiceNumber = reader.GetValue(0).ToString().Trim();

                    if(invoiceNumberOutput.Text.IndexOf(invoiceNumber) < 0)
                    {
                        if(counter > 1) invoiceNumberOutput.Text += "; " + invoiceNumber;
                        else invoiceNumberOutput.Text += invoiceNumber;
                        invoiceNumbers.Add(invoiceNumber);
                    }
                }
            }

            if (counter == 0) invoiceNumberOutput.Text = "No results found";
            else openInvoice.Enabled = true;
        }

        private void getInvoiceFile(string invoiceNum)
        {
//            List<string> archives = new List<string> { "2015 Invoices", "2014 Invoices", "2013 Invoices", "2012 Invoices" };
            DirectoryInfo dInfo = new DirectoryInfo(@"\\METRO-GP1\Dynamics\MESSNGER\Archive");
            FileInfo[] filesInDir = dInfo.GetFiles("in-*" + "-" + invoiceNum + "-" + invoiceNum + "-" + "*");

            string[] dirs = Directory.GetDirectories(@"\\METRO-GP1\Dynamics\MESSNGER\", "20*Invoices");

            int iCounter = dirs.Length-1;

            while(filesInDir.Length == 0)
            {
                if (iCounter < 0) break;

                dInfo = new DirectoryInfo(dirs[iCounter]);
                filesInDir = dInfo.GetFiles("in-*" + "-" + invoiceNum + "-" + invoiceNum + "-" + "*");

                iCounter--;
            }

            try
            {
                System.Diagnostics.Process.Start(filesInDir[0].FullName);
            }
            catch (Exception)
            {
                MessageBox.Show("Error Finding and Opening Invoice. Please use Liason.\nInvoice Number: " + invoiceNum);
            }
        }

        private void getMultipleInvoices()
        {
            for(int i = 0; i < invoiceNumbers.Count; i++)
            {
                getInvoiceFile(invoiceNumbers[i]);
            }
        }

        private void openInvoice_Click(object sender, EventArgs e)
        {
            if (invoiceNumbers.Count > 1) getMultipleInvoices();
            else if (invoiceNumbers.Count == 0) getInvoiceFile(invoiceNumberOutput.Text.ToUpper());
            else getInvoiceFile(invoiceNumbers[0]);
        }

        private void invoiceNumberOutput_TextChanged(object sender, EventArgs e)
        {
            string inputText = invoiceNumberOutput.Text.ToUpper();
            if (inputText.StartsWith("I") && inputText.Length >= 7) openInvoice.Enabled = true;
            else openInvoice.Enabled = false;
        }
    }
}
