using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace THA_W8_Carren_H
{
    public partial class Form1 : Form
    {

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter SqlDataAdapter;
        string ConnectionString;
        string sqlQuery;
        DataTable dtpemain = new DataTable();
        DataTable dtplayer = new DataTable();
        DataTable dtTeam = new DataTable();
        DataTable dtmatch = new DataTable();
        DataTable dtmatch1 = new DataTable();
        DataTable dtplay = new DataTable();
        DataTable dtplay2 = new DataTable();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_playerdata.Visible = false;
            panel_matchdetail.Visible = false;
            ConnectionString = "server = 127.0.0.1; uid=root;pwd=carren2004;database=premier_league";
            sqlConnect = new MySqlConnection(ConnectionString);
            sqlConnect.Open();



        }

        private void playerDataToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel_playerdata.Visible = true;
            panel_matchdetail.Visible = false;

            sqlQuery = "select t.team_name , t.team_id from team t;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            SqlDataAdapter.Fill(dtTeam);
            comboBox_team.DataSource = dtTeam;
            comboBox_team.DisplayMember = "team_name";
            comboBox_team.ValueMember = "team_id";




        }

        private void matchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_playerdata.Visible = false;
            panel_matchdetail.Visible = true;

            sqlQuery = $"select team_name,team_id from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            SqlDataAdapter.Fill(dtTeam);
            comboBox_namatim.DataSource = dtTeam;
            comboBox_namatim.DisplayMember = "team_name";
            comboBox_namatim.ValueMember = "team_id";


        }

        private void comboBox_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtplayer.Clear();
            sqlQuery = $"select p.player_name, p.player_id from player p, team t where t.team_id = p.team_id and '{comboBox_team.SelectedValue.ToString()}' = p.team_id ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            SqlDataAdapter.Fill(dtplayer);
            comboBox_playerName.DataSource = dtplayer;
            comboBox_playerName.DisplayMember = "player_name";
            comboBox_playerName.ValueMember = "player_id";

        }

        private void comboBox_playerName_SelectedIndexChanged(object sender, EventArgs e)
        {

            dtplay = new DataTable();
            string save = comboBox_playerName.GetItemText(comboBox_playerName.SelectedItem).ToString();
            string saveteam = comboBox_team.GetItemText(comboBox_team.SelectedItem).ToString();

            sqlQuery = $"SELECT p.player_name as 'nama player', t.team_name as 'nama team', n.nation as 'nationality',p.playing_pos as 'play',p.team_number as 'squad number' FROM player p,nationality n,team t where player_name = '{save}' and team_name = '{saveteam}' and p.nationality_id = n.nationality_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            SqlDataAdapter.Fill(dtplay);
            label_plyrjwbn.Text = dtplay.Rows[0][0].ToString();
            label_teamjwbn.Text = dtplay.Rows[0][1].ToString();
            label_plyrpos.Text = dtplay.Rows[0][3].ToString();
            label_natjwbn.Text = dtplay.Rows[0][2].ToString();
            label_playingjwbn.Text = dtplay.Rows[0][4].ToString();

            dtplay = new DataTable();

            sqlQuery = $"select p.player_name,t.team_name,n.nation,p.playing_pos,sum(if (d.type='CY',1,0)) as 'cy',sum(if(d.type='CR',1,0)) as'cr',sum(if(d.type='GO',1,0)) as 'go', sum(if(d.type='PM',1,0)) as 'pm'from player p,team t,dmatch d,nationality n where p.team_id=t.team_id and d.player_id=p.player_id and p.nationality_id=n.nationality_id and d.team_id=t.team_id and p.player_id= '{comboBox_playerName.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            SqlDataAdapter.Fill(dtplay);

            if (dtplay.Rows[0]["cr"].ToString().Length >= 1)
            {
                label_redjwbn.Text = dtplay.Rows[0]["cr"].ToString();
            }
            if (dtplay.Rows[0]["go"].ToString().Length >= 1)
            {
                label_goalsjwbn.Text = dtplay.Rows[0]["go"].ToString();
            }
            if (dtplay.Rows[0]["pm"].ToString().Length >= 1)
            {
                label_penaltyjwbn.Text = dtplay.Rows[0]["pm"].ToString();
            }
            if (dtplay.Rows[0]["cy"].ToString().Length >= 1)
            {
                label_yellowjwbn.Text = dtplay.Rows[0]["cy"].ToString();
            }

        }
        int count = 0;
        private void comboBox_namatim_SelectedIndexChanged(object sender, EventArgs e)
        {

            dtplayer.Clear();
            sqlQuery = $"select d.match_id from dmatch d, `match` m , `match` n WHERE d.match_id = m.match_id AND (m.team_home = d.team_id or m.team_away = d.team_id) AND d.team_id = '{comboBox_namatim.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            SqlDataAdapter.Fill(dtplayer);
            cb_matchid.DataSource = dtplayer;
            cb_matchid.ValueMember = "match_id";
            cb_matchid.DisplayMember = "match_id";


        }

        private void cb_matchid_SelectedIndexChanged(object sender, EventArgs e)
        {

            sqlQuery = $"select t.team_name as'Away Team',p.player_name as 'Player Name',p.playing_pos as'Playing Position'from `match`m,team t,player p where p.team_id=t.team_id and t.team_id=m.team_away and m.match_id=" + $"'{cb_matchid.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            SqlDataAdapter.Fill(dtmatch);
            dataGridView_matchdetail.DataSource = dtmatch;

            sqlQuery = $"select t.team_name as'Home Team',p.player_name as 'Player Name',p.playing_pos as'Playing Position'from `match`m,team t,player p where p.team_id=t.team_id and t.team_id=m.team_home and m.match_id=" + $"'{cb_matchid.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            SqlDataAdapter.Fill(dtmatch1);
            dataGridView_matchdetail1.DataSource = dtmatch1;

            sqlQuery = $"select d.`Minute` as'Minutes',t.team_name as'Team Name',p.player_name as 'Player Name',if(d.type='CY','CY',if(d.type='CR','CR',if(d.type='GO','GO',if(d.type='GW','GW',if(d.type='Gp','GP','PM'))))) as 'Card types' from dmatch d,team t,player p  where d.team_id=t.team_id and d.player_id=p.player_id and d.match_id=" + $"'{cb_matchid.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            SqlDataAdapter.Fill(dtpemain);
            dgv_detail.DataSource = dtpemain;
        }
    }
}

