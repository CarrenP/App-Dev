using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_w2_Carren_H
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox_age.Text);
            if (number <18) 
            {
                MessageBox.Show("Name: " + textBox_name.Text +  " \n Email: " + textBox_email.Text + "\n Phone Number: " + textBox_phonenum.Text + " \n you are a minor");
            }
            else 
            {
                MessageBox.Show("Name: " + textBox_name.Text + " \n Email: " + textBox_email.Text + " \n Phone Number: " + textBox_phonenum.Text  + " \n you are an adult");
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_name.Text= string.Empty;
            textBox_email.Text = string.Empty;
            textBox_phonenum.Text = string.Empty;
            textBox_name.Text = string.Empty;
            textBox_email.Text = string.Empty;
            textBox_age.Text = string.Empty;
        }
    }
}
