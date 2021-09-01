using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa_StatRandomizer.Entities
{
    enum height
    {
        [Description("Short")]
        Short = 0,
        [Description("Average")]
        Average = 1,
        [Description("Tall")]
        Tall = 2
    }
    enum weight
    {
        [Description("Lean")]
        Lean = 0,
        [Description("Average")]
        Average = 1,
        [Description("Stocky")]
        Stocky = 2
    }
    enum position
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
    class Attributes
    {
        public int composure { get; set; }
        public int reactions { get; set; }
        public int att_positioning { get; set; }
        public int penalties { get; set; }
        public int jumping { get; set; }
        public int balance { get; set; }
        public int stamina { get; set; }
        public int aggression { get; set; }


        public Attributes(int _potential, height _height , weight _weight , position _position)
        {
            composure = _potential;
            reactions = _potential;
            att_positioning = _potential;
            penalties = _potential;
            jumping = _potential;
            balance = _potential;
            stamina = _potential;
            aggression = _potential;
        }

    }
}
