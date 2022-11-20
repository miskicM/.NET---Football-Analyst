using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FootballAnalyst
{
    public partial class FAnalyst : Form
    {
        private BindingSource matchesBinding = new BindingSource();
        //DUMMY DATA START
        private List<Player> testPlayers = new List<Player>();
        //DUMMY DATA END

        private Player designatedPlayer;

        private Match designatedMatch;
        public FAnalyst()
        {
            InitializeComponent();
            //SetupDummyData();
            LoadPlayersFromDatabase();
        }

        private void SetupDummyData()
        {
            Player play = new Player("Lionel Suarez", "River Plate").SetNationality("Argentine");
            play.AddMatch(new Match("River", 2, 1, "Racing", new DateTime(2022, 4, 5)));
            play.AddMatch(new Match("Boca", 0, 0, "River", new DateTime(2022, 4, 12)));
            play.AddMatch(new Match("River", 4, 1, "Gimnasia", new DateTime(2022, 4, 18)));
            play.AddMatch(new Match("Sarmiento", 0, 2, "River", new DateTime(2022, 4, 22)));
            play.AddMatch(new Match("River", 2, 2, "Boca", new DateTime(2022, 4, 25)));
            play.AddMatch(new Match("Aldovisi", 0, 2, "River", new DateTime(2022, 4, 30)));
            testPlayers.Add(new Player("Cris Martinez", "River Plate").SetNationality("Argentine").SetHeight(179).SetWeight(81));
            testPlayers.Add(new Player("Michael Grey", "Crystal Palace"));
            testPlayers.Add(play);

            //TEMP
            foreach (Player player in testPlayers)
            {
                comboBox_playerPool.Items.Add(player.GetVisualTag());
            }
        }

        private void LoadPlayersFromDatabase()
        {
            //Load the players:
            testPlayers.AddRange(DatabaseAccessor.LoadAllPlayers());

            //Load their matches:
            foreach (Player player in testPlayers)
            {
                player.AddMatches(DatabaseAccessor.LoadAllMatchesFrom(player));
                //Load thier touches for each match:
                foreach (Match match in player.GetPlayerMatches())
                {
                    match.Touches.AddRange(DatabaseAccessor.LoadAllTouchesFrom(match));
                    if (match.Touches.Count > 0) match.SetSaved(true);
                }
            }

            //Add the players onto the ComboBox:
            foreach (Player player in testPlayers)
            {
                comboBox_playerPool.Items.Add(player.GetVisualTag());
            }
        }

        private void comboBox_playerPool_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchToPlayer((string)comboBox_playerPool.SelectedItem);
            LoadPlayerMatchData((string)comboBox_playerPool.SelectedItem);
            LoadAnalytics();
        }

        //Change the player data on all tabs
        private void SwitchToPlayer(string playerName)
        {
            Player selectedPlayer = null;
            foreach(Player player in testPlayers)
            {
                if (playerName.Equals(player.GetVisualTag()))
                {
                    selectedPlayer = player;
                    break;
                }
            }
            label_profile_playerName.Text = selectedPlayer.GetPlayerName();
            label_profile_clubName.Text = selectedPlayer.GetPlayerClub();
            label_profile_age.Text = selectedPlayer.GetPlayerAge();
            label_profile_nationality.Text = selectedPlayer.GetPlayerNationality();
            label_profile_height.Text = selectedPlayer.GetPlayerHeight();
            label_profile_weight.Text = selectedPlayer.GetPlayerWeight();

            designatedPlayer = selectedPlayer;

            if (selectedPlayer.GetPlayerMatches().Count > 0)
                designatedMatch = selectedPlayer.GetPlayerMatches().First();
            else 
                designatedMatch = null;
        }
        //Sets the matches tab to show selected players matches.
        private void LoadPlayerMatchData(string playerName)
        {
            Player selectedPlayer = null;
            foreach (Player player in testPlayers)
            {
                if (playerName.Equals(player.GetVisualTag()))
                {
                    selectedPlayer = player;
                    break;
                }
            }

            matchesBinding.DataSource = selectedPlayer.GetPlayerMatches();
            listBox_matches_matchList.DataSource = matchesBinding;
            listBox_matches_matchList.DisplayMember = "DisplayText";
            listBox_matches_matchList.ValueMember = "DisplayText";

        }

        //Refreshes the analytics tab with data on the selected player.
        private void LoadAnalytics()
        {
            double ppm, tpm, spm, dpm;       //per match
            int passes=0, tackles=0, shots=0, dribbles=0;               //overall
            int sPasses = 0, sTackles = 0, sShots = 0, sDribbles = 0;   //successful amount
            double pac, tac, sac, dac;     //success rate per stat
            int matchCount = designatedPlayer.GetPlayerMatches().Count; //Total num of matches

            if (matchCount < 1) return;

            foreach(Match match in designatedPlayer.GetPlayerMatches())
            {
                foreach(Touch touch in match.Touches)
                {
                    if (touch.TouchType.Equals(Touch.Type.Pass))
                    { 
                        passes++;
                        if (touch.Successful) sPasses++;
                    }
                    if (touch.TouchType.Equals(Touch.Type.Dribble))
                    { 
                        dribbles++;
                        if (touch.Successful) sDribbles++;
                    }
                    if (touch.TouchType.Equals(Touch.Type.Tackle))
                    { 
                        tackles++;
                        if (touch.Successful) sDribbles++;
                    }
                    if (touch.TouchType.Equals(Touch.Type.Shot))
                    { 
                        shots++;
                        if (touch.Successful) sShots++;
                    }
                }
            }
            //Stats per match:
            ppm = Math.Round((double)passes / matchCount, 2);
            tpm = Math.Round((double)tackles / matchCount, 2);
            spm = Math.Round((double)shots / matchCount, 2);
            dpm = Math.Round((double)dribbles / matchCount, 2);
            //Overall success per stat type:
            pac = Math.Round((double)sPasses / passes, 2)*100;
            tac = Math.Round((double)sTackles / tackles, 2)*100;
            sac = Math.Round((double)sShots / shots, 2)*100;
            dac = Math.Round((double)sDribbles / dribbles, 2)*100;
            //Display stats on the UI:

            label_analytics_matchCount.Text = matchCount.ToString();
            label_analytics_passesCount.Text = passes.ToString() +      "(" + pac + "%)";
            label_analytics_tacklesCount.Text = tackles.ToString() +    "(" + tac + "%)";
            label_analytics_shotsCount.Text = shots.ToString() +        "(" + sac + "%)";
            label_analytics_dribblesCount.Text = dribbles.ToString() +  "(" + dac + "%)";
            label_analytics_passesPerMatch.Text = ppm.ToString();
            label_analytics_tacklesPerMatch.Text = tpm.ToString();
            label_analytics_shotsPerMatch.Text = spm.ToString();
            label_analytics_dribblesPerMatch.Text = dpm.ToString();
        }

        private void LoadMatchPerformance()
        {
            list_touches.Items.Clear();
            if (designatedMatch == null) return;

            foreach (Touch touch in designatedMatch.Touches)
            {
                list_touches.Items.Add(touch.DisplayText());
            }    
        }
        public void RefreshInterface()
        {
            //TODO
        }

        //Creates a new player
        private void button_addNewPlayer_Click(object sender, EventArgs e)
        {
            PlayerForm pf = new PlayerForm(this);
            pf.ShowDialog();
        }

        //Creates a new match for the selected player
        private void button_addMatch_Click(object sender, EventArgs e)
        {
            if (designatedPlayer == null) return;
            MatchForm mf = new MatchForm(this,designatedPlayer);
            mf.ShowDialog();

        }

        //Saves all of the touches for the selected match into the database for further analysis
        private void button_saveMatch_Click(object sender, EventArgs e)
        {
            if (designatedPlayer == null) return;
            if (designatedMatch == null) return;
            if (designatedMatch.IsSaved()) return;

            DatabaseAccessor.UpdateMatchTouches(designatedMatch);
            DisabledMatchEditing(true);
        }

        //Display player performance for the currently selected match.
        private void listBox_matches_matchList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Match match in designatedPlayer.GetPlayerMatches())
            {
                Match selectedMatch = (Match)listBox_matches_matchList.SelectedItem;
                if (match.DisplayText.Equals(selectedMatch.DisplayText)) designatedMatch = match;
            }

            DisabledMatchEditing(designatedMatch.IsSaved()); //Bug Here: designated match is null

            LoadMatchPerformance();
        }

        private void list_touches_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO
        }

        public void UpdatePlayerPool()
        {
            testPlayers = DatabaseAccessor.LoadAllPlayers();
            comboBox_playerPool.Items.Clear();

            foreach(Player player in testPlayers)
                comboBox_playerPool.Items.Add(player.GetVisualTag());
        }

        //Touch recording buttons implementation.
        private void button_pass_Click(object sender, EventArgs e)
        {
            if (designatedMatch == null) return;
            PassForm pf = new PassForm(this,designatedMatch);
            pf.ShowDialog();
            LoadMatchPerformance();
        }

        private void button_dribble_Click(object sender, EventArgs e)
        {
            if (designatedMatch == null) return;
            DribbleForm df = new DribbleForm(this, designatedMatch);
            df.ShowDialog();
            LoadMatchPerformance();
        }

        private void button_shot_Click(object sender, EventArgs e)
        {
            if (designatedMatch == null) return;
            ShotForm sf = new ShotForm(this, designatedMatch);
            sf.ShowDialog();
            LoadMatchPerformance();
        }

        private void button_duel_Click(object sender, EventArgs e)
        {
            if (designatedMatch == null) return;
            DuelForm df = new DuelForm(this, designatedMatch);
            df.ShowDialog();
            LoadMatchPerformance();
        }

        private void button_tackle_Click(object sender, EventArgs e)
        {
            if (designatedMatch == null) return;
            TackleForm tf = new TackleForm(this, designatedMatch);
            tf.ShowDialog();
            LoadMatchPerformance();
        }

        private void DisabledMatchEditing(bool b)
        {
            groupBox_addStats.Enabled = !b;
            groupBox_addStats.Visible = !b;
        }
    }
}
