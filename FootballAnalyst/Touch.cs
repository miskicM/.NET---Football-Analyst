using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballAnalyst
{
    /*
     * Records a pass,dribble,duel or shot by a player along with metadata about the 
     * time, location, foot/head used.
     */
    public class Touch
    {
        //Database keys
        private int touchId;
        private int matchId;

        
        public enum Type
        {
            Pass,
            Dribble,
            Shot,
            Duel,
            Tackle
        }

        public enum Method
        {
            RightFoot,
            LeftFoot,
            Head
        }
        //Timestamp/minute the touch took place.
        public int Minute { get; set; }

        public Type TouchType { get; set; }

        //Defining if the player was successful. Note: in the case of a shot, this only describes
        //if the shot was on target, not a goal.
        public bool Successful { get; set; }

        //Body part used
        public Method MethodOfExecution { get; set; }

        //Duel specific. defining whether it was a ground or areal.
        public bool OnGround { get; set; }

        public Touch(int minute, Type type)
        {
            TouchType = type;
            Minute = minute;
            Successful = true;
        }

        public int GetTouchId()
        {
            return touchId;
        }

        public void SetTouchId(int id)
        {
            touchId = id;
        }
        public int GetMatchId()
        {
            return matchId;
        }

        public void SetMatchId(int id)
        {
            matchId = id;
        }

        public string DisplayText()
        {
            string success = "unsuccessful";
            if (Successful) success = "successful";

            string type = "";
            switch(TouchType)
            {
                case Type.Pass:
                    type = "pass";
                    break;
                case Type.Dribble:
                    if (MethodOfExecution == Method.RightFoot) type = "righfooted dribble";
                    else type = "leftfooted dribble";
                    break;
                case Type.Shot:
                    if (Successful) success = "shot on target";
                    else success = "shot off target";

                    if (MethodOfExecution == Method.RightFoot) type = "using right foot";
                    if (MethodOfExecution == Method.LeftFoot) type = "using left foot";
                    if (MethodOfExecution == Method.Head) type = "using his head";
                    break;
                case Type.Duel:
                    if (Successful) success = "successful";

                    if (OnGround) type = "ground duel";
                    else type = "aerial duel";
                    break;
                case Type.Tackle:
                    if (Successful) success = "successful";
                    type = "tackle";
                    break;
            }
            return Minute +"' " + success + " " + type;
        }
    }
}
