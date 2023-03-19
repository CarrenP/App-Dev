using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace THA_Week_3_Carren_H
{
    public partial class Form_main : Form
    {
        public static Form_main instance;
        
        
        public Form_main()
        {
            InitializeComponent();
            instance= this;
          
            
        }

        private void checkBox_consent_CheckedChanged(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form_2ndform>().Any() && checkBox_consent.Checked)
            {
                button_submit.Enabled = true;
            }
            else
            {
                button_submit.Enabled = false;
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "" && textBox_favartist.Text == "")
            {
                MessageBox.Show("invalid Input, please fill in the blank.");
                
            }
            
            if (Application.OpenForms.OfType<Form_2ndform>().Any() && checkBox_consent.Checked && textBox_name.Text != "" && textBox_favartist.Text != "")
            {
                Form_2ndform f2 = new Form_2ndform();
                f2.Show();
                
                Form_2ndform.instance.lbname.Text = textBox_name.Text;
                Form_2ndform.instance.lbfavartist.Text = textBox_favartist.Text;
            }
            else
            {
                button_submit.Enabled = false;
                MessageBox.Show("Please open the next form first and tick the consent box before clicking the submit button.");
            }



        }

        private void button_openNext_Click(object sender, EventArgs e)
        {
            Form_2ndform form3 = new Form_2ndform();
            form3.Show();
            button_submit.Enabled = true;
        }
        

    }
}
