using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CA_W12
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter SqlDataAdapter;
        MySqlDataReader SqlDataReader;
        string sqlQuery;
        DataTable dtnat = new DataTable();
        DataTable dtTeam = new DataTable();
        DataTable dtTeam1 = new DataTable();
        DataTable dtmatch = new DataTable();
        DataTable dtmatch1 = new DataTable();
        DataTable dtmanager = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dtplayerdetail = new DataTable();
        DataTable dtplaydetail = new DataTable();
        string deleteplayers = "";
        public Form1()
        {
            string ConnectionString = "server = 127.0.0.1; uid=root;pwd=carren2004;database=premier_league";
            sqlConnect = new MySqlConnection(ConnectionString);
            InitializeComponent();
            dgv_allmanager.DataSource = dtmanager;
            dgv_detail.DataSource = dtmatch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            managersdgv();
            sqlQuery = "select nation, nationality_id from nationality;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            SqlDataAdapter.Fill(dtnat);
            comboBox_nationality.DataSource = dtnat;
            comboBox_nationality.DisplayMember = "nation";
            comboBox_nationality.ValueMember = "nationality_id";

            sqlQuery = "select team_name, team_id from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            dtTeam.Clear();
            SqlDataAdapter.Fill(dtTeam1);
            comboBox_teamName.DataSource = dtTeam1;
            comboBox_teamName.DisplayMember = "team_name";
            comboBox_teamName.ValueMember = "team_id";

            sqlQuery = "select team_name, team_id from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            dtTeam.Clear();
            SqlDataAdapter.Fill(dtTeam);
            comboBox_team.DataSource = dtTeam;
            comboBox_team.DisplayMember = "team_name";
            comboBox_team.ValueMember = "team_id";

            sqlQuery = "select team_name, team_id from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            SqlDataAdapter.Fill(dt1);
            comboBox_timNAme.DataSource = dt1;
            comboBox_timNAme.DisplayMember = "team_name";
            comboBox_timNAme.ValueMember = "team_id";

            string abc = comboBox_timNAme.Text.ToString();
            sqlQuery = $"select player_name, nation, playing_pos, team_number, height, weight, birthdate from player p, nationality n where p.nationality_id = n.nationality_id and p.team_id = '{comboBox_timNAme.SelectedValue.ToString()}' and status = 1; ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            SqlDataAdapter.Fill(dtplaydetail);
            dgv_playerDetail.DataSource = dtplaydetail;

        }

        private void managersdgv()
        {
            sqlQuery = $"SELECT manager_id, manager_name, n.nation, m.birthdate FROM manager m, nationality n where m.nationality_id = n.nationality_id and m.working = 0;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            SqlDataAdapter.Fill(dtmanager);
            dgv_allmanager.DataSource = dtmanager;

            sqlQuery = $"SELECT m.manager_id, m.manager_name, n.nation as nation, m.birthdate FROM manager m, team t, nationality n where m.manager_id = t.manager_id and m.nationality_id = n.nationality_id and t.team_id = '" + comboBox_team.SelectedValue + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            SqlDataAdapter.Fill(dtmatch1);
            dgv_detail.DataSource = dtmatch1;


        }
        private void comboBox_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtTeam = new DataTable();
            managersdgv();
        }

        private void button_add_Click(object sender, EventArgs e)
        {

            string stringtanggal = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            MessageBox.Show(textBox_playerID.Text.ToString());
            sqlQuery = $"insert into player values ('{textBox_playerID.Text}',{textBox_teamNum.Text},'{textBox_name.Text}','{comboBox_nationality.SelectedValue}','{textBox_pos.Text}',{textBox_height.Text},{textBox_weight.Text},{stringtanggal},'{comboBox_teamName.SelectedValue}', 1, 0)";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }


        private void button_update_Click(object sender, EventArgs e)
        {
            string id_manager = dgv_allmanager.CurrentRow.Cells[0].Value.ToString();
            string abc = $"update team set manager_id = '" + id_manager + "' where team_id = '" + comboBox_team.SelectedValue + "';";
            try
            {
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(abc, sqlConnect);
                SqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnect.Close();
            }

            string id_detail = dgv_detail.CurrentRow.Cells[0].Value.ToString();
            string x = $"update manager set working = 0 WHERE manager_id = '" + id_manager + "';";
            try
            {
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(x, sqlConnect);
                SqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnect.Close();
            }

            string y = $"update manager set working = 1 WHERE manager_id =  '" + id_detail + "';";

            try
            {
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(y, sqlConnect);
                SqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnect.Close();
                managersdgv();

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            dgv_playerDetail.DataSource = dtplaydetail;

            dtplaydetail = new DataTable();
            sqlQuery = $"select player_name, nation, playing_pos, team_number, height, weight, birthdate from player p, nationality n where p.nationality_id = n.nationality_id and p.team_id = '{comboBox_timNAme.SelectedValue.ToString()}' and status = 1; ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            SqlDataAdapter.Fill(dtplaydetail);
            dgv_playerDetail.DataSource = dtplaydetail;

            int count = 0;
            foreach (DataRow dt in dtplaydetail.Rows)
            {
                
                count++;
            }
            if (count <= 11)
            {
                MessageBox.Show("player is less than 11");
            }
            else
            {
                string delete = $"UPDATE player set status=0 WHERE player_name='{deleteplayers}';";

                try
                {
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(delete, sqlConnect);
                    SqlDataReader = sqlCommand.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dtplaydetail.Clear();
                    sqlConnect.Close();
                    string chooseteam = $"select player_name, nation, playing_pos, team_number, height, weight, birthdate from player p, nationality n where p.nationality_id = n.nationality_id and p.team_id = '{comboBox_timNAme.SelectedValue.ToString()}' and status = 1;";
                    sqlCommand = new MySqlCommand(chooseteam, sqlConnect);
                    SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    SqlDataAdapter.Fill(dtplaydetail);
                    dgv_playerDetail.DataSource = dtplaydetail;
                }
            }
            
        }

        private void comboBox_timNAme_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtplaydetail = new DataTable();
            sqlQuery = $"select player_name, nation, playing_pos, team_number, height, weight, birthdate from player p, nationality n where p.nationality_id = n.nationality_id and p.team_id = '{comboBox_timNAme.SelectedValue.ToString()}' and status = 1; ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            SqlDataAdapter.Fill(dtplaydetail);
            dgv_playerDetail.DataSource = dtplaydetail;
        }
    }
}


