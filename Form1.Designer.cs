namespace THA_W8_Carren_H
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_team = new System.Windows.Forms.ComboBox();
            this.comboBox_playerName = new System.Windows.Forms.ComboBox();
            this.panel_playerdata = new System.Windows.Forms.Panel();
            this.label_yellowjwbn = new System.Windows.Forms.Label();
            this.label_penaltyjwbn = new System.Windows.Forms.Label();
            this.label_goalsjwbn = new System.Windows.Forms.Label();
            this.label_redjwbn = new System.Windows.Forms.Label();
            this.label_playingjwbn = new System.Windows.Forms.Label();
            this.label_natjwbn = new System.Windows.Forms.Label();
            this.label_plyrpos = new System.Windows.Forms.Label();
            this.label_teamjwbn = new System.Windows.Forms.Label();
            this.label_plyrjwbn = new System.Windows.Forms.Label();
            this.label_yellow = new System.Windows.Forms.Label();
            this.label_penalty = new System.Windows.Forms.Label();
            this.label_gol = new System.Windows.Forms.Label();
            this.label_red = new System.Windows.Forms.Label();
            this.label_plypos = new System.Windows.Forms.Label();
            this.label_nationality = new System.Windows.Forms.Label();
            this.label_position = new System.Windows.Forms.Label();
            this.label_plyrteam = new System.Windows.Forms.Label();
            this.label_plyrname = new System.Windows.Forms.Label();
            this.panel_matchdetail = new System.Windows.Forms.Panel();
            this.dgv_detail = new System.Windows.Forms.DataGridView();
            this.cb_matchid = new System.Windows.Forms.ComboBox();
            this.dataGridView_matchdetail = new System.Windows.Forms.DataGridView();
            this.dataGridView_matchdetail1 = new System.Windows.Forms.DataGridView();
            this.comboBox_namatim = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel_playerdata.SuspendLayout();
            this.panel_matchdetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_matchdetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_matchdetail1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerDataToolStripMenuItem,
            this.matchDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerDataToolStripMenuItem
            // 
            this.playerDataToolStripMenuItem.Name = "playerDataToolStripMenuItem";
            this.playerDataToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.playerDataToolStripMenuItem.Text = "Player Data ";
            this.playerDataToolStripMenuItem.Click += new System.EventHandler(this.playerDataToolStripMenuItem_Click_1);
            // 
            // matchDetailsToolStripMenuItem
            // 
            this.matchDetailsToolStripMenuItem.Name = "matchDetailsToolStripMenuItem";
            this.matchDetailsToolStripMenuItem.Size = new System.Drawing.Size(140, 29);
            this.matchDetailsToolStripMenuItem.Text = "Match Details ";
            this.matchDetailsToolStripMenuItem.Click += new System.EventHandler(this.matchDetailsToolStripMenuItem_Click);
            // 
            // comboBox_team
            // 
            this.comboBox_team.FormattingEnabled = true;
            this.comboBox_team.Location = new System.Drawing.Point(25, 20);
            this.comboBox_team.Name = "comboBox_team";
            this.comboBox_team.Size = new System.Drawing.Size(274, 28);
            this.comboBox_team.TabIndex = 1;
            this.comboBox_team.SelectedIndexChanged += new System.EventHandler(this.comboBox_team_SelectedIndexChanged);
            // 
            // comboBox_playerName
            // 
            this.comboBox_playerName.FormattingEnabled = true;
            this.comboBox_playerName.Location = new System.Drawing.Point(467, 20);
            this.comboBox_playerName.Name = "comboBox_playerName";
            this.comboBox_playerName.Size = new System.Drawing.Size(276, 28);
            this.comboBox_playerName.TabIndex = 2;
            this.comboBox_playerName.SelectedIndexChanged += new System.EventHandler(this.comboBox_playerName_SelectedIndexChanged);
            // 
            // panel_playerdata
            // 
            this.panel_playerdata.Controls.Add(this.label_yellowjwbn);
            this.panel_playerdata.Controls.Add(this.label_penaltyjwbn);
            this.panel_playerdata.Controls.Add(this.label_goalsjwbn);
            this.panel_playerdata.Controls.Add(this.label_redjwbn);
            this.panel_playerdata.Controls.Add(this.label_playingjwbn);
            this.panel_playerdata.Controls.Add(this.label_natjwbn);
            this.panel_playerdata.Controls.Add(this.label_plyrpos);
            this.panel_playerdata.Controls.Add(this.label_teamjwbn);
            this.panel_playerdata.Controls.Add(this.label_plyrjwbn);
            this.panel_playerdata.Controls.Add(this.label_yellow);
            this.panel_playerdata.Controls.Add(this.label_penalty);
            this.panel_playerdata.Controls.Add(this.label_gol);
            this.panel_playerdata.Controls.Add(this.label_red);
            this.panel_playerdata.Controls.Add(this.label_plypos);
            this.panel_playerdata.Controls.Add(this.label_nationality);
            this.panel_playerdata.Controls.Add(this.label_position);
            this.panel_playerdata.Controls.Add(this.label_plyrteam);
            this.panel_playerdata.Controls.Add(this.label_plyrname);
            this.panel_playerdata.Controls.Add(this.comboBox_team);
            this.panel_playerdata.Controls.Add(this.comboBox_playerName);
            this.panel_playerdata.Location = new System.Drawing.Point(24, 36);
            this.panel_playerdata.Name = "panel_playerdata";
            this.panel_playerdata.Size = new System.Drawing.Size(776, 402);
            this.panel_playerdata.TabIndex = 4;
            // 
            // label_yellowjwbn
            // 
            this.label_yellowjwbn.AutoSize = true;
            this.label_yellowjwbn.Location = new System.Drawing.Point(200, 351);
            this.label_yellowjwbn.Name = "label_yellowjwbn";
            this.label_yellowjwbn.Size = new System.Drawing.Size(99, 20);
            this.label_yellowjwbn.TabIndex = 20;
            this.label_yellowjwbn.Text = "__________";
            // 
            // label_penaltyjwbn
            // 
            this.label_penaltyjwbn.AutoSize = true;
            this.label_penaltyjwbn.Location = new System.Drawing.Point(200, 313);
            this.label_penaltyjwbn.Name = "label_penaltyjwbn";
            this.label_penaltyjwbn.Size = new System.Drawing.Size(99, 20);
            this.label_penaltyjwbn.TabIndex = 19;
            this.label_penaltyjwbn.Text = "__________";
            // 
            // label_goalsjwbn
            // 
            this.label_goalsjwbn.AutoSize = true;
            this.label_goalsjwbn.Location = new System.Drawing.Point(200, 277);
            this.label_goalsjwbn.Name = "label_goalsjwbn";
            this.label_goalsjwbn.Size = new System.Drawing.Size(99, 20);
            this.label_goalsjwbn.TabIndex = 18;
            this.label_goalsjwbn.Text = "__________";
            // 
            // label_redjwbn
            // 
            this.label_redjwbn.AutoSize = true;
            this.label_redjwbn.Location = new System.Drawing.Point(200, 248);
            this.label_redjwbn.Name = "label_redjwbn";
            this.label_redjwbn.Size = new System.Drawing.Size(99, 20);
            this.label_redjwbn.TabIndex = 17;
            this.label_redjwbn.Text = "__________";
            // 
            // label_playingjwbn
            // 
            this.label_playingjwbn.AutoSize = true;
            this.label_playingjwbn.Location = new System.Drawing.Point(200, 213);
            this.label_playingjwbn.Name = "label_playingjwbn";
            this.label_playingjwbn.Size = new System.Drawing.Size(99, 20);
            this.label_playingjwbn.TabIndex = 16;
            this.label_playingjwbn.Text = "__________";
            // 
            // label_natjwbn
            // 
            this.label_natjwbn.AutoSize = true;
            this.label_natjwbn.Location = new System.Drawing.Point(200, 177);
            this.label_natjwbn.Name = "label_natjwbn";
            this.label_natjwbn.Size = new System.Drawing.Size(99, 20);
            this.label_natjwbn.TabIndex = 15;
            this.label_natjwbn.Text = "__________";
            // 
            // label_plyrpos
            // 
            this.label_plyrpos.AutoSize = true;
            this.label_plyrpos.Location = new System.Drawing.Point(200, 143);
            this.label_plyrpos.Name = "label_plyrpos";
            this.label_plyrpos.Size = new System.Drawing.Size(99, 20);
            this.label_plyrpos.TabIndex = 14;
            this.label_plyrpos.Text = "__________";
            // 
            // label_teamjwbn
            // 
            this.label_teamjwbn.AutoSize = true;
            this.label_teamjwbn.Location = new System.Drawing.Point(200, 110);
            this.label_teamjwbn.Name = "label_teamjwbn";
            this.label_teamjwbn.Size = new System.Drawing.Size(99, 20);
            this.label_teamjwbn.TabIndex = 13;
            this.label_teamjwbn.Text = "__________";
            // 
            // label_plyrjwbn
            // 
            this.label_plyrjwbn.AutoSize = true;
            this.label_plyrjwbn.Location = new System.Drawing.Point(200, 75);
            this.label_plyrjwbn.Name = "label_plyrjwbn";
            this.label_plyrjwbn.Size = new System.Drawing.Size(99, 20);
            this.label_plyrjwbn.TabIndex = 12;
            this.label_plyrjwbn.Text = "__________";
            // 
            // label_yellow
            // 
            this.label_yellow.AutoSize = true;
            this.label_yellow.Location = new System.Drawing.Point(21, 351);
            this.label_yellow.Name = "label_yellow";
            this.label_yellow.Size = new System.Drawing.Size(93, 20);
            this.label_yellow.TabIndex = 11;
            this.label_yellow.Text = "Yellow Card";
            // 
            // label_penalty
            // 
            this.label_penalty.AutoSize = true;
            this.label_penalty.Location = new System.Drawing.Point(21, 313);
            this.label_penalty.Name = "label_penalty";
            this.label_penalty.Size = new System.Drawing.Size(115, 20);
            this.label_penalty.TabIndex = 10;
            this.label_penalty.Text = "Penalty Missed";
            // 
            // label_gol
            // 
            this.label_gol.AutoSize = true;
            this.label_gol.Location = new System.Drawing.Point(21, 277);
            this.label_gol.Name = "label_gol";
            this.label_gol.Size = new System.Drawing.Size(106, 20);
            this.label_gol.TabIndex = 9;
            this.label_gol.Text = "Goals Scored";
            // 
            // label_red
            // 
            this.label_red.AutoSize = true;
            this.label_red.Location = new System.Drawing.Point(21, 248);
            this.label_red.Name = "label_red";
            this.label_red.Size = new System.Drawing.Size(85, 20);
            this.label_red.TabIndex = 8;
            this.label_red.Text = "Red Cards";
            // 
            // label_plypos
            // 
            this.label_plypos.AutoSize = true;
            this.label_plypos.Location = new System.Drawing.Point(21, 213);
            this.label_plypos.Name = "label_plypos";
            this.label_plypos.Size = new System.Drawing.Size(89, 20);
            this.label_plypos.TabIndex = 7;
            this.label_plypos.Text = "Playing pos";
            // 
            // label_nationality
            // 
            this.label_nationality.AutoSize = true;
            this.label_nationality.Location = new System.Drawing.Point(21, 177);
            this.label_nationality.Name = "label_nationality";
            this.label_nationality.Size = new System.Drawing.Size(82, 20);
            this.label_nationality.TabIndex = 6;
            this.label_nationality.Text = "Nationality";
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Location = new System.Drawing.Point(21, 143);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(65, 20);
            this.label_position.TabIndex = 5;
            this.label_position.Text = "Position";
            // 
            // label_plyrteam
            // 
            this.label_plyrteam.AutoSize = true;
            this.label_plyrteam.Location = new System.Drawing.Point(21, 110);
            this.label_plyrteam.Name = "label_plyrteam";
            this.label_plyrteam.Size = new System.Drawing.Size(96, 20);
            this.label_plyrteam.TabIndex = 4;
            this.label_plyrteam.Text = "Player Team";
            // 
            // label_plyrname
            // 
            this.label_plyrname.AutoSize = true;
            this.label_plyrname.Location = new System.Drawing.Point(21, 75);
            this.label_plyrname.Name = "label_plyrname";
            this.label_plyrname.Size = new System.Drawing.Size(98, 20);
            this.label_plyrname.TabIndex = 3;
            this.label_plyrname.Text = "Player Name";
            // 
            // panel_matchdetail
            // 
            this.panel_matchdetail.Controls.Add(this.dgv_detail);
            this.panel_matchdetail.Controls.Add(this.cb_matchid);
            this.panel_matchdetail.Controls.Add(this.dataGridView_matchdetail);
            this.panel_matchdetail.Controls.Add(this.dataGridView_matchdetail1);
            this.panel_matchdetail.Controls.Add(this.comboBox_namatim);
            this.panel_matchdetail.Location = new System.Drawing.Point(24, 36);
            this.panel_matchdetail.Name = "panel_matchdetail";
            this.panel_matchdetail.Size = new System.Drawing.Size(871, 669);
            this.panel_matchdetail.TabIndex = 21;
            // 
            // dgv_detail
            // 
            this.dgv_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detail.Location = new System.Drawing.Point(193, 396);
            this.dgv_detail.Name = "dgv_detail";
            this.dgv_detail.RowHeadersWidth = 62;
            this.dgv_detail.RowTemplate.Height = 28;
            this.dgv_detail.Size = new System.Drawing.Size(522, 270);
            this.dgv_detail.TabIndex = 4;
            // 
            // cb_matchid
            // 
            this.cb_matchid.FormattingEnabled = true;
            this.cb_matchid.Location = new System.Drawing.Point(273, 33);
            this.cb_matchid.Name = "cb_matchid";
            this.cb_matchid.Size = new System.Drawing.Size(198, 28);
            this.cb_matchid.TabIndex = 3;
            this.cb_matchid.SelectedIndexChanged += new System.EventHandler(this.cb_matchid_SelectedIndexChanged);
            // 
            // dataGridView_matchdetail
            // 
            this.dataGridView_matchdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_matchdetail.Location = new System.Drawing.Point(478, 85);
            this.dataGridView_matchdetail.Name = "dataGridView_matchdetail";
            this.dataGridView_matchdetail.RowHeadersWidth = 62;
            this.dataGridView_matchdetail.RowTemplate.Height = 28;
            this.dataGridView_matchdetail.Size = new System.Drawing.Size(360, 305);
            this.dataGridView_matchdetail.TabIndex = 2;
            // 
            // dataGridView_matchdetail1
            // 
            this.dataGridView_matchdetail1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_matchdetail1.Location = new System.Drawing.Point(25, 85);
            this.dataGridView_matchdetail1.Name = "dataGridView_matchdetail1";
            this.dataGridView_matchdetail1.RowHeadersWidth = 62;
            this.dataGridView_matchdetail1.RowTemplate.Height = 28;
            this.dataGridView_matchdetail1.Size = new System.Drawing.Size(360, 305);
            this.dataGridView_matchdetail1.TabIndex = 1;
            // 
            // comboBox_namatim
            // 
            this.comboBox_namatim.FormattingEnabled = true;
            this.comboBox_namatim.Location = new System.Drawing.Point(14, 33);
            this.comboBox_namatim.Name = "comboBox_namatim";
            this.comboBox_namatim.Size = new System.Drawing.Size(213, 28);
            this.comboBox_namatim.TabIndex = 0;
            this.comboBox_namatim.SelectedIndexChanged += new System.EventHandler(this.comboBox_namatim_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 717);
            this.Controls.Add(this.panel_matchdetail);
            this.Controls.Add(this.panel_playerdata);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_playerdata.ResumeLayout(false);
            this.panel_playerdata.PerformLayout();
            this.panel_matchdetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_matchdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_matchdetail1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchDetailsToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox_team;
        private System.Windows.Forms.ComboBox comboBox_playerName;
        private System.Windows.Forms.Panel panel_playerdata;
        private System.Windows.Forms.Label label_red;
        private System.Windows.Forms.Label label_plypos;
        private System.Windows.Forms.Label label_nationality;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Label label_plyrteam;
        private System.Windows.Forms.Label label_plyrname;
        private System.Windows.Forms.Label label_yellowjwbn;
        private System.Windows.Forms.Label label_penaltyjwbn;
        private System.Windows.Forms.Label label_goalsjwbn;
        private System.Windows.Forms.Label label_redjwbn;
        private System.Windows.Forms.Label label_playingjwbn;
        private System.Windows.Forms.Label label_natjwbn;
        private System.Windows.Forms.Label label_plyrpos;
        private System.Windows.Forms.Label label_teamjwbn;
        private System.Windows.Forms.Label label_plyrjwbn;
        private System.Windows.Forms.Label label_yellow;
        private System.Windows.Forms.Label label_penalty;
        private System.Windows.Forms.Label label_gol;
        private System.Windows.Forms.Panel panel_matchdetail;
        private System.Windows.Forms.DataGridView dataGridView_matchdetail;
        private System.Windows.Forms.DataGridView dataGridView_matchdetail1;
        private System.Windows.Forms.ComboBox comboBox_namatim;
        private System.Windows.Forms.ComboBox cb_matchid;
        private System.Windows.Forms.DataGridView dgv_detail;
    }
}

