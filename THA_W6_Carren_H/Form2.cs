using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W6_Carren_H
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] answer = File.ReadAllText("Wordle Word List.txt").Split(',');
        string random;
        Button[,] button;
        
        Form1 form = new Form1();
        List<Button> button1 = new List<Button>();
        List<Button> keyboard = new List<Button>();
        string[] alphabeths = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "I", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M" };
        int abc = 0;
        int a = 0;
        int b = 0;
        int mb = 0;
        int aa = 350;
        int bb = 50;
        int check = 0;
        List<string> kata;
        int guess, x, y;
        int belakang = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            string file = "Wordle Word List.txt";
            string[] baris = File.ReadAllLines(file);
            kata = new List<string>();
            foreach (string wordy in baris)
            {
                kata.AddRange(wordy.Split(','));
            }
            random = kata[new Random().Next(kata.Count - 1)].ToUpper();
            belakang = random.Length;

            guess = Form1.angka;
            for (int i = 0; i < Form1.angka; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button button = new Button();
                    button.Location = new Point(6 + a, 6 + b);
                    button.Tag = "button" + abc;
                    button.Size = new Size(40, 40);
                    button1.Add(button);
                    abc++;
                    a += 50;

                }
                b += 50;
                a = 0;
            }
            foreach (Button button in button1)
            {
                this.Controls.Add(button);
            }
            abc = 0;



            foreach (string z in alphabeths)
            {
                //  MessageBox.Show(z.ToString());
                Button butoon = new Button();
                butoon.Tag = z;
                butoon.Text = z.ToString();
                butoon.Size = new Size(40, 40);
                butoon.Location = new Point(aa, bb);

                keyboard.Add(butoon);
                butoon.Click += buttonclick;
                this.Controls.Add(butoon);
                aa += 50;
                if (z == "P")
                {
                    aa = 350;
                    bb += 50;
                }
                else if (z == "L")
                {
                    aa = 380;
                    bb += 50;
                }
            }
        }
        int helo = 0;



        private void buttonclick(object sender, EventArgs e)
        {
            
            Button butoon = sender as Button;
            if(helo<belakang)
            {
                foreach (Button number in keyboard)
                {
                    if (butoon.Tag == number.Tag)
                    {
                        button1[helo].Text = number.Text;

                    }

                }
                helo++;
            }
            


        }


        private void button_delte_Click(object sender, EventArgs e)
        {
                if (button1[0].Text != "")
                {
                    button1[helo - 1].Text = " ";
                    helo--;
                }
        }


        private void button_enter_Click(object sender, EventArgs e)
        {
            belakang += random.Length;
            int correct = 0;
            if (helo != 5)
            {
                MessageBox.Show("Please fill all the blank !");
            }
            else
            {
                string wordss = "";
                for (int i = 0; i < a; i++)
                {
                    wordss += button[i, b].Text;
                }
                if (answer.Contains(wordss.ToLower()))
                {
                    for (int i = 0; i < a; i++)
                    {
                        MessageBox.Show(random[i].ToString(), (button[i, b].Text));
                        if (random[i].ToString() == (button[i, b].Text))
                        {
                            
                            button[i, b].BackColor = Color.Green;
                            correct++;
                        }
                        else if (random.Contains(button[i, b].Text))
                        {
                            button[i, b].BackColor = Color.Yellow;
                        }
                        else
                        {
                            button[i, b].BackColor = Color.Black;
                        }

                    }
                    b++;
                    a = 0;
                    if (correct == 5)
                    {
                        MessageBox.Show("Win !");
                    }
                    else if (correct < 5 && b == guess)
                    {
                        MessageBox.Show("Lose !, here is the correct answer: " + random);
                    }
                }
                else
                {
                    MessageBox.Show("Word not found!");
                }
            }
        }
    }
}
