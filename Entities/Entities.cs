using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fifa_StatRandomizer.Utilities;

namespace Fifa_StatRandomizer.Entities
{
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
        public Globals.workrate att_workrate { get; set; }
        public Globals.workrate def_workrate { get; set; }
        public Globals.weakfoot weakfoot { get; set; }
        public Globals.skillmoves skillmoves { get; set; }
        public List<Globals.traits> traits = new List<Globals.traits>();


        public Attributes(int _potential, Globals.height _height , Globals.weight _weight , Globals.position _position , Globals.skillmoves _skillmoves , Globals.weakfoot _weakfoot)
        {
            if (_position != Globals.position.GoalKeeper)
            {
                switch (_height)
                {
                    case Globals.height.Short:
                        balance = _potential - Globals.Random.Next(0, 10);
                        jumping = _potential - Globals.Random.Next(10, 40); 
                        {
                            List<ProbabilityObj> list = new List<ProbabilityObj>() { new ProbabilityObj(Globals.traits.Power_Header, 10) };
                            object result = Globals.testChances(list);
                            if (result != null)
                            {
                                traits.Add((Globals.traits)result);
                            }
                        }
                        break;
                    case Globals.height.Average:
                        balance = _potential - Globals.Random.Next(0, 20);
                        jumping = _potential - Globals.Random.Next(0, 20);
                        {
                            List<ProbabilityObj> list = new List<ProbabilityObj>() { new ProbabilityObj(Globals.traits.Power_Header, 20) };
                            object result = Globals.testChances(list);
                            if (result != null)
                            {
                                traits.Add((Globals.traits)result);
                            }
                        }
                        break;
                    case Globals.height.Tall:
                        balance = _potential - Globals.Random.Next(10, 30);
                        jumping = _potential - Globals.Random.Next(0, 10);
                        {
                            List<ProbabilityObj> list = new List<ProbabilityObj>() { new ProbabilityObj(Globals.traits.Power_Header, 30) };
                            object result = Globals.testChances(list);
                            if (result != null)
                            {
                                traits.Add((Globals.traits)result);
                            }
                        }
                        break;

                }
            }
            switch (_position)
            {
                case Globals.position.GoalKeeper:
                    aggression = _potential - Globals.Random.Next(0, 40);
                    att_positioning = Globals.Random.Next(20, 30);
                    penalties = Globals.Random.Next(20, 80);
                    stamina = Globals.Random.Next(40, 60);
                    att_workrate = Globals.workrate.Medium;
                    def_workrate = Globals.workrate.Medium;
                    skillmoves = _skillmoves;
                    weakfoot = _weakfoot;
                    if (Globals.Random.Next(0, 99) < 30)
                    {
                         traits.Add(Globals.traits.Cautions_With_Crosses);
                    }
                    if (Globals.Random.Next(0, 99) < 30 && !traits.Contains(Globals.traits.Cautions_With_Crosses))
                    {
                        traits.Add(Globals.traits.Comes_For_Crosses);
                    }
                    if (Globals.Random.Next(0, 99) < 30)
                    {
                        traits.Add(Globals.traits.Saves_With_Feet);
                    }
                    if (Globals.Random.Next(0, 99) < 30)
                    {
                        traits.Add(Globals.traits.GK_Long_Throw);
                    }
                    if (Globals.Random.Next(0, 99) < 30)
                    {
                        traits.Add(Globals.traits.Puncher);
                    }
                    if (Globals.Random.Next(0, 99) < 30)
                    {
                        traits.Add(Globals.traits.Rushes_Out_Of_Goal);
                    }
                    break;
                case Globals.position.FullBack:
                    aggression = _potential - Globals.Random.Next(0, 20);
                    att_positioning = _potential - Globals.Random.Next(0, 40);
                    penalties = Globals.Random.Next(40, 80);
                    stamina = _potential - Globals.Random.Next(0, 15);
                    att_workrate = Globals.workrate.Medium;
                    def_workrate = Globals.workrate.High;
                    skillmoves = _skillmoves;
                    weakfoot = _weakfoot;
                    switch (Globals.Random.Next(0, 99))
                    {
                        case int n when n < 30:
                            def_workrate = Globals.workrate.Medium;
                            break;
                        default:
                            break;
                    }
                    switch (Globals.Random.Next(0, 99))
                    {
                        case int n when n < 30:
                            att_workrate = Globals.workrate.High;
                            break;
                        default:
                            break;
                    }
                    break;
                case Globals.position.CenterBack:
                    aggression = _potential - Globals.Random.Next(0, 10);
                    att_positioning = _potential - Globals.Random.Next(10, 50);
                    penalties = Globals.Random.Next(40, 80);
                    stamina = _potential - Globals.Random.Next(0, 30);
                    att_workrate = Globals.workrate.Low;
                    def_workrate = Globals.workrate.High;
                    skillmoves = _skillmoves;
                    weakfoot = _weakfoot;
                    switch (Globals.Random.Next(0, 99))
                    {
                        case int n when n < 30:
                            def_workrate = Globals.workrate.Medium;
                            break;
                        default:
                            break;
                    }
                    switch (Globals.Random.Next(0, 99))
                    {
                        case int n when n < 30:
                            att_workrate = Globals.workrate.Medium;
                            break;
                        default:
                            break;
                    }
                    break;
                case Globals.position.DefensiveMid:
                    aggression = _potential - Globals.Random.Next(0, 10);
                    att_positioning = _potential - Globals.Random.Next(0, 40);
                    penalties = Globals.Random.Next(50, 80);
                    stamina = _potential - Globals.Random.Next(0, 15);
                    att_workrate = Globals.workrate.Medium;
                    def_workrate = Globals.workrate.High;
                    skillmoves = _skillmoves;
                    weakfoot = _weakfoot;
                    switch (Globals.Random.Next(0, 99))
                    {
                        case int n when n < 30:
                            def_workrate = Globals.workrate.Medium;
                            break;
                        default:
                            break;
                    }
                    switch (Globals.Random.Next(0, 2))
                    {
                        case 0:
                            att_workrate = Globals.workrate.High;
                            break;
                        case 1:
                            att_workrate = Globals.workrate.Low;
                            break;
                        default:
                            break;
                    }
                    break;
                case Globals.position.CenterMid:
                    aggression = _potential - Globals.Random.Next(0, 20);
                    att_positioning = _potential - Globals.Random.Next(0, 30);
                    penalties = Globals.Random.Next(50, 80);
                    stamina = _potential - Globals.Random.Next(0, 15);
                    att_workrate = Globals.workrate.Medium;
                    def_workrate = Globals.workrate.Medium;
                    skillmoves = _skillmoves;
                    weakfoot = _weakfoot;
                    switch (Globals.Random.Next(0, 99))
                    {
                        case int n when n < 30:
                            def_workrate = Globals.workrate.High;
                            break;
                        default:
                            break;
                    }
                    switch (Globals.Random.Next(0, 99))
                    {
                        case int n when n < 30:
                            att_workrate = Globals.workrate.High;
                            break;
                        default:
                            break;
                    }
                    break;
                case Globals.position.AttackingMid:
                    aggression = _potential - Globals.Random.Next(0, 40);
                    att_positioning = _potential - Globals.Random.Next(0, 10);
                    penalties = _potential - Globals.Random.Next(0, 15);
                    stamina = _potential - Globals.Random.Next(0, 15);
                    att_workrate = Globals.workrate.Medium;
                    def_workrate = Globals.workrate.Medium;
                    skillmoves = _skillmoves;
                    weakfoot = _weakfoot;
                    switch (Globals.Random.Next(0, 2))
                    {
                        case 0:
                            def_workrate = Globals.workrate.High;
                            break;
                        case 1:
                            def_workrate = Globals.workrate.Low;
                            break;
                        default:
                            break;
                    }
                    switch (Globals.Random.Next(0, 99))
                    {
                        case int n when n < 30:
                            att_workrate = Globals.workrate.High;
                            break;
                        default:
                            break;
                    }
                    if ((int)skillmoves < 3)
                    {
                        skillmoves = (Globals.skillmoves)((int)skillmoves + 1);
                    }
                    if ((int)weakfoot < 2)
                    {
                        weakfoot = (Globals.weakfoot)((int)weakfoot + 1);
                    }
                    break;
                case Globals.position.Winger:
                    aggression = _potential - Globals.Random.Next(0, 40);
                    att_positioning = _potential - Globals.Random.Next(0, 10);
                    penalties = _potential - Globals.Random.Next(0, 15);
                    stamina = _potential - Globals.Random.Next(0, 15);
                    att_workrate = Globals.workrate.High;
                    def_workrate = Globals.workrate.Medium;
                    skillmoves = _skillmoves;
                    weakfoot = _weakfoot;
                    switch (Globals.Random.Next(0, 2))
                    {
                        case 0:
                            def_workrate = Globals.workrate.High;
                            break;
                        case 1:
                            def_workrate = Globals.workrate.Low;
                            break;
                        default:
                            break;
                    }
                    switch (Globals.Random.Next(0, 99))
                    {
                        case int n when n < 30:
                            att_workrate = Globals.workrate.Medium;
                            break;
                        default:
                            break;
                    }
                    if ((int)skillmoves < 3)
                    {
                        skillmoves = (Globals.skillmoves)((int)skillmoves + 1);
                    }
                    if ((int)weakfoot < 2)
                    {
                        weakfoot = (Globals.weakfoot)((int)weakfoot + 1);
                    }
                    break;
                case Globals.position.Striker:
                    aggression = _potential - Globals.Random.Next(0, 40);
                    att_positioning = _potential - Globals.Random.Next(0, 10);
                    penalties = _potential - Globals.Random.Next(0, 15);
                    stamina = _potential - Globals.Random.Next(0, 15);
                    att_workrate = Globals.workrate.High;
                    def_workrate = Globals.workrate.Low;
                    skillmoves = _skillmoves;
                    weakfoot = _weakfoot;
                    switch (Globals.Random.Next(0, 99))
                    {
                        case int n when n < 30:
                            def_workrate = Globals.workrate.Medium;
                            break;
                        default:
                            break;
                    }
                    switch (Globals.Random.Next(0, 99))
                    {
                        case int n when n < 30:
                            att_workrate = Globals.workrate.Medium;
                            break;
                        default:
                            break;
                    }
                    if ((int)skillmoves < 3)
                    {
                        skillmoves = (Globals.skillmoves)((int)skillmoves + 1);
                    }
                    if ((int)weakfoot < 2)
                    {
                        weakfoot = (Globals.weakfoot)((int)weakfoot + 1);
                    }
                    break;
            }
            switch (_weight)
            {
                case Globals.weight.Lean:
                    balance = balance - Globals.Random.Next(0, 5);
                    jumping = jumping - Globals.Random.Next(-5, 0);
                    break;
                case Globals.weight.Average:
                    balance = balance - Globals.Random.Next(-2, 2);
                    jumping = jumping - Globals.Random.Next(-2, 2);
                    break;
                case Globals.weight.Stocky:
                    balance = balance - Globals.Random.Next(-5, 0);
                    jumping = jumping - Globals.Random.Next(0, 5);
                    aggression = aggression - Globals.Random.Next(-5, 0);
                    break;
            }

            if ((int)skillmoves < 4)
            {
                switch (Globals.Random.Next(0, 99))
                {
                    case int n when n < 20:
                        skillmoves = (Globals.skillmoves)((int)skillmoves + 1);
                        break;
                    default:
                        break;
                }
            }

            if ((int)weakfoot < 4)
            {
                switch (Globals.Random.Next(0, 99))
                {
                    case int n when n < 20:
                        weakfoot = (Globals.weakfoot)((int)weakfoot + 1);
                        break;
                    default:
                        break;
                }
            }

            composure = _potential - Globals.Random.Next(0, 10);
            reactions = _potential - Globals.Random.Next(0, 10);
        }

    }

}
