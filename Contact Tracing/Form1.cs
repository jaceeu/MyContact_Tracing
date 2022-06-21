﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class DaTrace : Form
    {
        public DaTrace()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //StreamWriter File =File.AppendText(@"Downloads\test.txt");

            StreamWriter file = new StreamWriter(@"C:\Users\Carlo\source\test.txt",true);
            file.WriteLine("Name :" + txtBox1.Text);
            file.WriteLine("Address :" + txtBox2.Text);
            file.WriteLine("Contact No. :" + txtBox3.Text);
            file.WriteLine("Time In. :" + txtBox4.Text);
            file.WriteLine("Time Out. :" + txtBox5.Text);
            file.WriteLine("Date. :" + txtBox6.Text);
            file.Close();
            MessageBox.Show("Thank you");
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader(@"C:\Users\Carlo\source\test.txt");
            infoTxtBox.Text = inputFile.ReadToEnd();
            inputFile.Close();
        }

        private void infoTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
