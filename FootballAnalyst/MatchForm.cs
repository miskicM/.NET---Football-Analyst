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
    public partial class MatchForm : Form
    {
        private FAnalyst analyst;
        private Player player;

        public MatchForm(FAnalyst fa, Player player)
        {
            InitializeComponent();
            analyst = fa;
            this.player = player;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string at = textBox_awayTeam.Text;
            string ht = textBox_homeTeam.Text;
            int ag, hg;

            int.TryParse(textBox_awayGoals.Text, out ag);
            int.TryParse(textBox_homeGoals.Text, out hg);

            if (at == "" || ht == "") return;

            Match match = new Match(ht, hg, ag, at, matchDate.SelectionStart);
            
            match.SetPlayerId(player.GetPlayerId());

            DatabaseAccessor.SaveMatch(match);
            player.SetPlayerMatches(DatabaseAccessor.LoadAllMatchesFrom(player));

            this.Close();

            analyst.RefreshInterface();
        }

        private void playerInHomeTeam_CheckedChanged(object sender, EventArgs e)
        {
            if(playerInHomeTeam.Checked)
            {
                textBox_homeTeam.Text = player.GetPlayerClub();
                if (textBox_awayTeam.Text.Equals(player.GetPlayerClub())) textBox_awayTeam.Text = "";
            }
            else
            {
                textBox_homeTeam.Text = textBox_awayTeam.Text;
                textBox_awayTeam.Text = player.GetPlayerClub();
            }
        }

        private void playerInAwayTeam_CheckedChanged(object sender, EventArgs e)
        {
            if (playerInAwayTeam.Checked)
            {
                textBox_awayTeam.Text = player.GetPlayerClub();
                if (textBox_homeTeam.Text.Equals(player.GetPlayerClub())) textBox_homeTeam.Text = "";
            }
            else
            {
                textBox_awayTeam.Text = textBox_homeTeam.Text;
                textBox_homeTeam.Text = player.GetPlayerClub();
            }

        }
    }
}
