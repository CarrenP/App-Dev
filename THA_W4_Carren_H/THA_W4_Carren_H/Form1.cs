using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace THA_W4_Carren_H
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        List<team> teams = new List<team>();
        private void Form1_Load(object sender, EventArgs e)
        {
            team team1 = new team("Bayern Munich", "Germany", "Munich");
            teams.Add(team1);
            team team2 = new team("Real Madrid", "Spain", "Madrid");
            teams.Add(team2);
            team team3 = new team("Barcelona", "Spain", "Barcelona");
            teams.Add(team3);
            foreach (team team in teams)
            {
                if (!comboBox_country.Items.Contains(team.teamCountry))
                {
                    comboBox_country.Items.Add(team.teamCountry);
                }
            }
            player player1 = new player("Manuel Neuer", "01", "GK");
            team1.players.Add(player1);
            player player2 = new player("Dayot Upamecano", "02", "DF");
            team1.players.Add(player2);
            player player3 = new player("Matthjis de Ligt", "04", "DF");
            team1.players.Add(player3);
            player player4 = new player("Benjamin Pavard", "05", "DF");
            team1.players.Add(player4);
            player player5 = new player("Joshua Kimmich", "06", "MF");
            team1.players.Add(player5);
            player player6 = new player("Serge Gnarby", "07", "FW");
            team1.players.Add(player6);
            player player7 = new player("Leon Goretzka", "08", "MF");
            team1.players.Add(player7);
            player player8 = new player("Leroy Sane", "10", "FW");
            team1.players.Add(player8);
            player player9 = new player("Paul Wanner", "14", "MF");
            team1.players.Add(player9);
            player player10 = new player("Lucas Hernandez", "21", "DF");
            team1.players.Add(player10);
            player player11 = new player("Thomas Muller", "25", "FW");
            team1.players.Add(player11);

            player player1_2 = new player("Thibaut Courtois", "01", "GK");
            team2.players.Add(player1_2);
            player player2_2= new player("Daniel Carvajal Ramos", "02", "DF");
            team2.players.Add(player2_2);
            player player3_2 = new player("Eder Gabriel Militao", "03", "DF");
            team2.players.Add(player3_2);
            player player4_2 = new player("David Alaba", "04", "DF");
            team2.players.Add(player4_2);
            player player5_2 = new player("Jesus Vallejo Lazaro", "05", "DF");
            team2.players.Add(player5_2);
            player player6_2 = new player("Jose I.Fernandez Iglesias", "06", "DF");
            team2.players.Add(player6_2);
            player player7_2 = new player("Eden Hazard", "07", "Fw");
            team2.players.Add(player7_2);
            player player8_2 = new player("Toni Kroos", "08", "MDF");
            team2.players.Add(player8_2);
            player player9_2 = new player("Karim Benzema", "09", "FW");
            team2.players.Add(player9_2);
            player player10_2 = new player("Luka Modric", "10", "MDF");
            team2.players.Add(player10_2);
            player player11_2 = new player("Marco Asensio Willemsen", "11", "FW");
            team2.players.Add(player11_2);

            player player1_3 = new player("Marc-André ter Stegen", "01", "GK");
            team3.players.Add(player1_3);
            player player2_3 = new player("Ronald Araújo", "02", "DF");
            team3.players.Add(player2_3);
            player player3_3 = new player("Sergio Busquets", "03", "DF");
            team3.players.Add(player3_3);
            player player4_3 = new player("David Alaba", "04", "DF");
            team3.players.Add(player4_3);
            player player5_3 = new player("Eric García", "05", "DF");
            team3.players.Add(player5_3);
            player player6_3 = new player("Alejandro Balde", "06", "DF");
            team3.players.Add(player6_3);
            player player7_3 = new player("Marcos Alonso", "07", "Fw");
            team3.players.Add(player7_3);
            player player8_3 = new player("Jordi Alba", "08", "MDF");
            team3.players.Add(player8_3);
            player player9_3 = new player("Sergi Roberto", "09", "FW");
            team3.players.Add(player9_3);
            player player10_3 = new player("Sergio Busquets", "10", "MDF");
            team3.players.Add(player10_3);
            player player11_3 = new player("Pedri", "11", "FW");
            team3.players.Add(player11_3);
        }

        private void button_addteam_Click(object sender, EventArgs e)
        {
            if (textBox_teamname.Text == "" || textBox_teamcountry.Text == "" || textBox_teamcity.Text == "")
            {
                MessageBox.Show("Please fill all the blank","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool bmn = false;
                //comboBox_country.Items.Clear();
                team Team = new team(textBox_teamname.Text,textBox_teamcountry.Text,textBox_teamcity.Text);
                
                foreach(team a in teams)
                {
                    if (a.teamName==textBox_teamname.Text && a.teamCountry==textBox_teamcountry.Text)
                    {
                        MessageBox.Show("Team name has existed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bmn = true;
                    }

                }
                if (bmn==false)
                {
                    teams.Add(Team);
                    if(!comboBox_country.Items.Contains(Team.teamCountry))
                    {
                        comboBox_country.Items.Add(Team.teamCountry);
                    }
                }

            }
        }

        private void comboBox_country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string choseCountry = comboBox_country.Text;
            comboBox_team.Items.Clear();
            foreach (team team in teams)
            {
                if (team.teamCountry == choseCountry)
                {
                    comboBox_team.Items.Add(team.teamName);
                }
            }
        }

        private void comboBox_team_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            listBox_teamlist.Items.Clear();
            foreach(team b in teams)
            {
                if (b.teamName == comboBox_team.Text)
                {
                    foreach(player pemain in b.players)
                    {
                        listBox_teamlist.Items.Add("(" + pemain.playerNum + ") " + pemain.playerName + ", " + pemain.playerPos);
                        listBox_teamlist.Sorted = true;
                    }
                    break;
                }
            }

        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if(listBox_teamlist.Items.Count <= 11)
            {
                MessageBox.Show("Player number are less than 11, player can't be remove", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach(team teamm in teams)
                {
                    if(teamm.teamName == comboBox_team.Text)
                    {
                        foreach(player play in teamm.players)
                        {
                            if(listBox_teamlist.SelectedItem.ToString().Contains(play.playerName))
                            {
                                teamm.players.Remove(play);
                                break;
                            }
                        }
                    }
                }
            }
            listBox_teamlist.Items.RemoveAt(listBox_teamlist.SelectedIndex);
        }

        private void button_addplayer_Click(object sender, EventArgs e)
        {
            bool abc = false;
            if (comboBox_team.Text == "")
            {
                MessageBox.Show("Please select the team", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (textBox_playername.Text == "" || textBox_playernum.Text == "" || comboBox_position.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in the blank", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    player newPlayer = new player(textBox_playername.Text, textBox_playernum.Text, comboBox_position.Text);
                    foreach (team tim in teams)
                    {
                        if (tim.teamName == comboBox_team.Text)
                        {
                            foreach (player play in tim.players)
                            {
                                if (play.playerNum == textBox_playernum.Text)
                                {
                                    abc = false;
                                }
                            }
                            if (abc == false)
                            {
                                tim.players.Add(newPlayer);
                            }
                            else
                            {
                                MessageBox.Show("try again");
                            }
                            break;
                        }
                    }
                    listBox_teamlist.Items.Clear();
                    foreach (team b in teams)
                    {
                        if (b.teamName == comboBox_team.Text)
                        {
                            foreach (player pemain in b.players)
                            {
                                listBox_teamlist.Items.Add("(" + pemain.playerNum + ") " + pemain.playerName + ", " + pemain.playerPos);
                                listBox_teamlist.Sorted = true;
                            }
                            break;
                        }
                    }
                }
            }

        }

        private void comboBox_country_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_team_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
    
    class team
    {
        public string teamName { get; set; }
        public string teamCountry { get; set; }
        public string teamCity { get; set; }

        public List<player> players =new List<player>();
    public team(string teamName, string teamCountry, string teamCity)
    {
        this.teamName = teamName;
        this.teamCountry = teamCountry;
        this.teamCity = teamCity;
    }
}
    class player
    {
        public string playerName { get; set; }
        public string playerNum { get; set; }
        public string playerPos { get; set; }
    public player(string playerName, string playerNum, string playerPos)
    {
        this.playerNum = playerNum;
        this.playerName =playerName;
        this.playerPos = playerPos;
    }
}

    

