using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa_StatRandomizer.Utilities
{
    public static class Globals
    {
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
        public static int NUMERICUPDOWN_DEFAULT_VALUE = 1;
        public static string COMBOBOX_DEFAULT_TEXT = "--Select--";
        public static int TALENTED_MIN = -5;
        public static int PRIMARY_MIN = 0;
        public static int SECONDARY_MIN = 10;
        public static int TERETIARY_MIN = 20;
        public static int PRIMARY_MAX = 10;
        public static int SECONDARY_MAX = 30;
        public static int TERETIARY_MAX = 40;

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
