using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace THA_Week_3_Carren_H
{
    public partial class Form_2ndform : Form
    {
        public static Form_2ndform instance;
        public Label labelbox;
        
        public Form_2ndform()
        {
            InitializeComponent();
            instance = this;
            labelbox = label_textname;
        }
        
        private void button_magic_Click(object sender, EventArgs e)
        {
            if (checkBox_TnC.Checked && checkBox_consentform2.Checked) 
            {
               
                bool radiocheck = false;
                BackColor=System.Drawing.Color.White;
                foreach(RadioButton radio in panel_color.Controls.OfType<RadioButton>())
                {
                    if (radioButton_red.Checked)
                    {
                        radiocheck = true;
                        Form_main.instance.BackColor = Color.Red;
                    }

                    if (radioButton_yellow.Checked)
                    {
                        radiocheck = true;
                        Form_main.instance.BackColor = Color.Yellow;
                    }

                    if (radioButton_Green.Checked)
                    {
                        radiocheck = true;
                        Form_main.instance.BackColor = Color.SeaGreen;
                    }

                    if (radioButton_purple.Checked)
                    {
                        radiocheck = true;
                        Form_main.instance.BackColor = Color.Purple;
                    }

                    if (radioButton_Cream.Checked)
                    {
                        radiocheck = true;
                        Form_main.instance.BackColor = Color.Cornsilk;
                    }
                }
                if (!radiocheck)
                {
                    MessageBox.Show("please select a background color");
                }

                bool radiocheck2 = false;
                ForeColor = System.Drawing.Color.Black;
                foreach(RadioButton radio in panel_textcolor.Controls.OfType<RadioButton>())
                {
                    if (radioButton_pink.Checked)
                    {
                        radiocheck2= true;
                        Form_main.instance.ForeColor = Color.Pink;
                    }
                    if (radioButton_Orange.Checked)
                    {
                        radiocheck2= true;
                        Form_main.instance.ForeColor = Color.Orange;
                    }
                    if (radioButton_blue.Checked)
                    {
                        radiocheck2= true;
                        Form_main.instance.ForeColor = Color.Blue;
                    }
                }
                if (!radiocheck2)
                {
                    MessageBox.Show("please select a text color");
                }
            }
                
            else
            {
                
                MessageBox.Show("Please check both boxes before clicking the Magic Button.");
            }
        }
        
    }
}
