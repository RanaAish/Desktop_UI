using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_UI
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            home1.BringToFront();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            createavatar2.BringToFront();
        }

        private void kinectConnected1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            home1.BringToFront();

        }

        private void createavatar1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
           createtoic2.BringToFront();


        }

        private void createtoic2_Load(object sender, EventArgs e)
        {

        }

        private void chat1_Load(object sender, EventArgs e)
        {

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kinectConnected2_Load(object sender, EventArgs e)
        {

        }

        private void createtoic1_Load(object sender, EventArgs e)
        {

        }

        private void check2_Load(object sender, EventArgs e)
        {

        }

       

      

        private void button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;
            noconnect2.BringToFront();
            

        }

        private void createavatar1_Load_1(object sender, EventArgs e)
        {

        }

        private void createtoic1_Load_1(object sender, EventArgs e)
        {

        }

        private void createavatar2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            chat1.BringToFront();
        }

        private void home3_Load(object sender, EventArgs e)
        {

        }

        private void createtoic2_Load_1(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;
            noconnect2.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            check1.BringToFront();
        }
    }
}
