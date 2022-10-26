using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _作業02_Exec2_Message_21謝孟勳
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void greetBotton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;


            DateTime timemessage = DateTime.Now;
            timeLabel.Text = Convert.ToString($"現在時間是: {timemessage}");

            string message = $"Hi , {name} 您好";
            greetingLabel.Text = message;


        }

        private void greetingLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
