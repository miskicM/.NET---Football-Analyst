using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballAnalyst
{
    public class Match
    {
        //Database keys:
        private int matchId;
        private int playerId;
        private bool saved = false;
        // Basic match details:
        private string homeTeam;
        private string awayTeam;
        private int homeGoals;
        private int awayGoals;
        private DateTime date;

        // Scouted player Performance: 
        public List<Touch> Touches = new List<Touch>();

        public Match(string homeTeam,int homeGoals, int awayGoals, string awayTeam, DateTime date)
        {
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
            this.homeGoals = homeGoals;
            this.awayGoals = awayGoals;
            this.date = date;
        }

        public string GetHomeTeam()
        {
            return homeTeam;
        }

        public string GetAwayTeam()
        {
            return awayTeam;
        }

        public int GetHomeGoals()
        {
            return homeGoals;
        }

        public int GetAwayGoals()
        {
            return awayGoals;
        }

        public void SetMatchId(int id)
        {
            matchId = id;
        }

        public int GetMatchId()
        {
            return matchId;
        }

        public void SetPlayerId(int id)
        {
            playerId = id;
        }

        public int GetPlayerId()
        {
            return playerId;
        }

        public void SetSaved(bool f)
        {
            saved = f;
        }

        public bool IsSaved()
        {
            return saved;
        }

        public string DisplayText
        {
            get
            {
                return string.Format("{0} {1} - {2} {3}", homeTeam, homeGoals, awayGoals, awayTeam);
            }
        
        }
    }
}
