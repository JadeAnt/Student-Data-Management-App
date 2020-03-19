using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM_Ui_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Home
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            //secondUserCustomControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Dashboard
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            firstUserCustomControl2.BringToFront();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Classes
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            thirdUserCustomControl11.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Financial Aid
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            //fourthUserCustomControl1.BringToFront();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Logout
        }



        private void button6_Click_1(object sender, EventArgs e)
        {
            //Exit
            this.Close();
        }

        private void firstUserCustomControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
