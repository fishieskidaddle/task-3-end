using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_3
{
    public partial class Form7 : Form
    {
        public string playerName { get; set; }

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load_1(object sender, EventArgs e)
        {
            label1.Text = playerName;
        }

        private void T2Button1_Click(object sender, EventArgs e)
        {
            tsk2label1.Text = "I wonder why this is? OvO";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labeltitle.Text = "HOW THIS HAPPENS ?";
            labelex.Text = "To put it simply.. When someone types in their name, we tell the computer to remember it using something called a 'string'.";
            labelex2.Text = "In computer language, a string keeps data (Text) inside like a storage box! When you clicked the button, the computer stored your name in the string and with some more coding, we told the computer to say the data in the string!";
        }
    }
}
