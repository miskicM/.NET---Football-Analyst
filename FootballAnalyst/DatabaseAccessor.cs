using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballAnalyst
{
    public class DatabaseAccessor
    {
        //Returns a list of all players stored in the database.
        public static List<Player> LoadAllPlayers()
        {
            List<Player> players = new List<Player>();
            
            using(var sql = new SQLiteConnection(ConfigurationManager.ConnectionStrings["FADB"].ConnectionString))
            {
                sql.Open();

                string cmdtext = "select * from Player";
                var cmd = new SQLiteCommand(cmdtext,sql);
                SQLiteDataReader rd = cmd.ExecuteReader();

                while(rd.Read())
                {
                    Player player = new Player(rd.GetString(1), rd.GetString(2));
                    player.SetId(rd.GetInt32(0));

                    if (!rd.IsDBNull(3)) player.SetNationality(rd.GetString(3));
                    if (!rd.IsDBNull(4)) player.SetHeight(rd.GetInt32(4));
                    if (!rd.IsDBNull(5)) player.SetWeight(rd.GetInt32(5));
                    if (!rd.IsDBNull(6)) player.SetDateOfBirth(DateTime.Parse(rd.GetString(6)));
                    players.Add(player);
                }

            }

            return players;
        }

        //Returns a list of all matches from a specific player from the database.
        public static List<Match> LoadAllMatchesFrom(Player player)
        {
            List<Match> matches = new List<Match>();

            using (var sql = new SQLiteConnection(ConfigurationManager.ConnectionStrings["FADB"].ConnectionString))
            {
                sql.Open();
                string cmdtext = "select * from Match where Player_ID = "+player.GetPlayerId()+";";
                var cmd = new SQLiteCommand(cmdtext, sql);
                SQLiteDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Match match = new Match(rd.GetString(2), rd.GetInt32(4), rd.GetInt32(5), rd.GetString(3),new DateTime());//TODO date
                    match.SetMatchId(rd.GetInt32(0));
                    match.SetPlayerId(rd.GetInt32(1));
                    matches.Add(match);
                }
            }

            return matches;
        }

        //Returns a list of all touches from a specific match from the database.
        public static List<Touch> LoadAllTouchesFrom(Match match)
        {
            List<Touch> touches = new List<Touch>();

            using (var sql = new SQLiteConnection(ConfigurationManager.ConnectionStrings["FADB"].ConnectionString))
            {
                sql.Open();
                string cmdtext = "select * from Touch where Match_ID = " + match.GetMatchId() + ";";
                var cmd = new SQLiteCommand(cmdtext, sql);
                SQLiteDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Touch.Type type = (Touch.Type)Enum.Parse(typeof(Touch.Type), rd.GetString(2));
                    Touch.Method method;

                    Touch touch = new Touch(rd.GetInt32(4),type);
                    touch.SetTouchId(rd.GetInt32(0));
                    touch.SetMatchId(rd.GetInt32(1));
                    if (!rd.IsDBNull(3))
                    { 
                        method = (Touch.Method)Enum.Parse(typeof(Touch.Method), rd.GetString(3));
                        touch.MethodOfExecution = method;
                    }
                    if (!rd.IsDBNull(6)) touch.OnGround = Convert.ToBoolean(rd.GetInt32(6));
                    touch.Successful = Convert.ToBoolean(rd.GetInt32(5));

                    match.Touches.Add(touch);
                }
            }

            return touches;
        }

        //Saves a player object into the database.
        public static void SavePlayer(Player player)
        {
            using (var sql = new SQLiteConnection(ConfigurationManager.ConnectionStrings["FADB"].ConnectionString))
            {
                
                sql.Open();
                var cmd = sql.CreateCommand();
                cmd.CommandText = "INSERT INTO Player ('Name','Club','Nationality','Height','Weight','DoB') " +
                                               "VALUES('"+player.GetPlayerName()+"','"+player.GetPlayerClub()+"','"+player.GetPlayerNationality()+"',"+player.PlayerHeightInt()+","+player.PlayerWeightInt()+",'"+ player.GetDateOfBirth().ToString("d")+"');";
                cmd.ExecuteNonQuery();
                Console.WriteLine(cmd.CommandText);
            }
        }

        //Saves a match object into the database
        public static void SaveMatch(Match match)
        {
            using (var sql = new SQLiteConnection(ConfigurationManager.ConnectionStrings["FADB"].ConnectionString))
            {
                sql.Open();
                var cmd = sql.CreateCommand();
                cmd.CommandText = "INSERT INTO Match ('Home_Team','Away_Team','Home_Goals','Away_Goals','Player_ID') "
                                   + "VALUES('" + match.GetHomeTeam() + "','" + match.GetAwayTeam() + "'," + match.GetHomeGoals() + "," + match.GetAwayGoals() +","+match.GetPlayerId()+ ");";
                cmd.ExecuteNonQuery();
            }  
        }

        //Saves all recorded match touches to the database
        public static void UpdateMatchTouches(Match match)
        {
            using (var sql = new SQLiteConnection(ConfigurationManager.ConnectionStrings["FADB"].ConnectionString))
            {
                sql.Open();
                var cmd = sql.CreateCommand();
                foreach (Touch touch in match.Touches)
                {
                    Console.WriteLine(touch.Minute + " " + touch.GetType());
                    cmd.CommandText = "INSERT INTO Touch ('Match_ID','Type','Method','Minute','Success','OnGround') "
                                       + "VALUES(" +  match.GetMatchId()+",'"+touch.TouchType.ToString()+"','"+ touch.MethodOfExecution.ToString()+"',"+touch.Minute+","+touch.Successful+","+touch.OnGround + ");";
                    cmd.ExecuteNonQuery();
                }
                
            }
            match.SetSaved(true);
        }

        //TODO
        public int CountTouchesForPlayer(Player player,Touch.Type type, bool onlySuccessful = false)
        {
            int amount = 0;

            return amount;
        }
    }
}
