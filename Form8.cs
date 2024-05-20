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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void home3_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void T2Button1_Click(object sender, EventArgs e)
        {
            tsk2label1.Text = "if you're stuck, maybe redo other tasks or look at da help section!";
        }

        private void txtbox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox1.Text))
            {
                e.Cancel = true;
                txtbox1.Focus();
                errorProvider1.SetError(txtbox1, "Make sure to use correct grammar and punctuation!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtbox1, "");
            }
  
        }
        private void txtbox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox2.Text))
            {
                e.Cancel = true;
                txtbox2.Focus();
                errorProvider1.SetError(txtbox2, "Make sure to use correct grammar and punctuation!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtbox2, "");
            }
        }
        private void txtbox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox3.Text))
            {
                e.Cancel = true;
                txtbox3.Focus();
                errorProvider1.SetError(txtbox3, "Make sure to use correct grammar and punctuation!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtbox3, "");
            }
        }

       private void tsk3go_Click(object sender, EventArgs e)
        {
            string userInput;
            userInput = {txtbox1.Text, txtbox2.Text, txtbox3.Text};
            if (userInput == "Console." && userInput == "Line" && userInput == ";")
            {
                Form9 f9 = new Form9();
                f9.Owner = this;
                f9.StartPosition = FormStartPosition.Manual;
                f9.Location = this.Location;
                f9.Show();
                this.Hide();
            }
            else
            {
                errorProvider1.SetError(txtbox3, "Make sure to use correct grammar and punctuation!");
            }

            //do
            // {
            //  userInput = txtbox1.Text + txtbox2.Text + txtbox3.Text;
            //} while(userInput != "Console." && userInput != "Line" && userInput != ";");
            //Form9 f9 = new Form9();
            // f9.Owner = this;
            //f9.StartPosition = FormStartPosition.Manual;
            //f9.Location = this.Location;
            //f9.Show();
            //this.Hide();
        }

    }
}
