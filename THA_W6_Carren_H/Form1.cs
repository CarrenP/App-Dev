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

namespace THA_W6_Carren_H
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int angka;
        
        private void button_play_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox_guess.Text);
            if (textBox_guess.Text == "" || a <= 3)
            {
                MessageBox.Show("number input must be greater than 3");
            }
            else
            {
                Form2 f2 = new Form2();
                angka = Convert.ToInt32(textBox_guess.Text);
                f2.Show();
                
            }
        }
    }
}
