using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(44, 62, 80);            
            button4.BackColor = Color.FromArgb(29, 210, 175);
            //button1.BackColor = Color.FromArgb(29,210,175);
            //button2.BackColor = Color.FromArgb(29, 210, 175);
            //button3.BackColor = Color.FromArgb(29, 210, 175);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void AnimationButtom(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load_2(object sender, EventArgs e)
        {

        }
    }
}
