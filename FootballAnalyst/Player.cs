using System;
using System.Collections.Generic;

namespace FootballAnalyst
{
    public class Player
    {
        //Database key
        private int playerId;
        //Players variables
        private string playerName;
        private string playerClubName;
        private DateTime playerDateOfBirth;
        private string playerNationality;
        private int playerHeight;
        private int playerWeight;

        private List<Match> matches = new List<Match>();

        public Player(string name, string club)
        {
            playerName = name;
            playerClubName = club;
        }

        public void SetPlayerId(int id)
        {
            playerId = id;
        }

        public List<Match> GetPlayerMatches()
        {
            return matches;
        }

        public void SetPlayerMatches(List<Match> list)
        {
            matches = list;
        }

        public void AddMatch(Match match)
        {
            matches.Add(match);
        }

        public void AddMatches(List<Match> matches)
        {
            this.matches.AddRange(matches);
        }

        public string GetPlayerName()
        {
            return playerName;
        }

        public string GetPlayerClub()
        {
            return playerClubName;
        }

        public int GetPlayerId()
        {
            return playerId;
        }

        public string GetVisualTag()
        {
            return playerName + " - " + playerClubName;
        }

        public string GetPlayerAge()
        {
            if (playerDateOfBirth == null) return "Unknown";
            double years = (DateTime.Now - playerDateOfBirth).TotalDays / 365;
            int fullyears = (int)Math.Truncate(years);
            return fullyears.ToString();
        }

        public string GetPlayerNationality()
        {
            if (playerNationality == null) return "Unknown";
            return playerNationality;
        }

        //For UI purpuses
        public string GetPlayerHeight()
        {
            if (playerHeight == 0) return "Unknown";
            return playerHeight.ToString()+"cm";
        }

        public int PlayerHeightInt()
        {
            return playerHeight;
        }

        //For UI purpuses
        public string GetPlayerWeight()
        {
            if (playerWeight == 0) return "Unknown";
            return playerWeight.ToString()+"kg";
        }

        public int PlayerWeightInt()
        {
            return playerWeight;
        }

        public Player SetDateOfBirth(DateTime dt)
        {
            playerDateOfBirth = dt;
            return this;
        }

        public DateTime GetDateOfBirth()
        {
            return playerDateOfBirth;
        }

        public Player SetWeight(int weight)
        {
            this.playerWeight = weight;
            return this;
        }

        public Player SetHeight(int height)
        {
            this.playerHeight = height;
            return this;
        }

        public Player SetNationality(string nat)
        {
            playerNationality = nat;
            if (nat == null) playerNationality = "Unknown";
            return this;
        }

        public void SetId(int id)
        {
            this.playerId = id;
        }

        
    }
}
