
namespace FootballAnalyst
{
    partial class FAnalyst
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_addNewPlayer = new System.Windows.Forms.Button();
            this.label_static = new System.Windows.Forms.Label();
            this.comboBox_playerPool = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_profile = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label_profile_weight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_profile_height = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_profile_nationality = new System.Windows.Forms.Label();
            this.label_static2 = new System.Windows.Forms.Label();
            this.label_profile_age = new System.Windows.Forms.Label();
            this.label_profile_clubName = new System.Windows.Forms.Label();
            this.label_profile_playerName = new System.Windows.Forms.Label();
            this.tabPage_matches = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button_addMatch = new System.Windows.Forms.Button();
            this.listBox_matches_matchList = new System.Windows.Forms.ListBox();
            this.button_saveMatch = new System.Windows.Forms.Button();
            this.button_tackle = new System.Windows.Forms.Button();
            this.button_duel = new System.Windows.Forms.Button();
            this.button_shot = new System.Windows.Forms.Button();
            this.button_dribble = new System.Windows.Forms.Button();
            this.button_pass = new System.Windows.Forms.Button();
            this.list_touches = new System.Windows.Forms.CheckedListBox();
            this.tabPage_analytics = new System.Windows.Forms.TabPage();
            this.label_analytics_tacklesCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_analytics_shotsCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_analytics_dribblesCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_analytics_passesCount = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label_analytics_tacklesPerMatch = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_analytics_shotsPerMatch = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_analytics_dribblesPerMatch = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_analytics_passesPerMatch = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_analytics_matchCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_addStats = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage_profile.SuspendLayout();
            this.tabPage_matches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPage_analytics.SuspendLayout();
            this.groupBox_addStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_addNewPlayer);
            this.splitContainer1.Panel1.Controls.Add(this.label_static);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_playerPool);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(1333, 585);
            this.splitContainer1.SplitterDistance = 55;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_addNewPlayer
            // 
            this.button_addNewPlayer.Location = new System.Drawing.Point(419, 18);
            this.button_addNewPlayer.Name = "button_addNewPlayer";
            this.button_addNewPlayer.Size = new System.Drawing.Size(206, 28);
            this.button_addNewPlayer.TabIndex = 2;
            this.button_addNewPlayer.Text = "Add Player";
            this.button_addNewPlayer.UseVisualStyleBackColor = true;
            this.button_addNewPlayer.Click += new System.EventHandler(this.button_addNewPlayer_Click);
            // 
            // label_static
            // 
            this.label_static.AutoSize = true;
            this.label_static.Location = new System.Drawing.Point(13, 18);
            this.label_static.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_static.Name = "label_static";
            this.label_static.Size = new System.Drawing.Size(56, 20);
            this.label_static.TabIndex = 1;
            this.label_static.Text = "Player:";
            // 
            // comboBox_playerPool
            // 
            this.comboBox_playerPool.FormattingEnabled = true;
            this.comboBox_playerPool.Location = new System.Drawing.Point(77, 18);
            this.comboBox_playerPool.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_playerPool.Name = "comboBox_playerPool";
            this.comboBox_playerPool.Size = new System.Drawing.Size(320, 28);
            this.comboBox_playerPool.TabIndex = 0;
            this.comboBox_playerPool.SelectedIndexChanged += new System.EventHandler(this.comboBox_playerPool_SelectedIndexChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_profile);
            this.tabControl.Controls.Add(this.tabPage_matches);
            this.tabControl.Controls.Add(this.tabPage_analytics);
            this.tabControl.Location = new System.Drawing.Point(0, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1333, 498);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_profile
            // 
            this.tabPage_profile.Controls.Add(this.label4);
            this.tabPage_profile.Controls.Add(this.label_profile_weight);
            this.tabPage_profile.Controls.Add(this.label2);
            this.tabPage_profile.Controls.Add(this.label_profile_height);
            this.tabPage_profile.Controls.Add(this.label1);
            this.tabPage_profile.Controls.Add(this.label_profile_nationality);
            this.tabPage_profile.Controls.Add(this.label_static2);
            this.tabPage_profile.Controls.Add(this.label_profile_age);
            this.tabPage_profile.Controls.Add(this.label_profile_clubName);
            this.tabPage_profile.Controls.Add(this.label_profile_playerName);
            this.tabPage_profile.Location = new System.Drawing.Point(4, 29);
            this.tabPage_profile.Name = "tabPage_profile";
            this.tabPage_profile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_profile.Size = new System.Drawing.Size(1325, 465);
            this.tabPage_profile.TabIndex = 0;
            this.tabPage_profile.Text = "Profile";
            this.tabPage_profile.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Weight:";
            // 
            // label_profile_weight
            // 
            this.label_profile_weight.AutoSize = true;
            this.label_profile_weight.Location = new System.Drawing.Point(101, 185);
            this.label_profile_weight.Name = "label_profile_weight";
            this.label_profile_weight.Size = new System.Drawing.Size(76, 20);
            this.label_profile_weight.TabIndex = 8;
            this.label_profile_weight.Text = "Unknown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Height:";
            // 
            // label_profile_height
            // 
            this.label_profile_height.AutoSize = true;
            this.label_profile_height.Location = new System.Drawing.Point(101, 152);
            this.label_profile_height.Name = "label_profile_height";
            this.label_profile_height.Size = new System.Drawing.Size(76, 20);
            this.label_profile_height.TabIndex = 6;
            this.label_profile_height.Text = "Unknown";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nationality:";
            // 
            // label_profile_nationality
            // 
            this.label_profile_nationality.AutoSize = true;
            this.label_profile_nationality.Location = new System.Drawing.Point(101, 121);
            this.label_profile_nationality.Name = "label_profile_nationality";
            this.label_profile_nationality.Size = new System.Drawing.Size(76, 20);
            this.label_profile_nationality.TabIndex = 4;
            this.label_profile_nationality.Text = "Unknown";
            // 
            // label_static2
            // 
            this.label_static2.AutoSize = true;
            this.label_static2.Location = new System.Drawing.Point(3, 92);
            this.label_static2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_static2.Name = "label_static2";
            this.label_static2.Size = new System.Drawing.Size(42, 20);
            this.label_static2.TabIndex = 3;
            this.label_static2.Text = "Age:";
            // 
            // label_profile_age
            // 
            this.label_profile_age.AutoSize = true;
            this.label_profile_age.Location = new System.Drawing.Point(101, 92);
            this.label_profile_age.Name = "label_profile_age";
            this.label_profile_age.Size = new System.Drawing.Size(76, 20);
            this.label_profile_age.TabIndex = 2;
            this.label_profile_age.Text = "Unknown";
            // 
            // label_profile_clubName
            // 
            this.label_profile_clubName.AutoSize = true;
            this.label_profile_clubName.Location = new System.Drawing.Point(3, 41);
            this.label_profile_clubName.Name = "label_profile_clubName";
            this.label_profile_clubName.Size = new System.Drawing.Size(51, 20);
            this.label_profile_clubName.TabIndex = 1;
            this.label_profile_clubName.Text = "Name";
            // 
            // label_profile_playerName
            // 
            this.label_profile_playerName.AutoSize = true;
            this.label_profile_playerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profile_playerName.Location = new System.Drawing.Point(3, 17);
            this.label_profile_playerName.Name = "label_profile_playerName";
            this.label_profile_playerName.Size = new System.Drawing.Size(61, 24);
            this.label_profile_playerName.TabIndex = 0;
            this.label_profile_playerName.Text = "Name";
            // 
            // tabPage_matches
            // 
            this.tabPage_matches.Controls.Add(this.splitContainer2);
            this.tabPage_matches.Location = new System.Drawing.Point(4, 29);
            this.tabPage_matches.Name = "tabPage_matches";
            this.tabPage_matches.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_matches.Size = new System.Drawing.Size(1325, 465);
            this.tabPage_matches.TabIndex = 1;
            this.tabPage_matches.Text = "Matches";
            this.tabPage_matches.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button_addMatch);
            this.splitContainer2.Panel1.Controls.Add(this.listBox_matches_matchList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox_addStats);
            this.splitContainer2.Panel2.Controls.Add(this.button_saveMatch);
            this.splitContainer2.Panel2.Controls.Add(this.list_touches);
            this.splitContainer2.Size = new System.Drawing.Size(1319, 459);
            this.splitContainer2.SplitterDistance = 204;
            this.splitContainer2.TabIndex = 0;
            // 
            // button_addMatch
            // 
            this.button_addMatch.Location = new System.Drawing.Point(10, 399);
            this.button_addMatch.Name = "button_addMatch";
            this.button_addMatch.Size = new System.Drawing.Size(191, 35);
            this.button_addMatch.TabIndex = 1;
            this.button_addMatch.Text = "Add a match";
            this.button_addMatch.UseVisualStyleBackColor = true;
            this.button_addMatch.Click += new System.EventHandler(this.button_addMatch_Click);
            // 
            // listBox_matches_matchList
            // 
            this.listBox_matches_matchList.FormattingEnabled = true;
            this.listBox_matches_matchList.ItemHeight = 20;
            this.listBox_matches_matchList.Location = new System.Drawing.Point(0, 0);
            this.listBox_matches_matchList.Name = "listBox_matches_matchList";
            this.listBox_matches_matchList.Size = new System.Drawing.Size(201, 384);
            this.listBox_matches_matchList.TabIndex = 0;
            this.listBox_matches_matchList.SelectedIndexChanged += new System.EventHandler(this.listBox_matches_matchList_SelectedIndexChanged);
            // 
            // button_saveMatch
            // 
            this.button_saveMatch.Location = new System.Drawing.Point(572, 399);
            this.button_saveMatch.Name = "button_saveMatch";
            this.button_saveMatch.Size = new System.Drawing.Size(216, 35);
            this.button_saveMatch.TabIndex = 6;
            this.button_saveMatch.Text = "Save Match";
            this.button_saveMatch.UseVisualStyleBackColor = true;
            this.button_saveMatch.Click += new System.EventHandler(this.button_saveMatch_Click);
            // 
            // button_tackle
            // 
            this.button_tackle.Location = new System.Drawing.Point(330, 11);
            this.button_tackle.Name = "button_tackle";
            this.button_tackle.Size = new System.Drawing.Size(75, 35);
            this.button_tackle.TabIndex = 5;
            this.button_tackle.Text = "Tackle";
            this.button_tackle.UseVisualStyleBackColor = true;
            this.button_tackle.Click += new System.EventHandler(this.button_tackle_Click);
            // 
            // button_duel
            // 
            this.button_duel.Location = new System.Drawing.Point(249, 11);
            this.button_duel.Name = "button_duel";
            this.button_duel.Size = new System.Drawing.Size(75, 35);
            this.button_duel.TabIndex = 4;
            this.button_duel.Text = "Duel";
            this.button_duel.UseVisualStyleBackColor = true;
            this.button_duel.Click += new System.EventHandler(this.button_duel_Click);
            // 
            // button_shot
            // 
            this.button_shot.Location = new System.Drawing.Point(168, 11);
            this.button_shot.Name = "button_shot";
            this.button_shot.Size = new System.Drawing.Size(75, 35);
            this.button_shot.TabIndex = 3;
            this.button_shot.Text = "Shot";
            this.button_shot.UseVisualStyleBackColor = true;
            this.button_shot.Click += new System.EventHandler(this.button_shot_Click);
            // 
            // button_dribble
            // 
            this.button_dribble.Location = new System.Drawing.Point(87, 11);
            this.button_dribble.Name = "button_dribble";
            this.button_dribble.Size = new System.Drawing.Size(75, 35);
            this.button_dribble.TabIndex = 2;
            this.button_dribble.Text = "Dribble";
            this.button_dribble.UseVisualStyleBackColor = true;
            this.button_dribble.Click += new System.EventHandler(this.button_dribble_Click);
            // 
            // button_pass
            // 
            this.button_pass.Location = new System.Drawing.Point(6, 11);
            this.button_pass.Name = "button_pass";
            this.button_pass.Size = new System.Drawing.Size(75, 35);
            this.button_pass.TabIndex = 1;
            this.button_pass.Text = "Pass";
            this.button_pass.UseVisualStyleBackColor = true;
            this.button_pass.Click += new System.EventHandler(this.button_pass_Click);
            // 
            // list_touches
            // 
            this.list_touches.FormattingEnabled = true;
            this.list_touches.Location = new System.Drawing.Point(3, 0);
            this.list_touches.Name = "list_touches";
            this.list_touches.Size = new System.Drawing.Size(785, 382);
            this.list_touches.TabIndex = 0;
            this.list_touches.SelectedIndexChanged += new System.EventHandler(this.list_touches_SelectedIndexChanged);
            // 
            // tabPage_analytics
            // 
            this.tabPage_analytics.Controls.Add(this.label_analytics_tacklesCount);
            this.tabPage_analytics.Controls.Add(this.label7);
            this.tabPage_analytics.Controls.Add(this.label_analytics_shotsCount);
            this.tabPage_analytics.Controls.Add(this.label11);
            this.tabPage_analytics.Controls.Add(this.label_analytics_dribblesCount);
            this.tabPage_analytics.Controls.Add(this.label13);
            this.tabPage_analytics.Controls.Add(this.label_analytics_passesCount);
            this.tabPage_analytics.Controls.Add(this.label16);
            this.tabPage_analytics.Controls.Add(this.label_analytics_tacklesPerMatch);
            this.tabPage_analytics.Controls.Add(this.label14);
            this.tabPage_analytics.Controls.Add(this.label_analytics_shotsPerMatch);
            this.tabPage_analytics.Controls.Add(this.label10);
            this.tabPage_analytics.Controls.Add(this.label_analytics_dribblesPerMatch);
            this.tabPage_analytics.Controls.Add(this.label8);
            this.tabPage_analytics.Controls.Add(this.label_analytics_passesPerMatch);
            this.tabPage_analytics.Controls.Add(this.label6);
            this.tabPage_analytics.Controls.Add(this.label_analytics_matchCount);
            this.tabPage_analytics.Controls.Add(this.label3);
            this.tabPage_analytics.Location = new System.Drawing.Point(4, 22);
            this.tabPage_analytics.Name = "tabPage_analytics";
            this.tabPage_analytics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_analytics.Size = new System.Drawing.Size(1325, 472);
            this.tabPage_analytics.TabIndex = 2;
            this.tabPage_analytics.Text = "Analytics";
            this.tabPage_analytics.UseVisualStyleBackColor = true;
            // 
            // label_analytics_tacklesCount
            // 
            this.label_analytics_tacklesCount.AutoSize = true;
            this.label_analytics_tacklesCount.Location = new System.Drawing.Point(559, 197);
            this.label_analytics_tacklesCount.Name = "label_analytics_tacklesCount";
            this.label_analytics_tacklesCount.Size = new System.Drawing.Size(0, 20);
            this.label_analytics_tacklesCount.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tackles (Successful):";
            // 
            // label_analytics_shotsCount
            // 
            this.label_analytics_shotsCount.AutoSize = true;
            this.label_analytics_shotsCount.Location = new System.Drawing.Point(559, 168);
            this.label_analytics_shotsCount.Name = "label_analytics_shotsCount";
            this.label_analytics_shotsCount.Size = new System.Drawing.Size(0, 20);
            this.label_analytics_shotsCount.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(394, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Shots (On Target):";
            // 
            // label_analytics_dribblesCount
            // 
            this.label_analytics_dribblesCount.AutoSize = true;
            this.label_analytics_dribblesCount.Location = new System.Drawing.Point(559, 139);
            this.label_analytics_dribblesCount.Name = "label_analytics_dribblesCount";
            this.label_analytics_dribblesCount.Size = new System.Drawing.Size(0, 20);
            this.label_analytics_dribblesCount.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(394, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Dribbles (Successful):";
            // 
            // label_analytics_passesCount
            // 
            this.label_analytics_passesCount.AutoSize = true;
            this.label_analytics_passesCount.Location = new System.Drawing.Point(559, 109);
            this.label_analytics_passesCount.Name = "label_analytics_passesCount";
            this.label_analytics_passesCount.Size = new System.Drawing.Size(0, 20);
            this.label_analytics_passesCount.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(394, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 20);
            this.label16.TabIndex = 11;
            this.label16.Text = "Passes (Accurate):";
            // 
            // label_analytics_tacklesPerMatch
            // 
            this.label_analytics_tacklesPerMatch.AutoSize = true;
            this.label_analytics_tacklesPerMatch.Location = new System.Drawing.Point(198, 197);
            this.label_analytics_tacklesPerMatch.Name = "label_analytics_tacklesPerMatch";
            this.label_analytics_tacklesPerMatch.Size = new System.Drawing.Size(0, 20);
            this.label_analytics_tacklesPerMatch.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Tackles per match:";
            // 
            // label_analytics_shotsPerMatch
            // 
            this.label_analytics_shotsPerMatch.AutoSize = true;
            this.label_analytics_shotsPerMatch.Location = new System.Drawing.Point(198, 168);
            this.label_analytics_shotsPerMatch.Name = "label_analytics_shotsPerMatch";
            this.label_analytics_shotsPerMatch.Size = new System.Drawing.Size(0, 20);
            this.label_analytics_shotsPerMatch.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Shots per match:";
            // 
            // label_analytics_dribblesPerMatch
            // 
            this.label_analytics_dribblesPerMatch.AutoSize = true;
            this.label_analytics_dribblesPerMatch.Location = new System.Drawing.Point(198, 139);
            this.label_analytics_dribblesPerMatch.Name = "label_analytics_dribblesPerMatch";
            this.label_analytics_dribblesPerMatch.Size = new System.Drawing.Size(0, 20);
            this.label_analytics_dribblesPerMatch.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Dribbles per match:";
            // 
            // label_analytics_passesPerMatch
            // 
            this.label_analytics_passesPerMatch.AutoSize = true;
            this.label_analytics_passesPerMatch.Location = new System.Drawing.Point(198, 109);
            this.label_analytics_passesPerMatch.Name = "label_analytics_passesPerMatch";
            this.label_analytics_passesPerMatch.Size = new System.Drawing.Size(0, 20);
            this.label_analytics_passesPerMatch.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Passes per match:";
            // 
            // label_analytics_matchCount
            // 
            this.label_analytics_matchCount.AutoSize = true;
            this.label_analytics_matchCount.Location = new System.Drawing.Point(198, 59);
            this.label_analytics_matchCount.Name = "label_analytics_matchCount";
            this.label_analytics_matchCount.Size = new System.Drawing.Size(18, 20);
            this.label_analytics_matchCount.TabIndex = 2;
            this.label_analytics_matchCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Matches scouted:";
            // 
            // groupBox_addStats
            // 
            this.groupBox_addStats.Controls.Add(this.button_pass);
            this.groupBox_addStats.Controls.Add(this.button_dribble);
            this.groupBox_addStats.Controls.Add(this.button_tackle);
            this.groupBox_addStats.Controls.Add(this.button_shot);
            this.groupBox_addStats.Controls.Add(this.button_duel);
            this.groupBox_addStats.Location = new System.Drawing.Point(3, 388);
            this.groupBox_addStats.Name = "groupBox_addStats";
            this.groupBox_addStats.Size = new System.Drawing.Size(421, 46);
            this.groupBox_addStats.TabIndex = 7;
            this.groupBox_addStats.TabStop = false;
            // 
            // FAnalyst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 585);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FAnalyst";
            this.Text = "FAnalyst 0.1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage_profile.ResumeLayout(false);
            this.tabPage_profile.PerformLayout();
            this.tabPage_matches.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPage_analytics.ResumeLayout(false);
            this.tabPage_analytics.PerformLayout();
            this.groupBox_addStats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBox_playerPool;
        private System.Windows.Forms.Label label_static;
        private System.Windows.Forms.Button button_addNewPlayer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_profile;
        private System.Windows.Forms.TabPage tabPage_matches;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label_profile_playerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_profile_nationality;
        private System.Windows.Forms.Label label_static2;
        private System.Windows.Forms.Label label_profile_age;
        private System.Windows.Forms.Label label_profile_clubName;
        private System.Windows.Forms.ListBox listBox_matches_matchList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_profile_weight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_profile_height;
        private System.Windows.Forms.CheckedListBox list_touches;
        private System.Windows.Forms.Button button_addMatch;
        private System.Windows.Forms.Button button_tackle;
        private System.Windows.Forms.Button button_duel;
        private System.Windows.Forms.Button button_shot;
        private System.Windows.Forms.Button button_dribble;
        private System.Windows.Forms.Button button_pass;
        private System.Windows.Forms.TabPage tabPage_analytics;
        private System.Windows.Forms.Button button_saveMatch;
        private System.Windows.Forms.Label label_analytics_tacklesCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_analytics_shotsCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_analytics_dribblesCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_analytics_passesCount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_analytics_tacklesPerMatch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_analytics_shotsPerMatch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_analytics_dribblesPerMatch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_analytics_passesPerMatch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_analytics_matchCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_addStats;
    }
}

