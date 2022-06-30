using QRCoder;
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
using AForge.Video;
using AForge.Video.DirectShow;

namespace Contact_Tracing
{
    public partial class DaTrace : Form
    {
        public DaTrace()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void btn1_Click(object sender, EventArgs e)
        {
            //StreamWriter File =File.AppendText(@"Downloads\test.txt");

            StreamWriter file = new StreamWriter(@"C:\Users\Carlo\source\test.txt");
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

        private void btn2_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Carlo\source\test2.txt");
            file.WriteLine("Name :" + txtBox1.Text);
            file.WriteLine("Address :" + txtBox2.Text);
            file.WriteLine("Contact No. :" + txtBox3.Text);
            file.WriteLine("Time In. :" + txtBox4.Text);
            file.WriteLine("Time Out. :" + txtBox5.Text);
            file.WriteLine("Date. :" + txtBox6.Text);
            file.Close();
            MessageBox.Show("Thank you");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Carlo\source\test3.txt");
            file.WriteLine("Name :" + txtBox1.Text);
            file.WriteLine("Address :" + txtBox2.Text);
            file.WriteLine("Contact No. :" + txtBox3.Text);
            file.WriteLine("Time In. :" + txtBox4.Text);
            file.WriteLine("Time Out. :" + txtBox5.Text);
            file.WriteLine("Date. :" + txtBox6.Text);
            file.Close();
            MessageBox.Show("Thank you");
        }

        private void btnInfo2_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader(@"C:\Users\Carlo\source\test2.txt");
            infoTxtBox2.Text = inputFile.ReadToEnd();
            inputFile.Close();
        }

        private void btnInfo3_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader(@"C:\Users\Carlo\source\test3.txt");
            infoTxtBox3.Text = inputFile.ReadToEnd();
            inputFile.Close();
        }

        private void infoTxtBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void infoTxtBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        private void DaTrace_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filterinfo in filterInfoCollection)
                cboDevice.Items.Add(filterinfo);
            cboDevice.SelectedIndex = 0;
        }
    }
}       
