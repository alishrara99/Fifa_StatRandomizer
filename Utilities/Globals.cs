using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa_StatRandomizer.Utilities
{
    public class ProbabilityObj {
        public object obj;
        public int objChance;

        public ProbabilityObj(object obj, int objChance) { 
        this.obj = obj;
        this.objChance = objChance;
        }
    }
    public static class Globals
    {
        public static object testChances (List<ProbabilityObj> chancesList) {
            int totalChance = 0;
            List<object> itemPool = new List<object>();
            foreach (var item in chancesList)  {
                totalChance += item.objChance;
            }
            if (totalChance > 100)
            {
                return null;
            }
            foreach (var item in chancesList)
            {
                for (int i = 0; i < item.objChance; i++) {
                    itemPool.Add(item.obj);
                }
            }
            for (int i = 0; i < 100-totalChance; i++)
            {
                itemPool.Add(null);
            }
            itemPool.Shuffle();
            return itemPool[Globals.Random.Next(0,99)];
        }
        public enum traits {
            [Description("Cautions With Crosses")]
            Cautions_With_Crosses,
            [Description("Comes For Crosses")]
            Comes_For_Crosses,
            [Description("Saves With Feet")]
            Saves_With_Feet,
            [Description("GK Long Throw")]
            GK_Long_Throw,
            [Description("Puncher")]
            Puncher,
            [Description("Rushes Out of Goal")]
            Rushes_Out_Of_Goal,
            [Description("GK 1 on 1")]
            GK_1on1,
            //////
            [Description("Early Crosser")]
            Early_Crosser,
            [Description("Long Throw-In")]
            Long_Throw_In,
            [Description("Giant Throw-In")]
            Giant_Throw_In,
            [Description("Injury Prone")]
            Injury_Prone,
            [Description("Solid Player")]
            Solid_Player,
            [Description("Leadership")]
            Leadership,
            [Description("Team Player")]
            Team_Player,
            [Description("Finesse Shot")]
            Finesse_Shot,
            [Description("Outside Foot Shot")]
            Outside_Foot_Shot,
            [Description("Avoids Using Weakfoot")]
            Avoids_Using_Weakfoot,
            [Description("Takes Finesse Freekicks")]
            Takes_Finesse_Freekicks,
            [Description("Takes Power Freekicks")]
            Takes_Power_Freekicks,
            [Description("Flair")]
            Flair,
            [Description("Power Header")]
            Power_Header,
            [Description("Backs Into Player")]
            Backs_Into_Player,
            [Description("Tries To Beat Def Line")]
            Tries_To_Beat_Def_Line,
            [Description("Target Forward")]
            Target_Forward,
            [Description("Set Play Specialist")]
            Set_Play_Specialist,
            [Description("Diver")]
            Diver,
            [Description("Technical Dribbler")]
            Technical_Dribbler,
            [Description("Blames Teammates")]
            Blames_Teammates
        }
        public enum freeKickStanceID
        {
        Default =0,
        FarfromBall=1,
        NinetyDegreesfromBall=2,
        HandsHighonHips=3,
        HandsLowonHips=4,
        StraightRun = 5,
        SlowBuildup = 6,
        DeepBreath = 7,
        Technique = 8,
        Samba = 9,
        WideStance = 10
        }
        public enum penaltyKickStanceID
        {
            Default = 0,
            StandTall = 3,
            DeepBreath = 4,
            HandsonHips = 5,
            WideStance = 6,
            MediumStance = 7,
            StaggeredStance = 8,
            WideStanceArmsDown = 9,
            Relaxed = 10
        }
        public enum tattoo_rightArm
        {
            _1 = 1,
            _2 = 2,
            _3 = 3,
            _4 = 4,
            _5 = 5,
            _6 = 6,
            _7 = 7,
            _8 = 8,
            _9 = 9,
            _10 = 10,
            _11 = 11,
            _12 = 12,
            _13 = 13,
            _14 = 14,
            _15 = 15,
            _16 = 16,
            _17 = 17,
            _18 = 18,
            _19 = 19,
            _20 = 20,
            _21 = 21,
            _22 = 22
        }
        public enum tattoo_leftArm
        {
            _1 = 1,
            _2 = 2,
            _3 = 3,
            _4 = 4,
            _5 = 5,
            _6 = 6,
            _7 = 7,
            _8 = 8,
            _9 = 9,
            _10 = 10,
            _11 = 11,
            _12 = 12,
            _13 = 13,
            _14 = 14,
            _15 = 15,
            _16 = 16,
            _17 = 17,
            _18 = 18,
            _19 = 19,
            _20 = 20,
            _21 = 21,
            _22 = 22,
            _23 = 23
        }
        public enum tattoo_rightNeck
        {
            _1 = 1,
            _2 = 2,
            _3 = 3,
            _4 = 4,
            _5 = 5,
            _6 = 6,
            _7 = 7,
            _8 = 8,
            _9 = 9,
            _10 = 10
        }
        public enum tattoo_leftNeck
        {
            _1 = 1,
            _2 = 2,
            _3 = 3,
            _4 = 4,
            _5 = 5,
            _6 = 6,
            _7 = 7,
            _8 = 8
        }
        public enum tattoo_backNeck
        {
            _1 = 1,
            _2 = 2,
            _3 = 3,
            _4 = 4,
            _5 = 5,
            _6 = 6,
            _7 = 7,
            _8 = 8,
            _9 = 9,
            _10 = 10,
            _11 = 11
        }
        public enum workrate
        {
            [Description("Low")]
            Low = 0,
            [Description("Medium")]
            Medium = 1,
            [Description("High")]
            High = 3
        }
        public enum skillmoves
        {
            [Description("1-Star")]
            One_Star = 0,
            [Description("2-Star")]
            Two_Star = 1,
            [Description("3-Star")]
            Three_Star = 2,
            [Description("4-Star")]
            Four_Star = 3,
            [Description("5-Star")]
            Five_Star = 4
        }
        public enum weakfoot
        {
            [Description("1-Star")]
            One_Star = 0,
            [Description("2-Star")]
            Two_Star = 1,
            [Description("3-Star")]
            Three_Star = 2,
            [Description("4-Star")]
            Four_Star = 3,
            [Description("5-Star")]
            Five_Star = 4
        }
        public enum height
        {
            [Description("Short")]
            Short = 0,
            [Description("Average")]
            Average = 1,
            [Description("Tall")]
            Tall = 2
        }
        public enum weight
        {
            [Description("Lean")]
            Lean = 0,
            [Description("Average")]
            Average = 1,
            [Description("Stocky")]
            Stocky = 2
        }
        public enum position
        {
            [Description("Goalkeeper")]
            GoalKeeper = 0,
            [Description("Full Back")]
            FullBack = 1,
            [Description("Center Back")]
            CenterBack = 2,
            [Description("Defensive Mid")]
            DefensiveMid = 3,
            [Description("Center Mid")]
            CenterMid = 4,
            [Description("Attacking Mid")]
            AttackingMid = 5,
            [Description("Winger")]
            Winger = 6,
            [Description("Striker")]
            Striker = 7
        }
        public static Random Random = new Random();
        public static int NUMERICUPDOWN_DEFAULT_VALUE = 50;
        public static string COMBOBOX_DEFAULT_TEXT = "--Select--";

        //unused
        //public enum potential_fulfillment
        //{
        //    Exceeded = 5,
        //    Fulfilled = 0,
        //    Average = -5,
        //    Flopped = -10,
        //    Balloon = -20,
        //    Disaster = -30
        //}
        //public static int range_talented()
        //{
        //    return Random.Next(-5, 5);
        //}
        //public static int range_talented_highDeviation()
        //{
        //    return Random.Next(-5, 15);
        //}
        //public static int range_talented_higherDeviation()
        //{
        //    return Random.Next(-5, 25);
        //}
        //public static int range_primary()
        //{
        //    return Random.Next(0, 10);
        //}
        //public static int range_primary_highDeviation()
        //{
        //    return Random.Next(0, 20);
        //}
        //public static int range_primary_higherDeviation()
        //{
        //    return Random.Next(0, 30);
        //}
        //public static int range_secondary()
        //{
        //    return Random.Next(10, 30);
        //}
        //public static int range_secondary_highDeviation()
        //{
        //    return Random.Next(10, 30);
        //}
        //public static int range_secondary_higherDeviation()
        //{
        //    return Random.Next(10, 40);
        //}
    }
}
