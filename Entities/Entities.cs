using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fifa_StatRandomizer.Utilities;
using static Fifa_StatRandomizer.Utilities.Globals;

namespace Fifa_StatRandomizer.Entities
{
    class Misc {
        public int tattoo_rightArm { get; set; }
        public int tattoo_leftArm { get; set; }
        public int tattoo_rightNeck { get; set; }
        public int tattoo_leftNeck { get; set; }
        public int tattoo_backNeck { get; set; }
        public int boots { get; set; }

        public Misc (Globals.position _position)
        {
            {
                List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(true, 30)
                        };
                object result = Globals.testChances(list);
                if (result != null)
                {
                    tattoo_rightArm = Globals.Random.Next(1,22);
                }
            }
            {
                List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(true, 30)
                        };
                object result = Globals.testChances(list);
                if (result != null)
                {
                    tattoo_leftArm = Globals.Random.Next(1, 23);
                }
            }
            {
                List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(true, 30)
                        };
                object result = Globals.testChances(list);
                if (result != null)
                {
                    tattoo_rightNeck = Globals.Random.Next(1, 10);
                }
            }
            {
                List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(true, 30)
                        };
                object result = Globals.testChances(list);
                if (result != null)
                {
                    tattoo_leftNeck = Globals.Random.Next(1, 8);
                }
            }
            {
                List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(true, 30)
                        };
                object result = Globals.testChances(list);
                if (result != null)
                {
                    tattoo_backNeck = Globals.Random.Next(1, 11);
                }
            }

            List<int> temp = new List<int>();
            //189-190-191
            List<int> nike_tiempo = new List<int>() { 
                46,56,57,61,180,181,189,265
            };
            List<int> nike_magista = new List<int>() {
                47,50,51,60,264
            };
            //188
            List<int> nike_vapor = new List<int>() {
                62,64,182,183,184,185,188,267
            }; List<int> nike_phantom = new List<int>() {
                177,178,179,186,187
            };
            List<int> nike_hypervenom = new List<int>()
            {
                48,52,53,59,170,171,172,173,263,343
            };

            //58 removed
            List<int> nike_mercurial = new List<int>()
            {
                45,49,54,55,63,80,81,82,174,175,176,266,267
            };

            switch (_position) {
                case Globals.position.GoalKeeper:
                case Globals.position.CenterBack:
                    temp.AddRange(nike_tiempo);
                    temp.AddRange(nike_vapor);
                    boots = temp[Globals.Random.Next(0, temp.Count - 1)];
                    break;
                case Globals.position.FullBack:
                    temp.AddRange(nike_phantom);
                    temp.AddRange(nike_mercurial);
                    boots = temp[Globals.Random.Next(0, temp.Count - 1)];
                    break;
                case Globals.position.DefensiveMid:
                case Globals.position.CenterMid:
                    temp.AddRange(nike_magista);
                    temp.AddRange(nike_hypervenom);
                    boots = temp[Globals.Random.Next(0, temp.Count - 1)];
                    break;
                case Globals.position.AttackingMid:
                case Globals.position.Winger:
                case Globals.position.Striker:
                    temp.AddRange(nike_hypervenom);
                    temp.AddRange(nike_mercurial);
                    temp.AddRange(nike_phantom);
                    boots = temp[Globals.Random.Next(0, temp.Count - 1)];
                    break;
            }


        }

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
        public Globals.workrate att_workrate { get; set; }
        public Globals.workrate def_workrate { get; set; }
        public Globals.weakfoot weakfoot { get; set; }
        public Globals.skillmoves skillmoves { get; set; }
        public List<Globals.traits> traits = new List<Globals.traits>();


        public Attributes(int _potential, int _fkacc, int _curve, int _shotpower, Globals.height _height, Globals.weight _weight, Globals.position _position, Globals.skillmoves _skillmoves, Globals.weakfoot _weakfoot)
        {
            ///////////////////
            switch (_position)
            {
                case Globals.position.GoalKeeper:
                    aggression = Globals.Random.Next(40, 70);
                    att_positioning = Globals.Random.Next(20, 30);
                    balance = _potential - Globals.Random.Next(20, 50);
                    composure = _potential - Globals.Random.Next(20, 40);
                    jumping = _potential - Globals.Random.Next(10, 30);
                    penalties = Globals.Random.Next(20, 80);
                    stamina = Globals.Random.Next(40, 60);
                    att_workrate = Globals.workrate.Medium;
                    def_workrate = Globals.workrate.Medium;
                    skillmoves = _skillmoves;
                    weakfoot = _weakfoot;
                    if ((int)weakfoot < 4)
                    {
                        {
                            List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(true, 20)
                        };
                            object result = Globals.testChances(list);
                            if (result != null)
                            {
                                weakfoot = (Globals.weakfoot)((int)weakfoot + 1);
                            }
                        }
                    }
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Comes_For_Crosses, 30),
                            new ProbabilityObj(Globals.traits.Cautions_With_Crosses, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            traits.Add((Globals.traits)result);
                        }
                    }
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Saves_With_Feet, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            traits.Add((Globals.traits)result);
                        }
                    }
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.GK_Long_Throw, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            traits.Add((Globals.traits)result);
                        }
                    }
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Puncher, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            traits.Add((Globals.traits)result);
                        }
                    }
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Rushes_Out_Of_Goal, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            traits.Add((Globals.traits)result);
                            traits.Add(Globals.traits.GK_1on1);
                        }
                    }
                    break;

                case Globals.position.FullBack:
                    aggression = _potential - Globals.Random.Next(0, 20);
                    att_positioning = _potential - Globals.Random.Next(10, 50);
                    penalties = Globals.Random.Next(40, 80);
                    stamina = _potential - Globals.Random.Next(0, 15);
                    att_workrate = Globals.workrate.Medium;
                    def_workrate = Globals.workrate.Medium;
                    skillmoves = _skillmoves;
                    weakfoot = _weakfoot;
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.workrate.High, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            def_workrate = (Globals.workrate)result;
                        }
                    }
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.workrate.High, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            att_workrate = (Globals.workrate)result;
                        }
                    }
                    break;

                case Globals.position.CenterBack:
                    aggression = _potential - Globals.Random.Next(0, 10);
                    att_positioning = _potential - Globals.Random.Next(20, 60);
                    penalties = Globals.Random.Next(30, 80);
                    stamina = _potential - Globals.Random.Next(0, 30);
                    att_workrate = Globals.workrate.Low;
                    def_workrate = Globals.workrate.High;
                    skillmoves = _skillmoves;
                    weakfoot = _weakfoot;
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.workrate.Medium, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            def_workrate = (Globals.workrate)result;
                        }
                    }
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.workrate.Medium, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            att_workrate = (Globals.workrate)result;
                        }
                    }
                    break;

                case Globals.position.DefensiveMid:
                    aggression = _potential - Globals.Random.Next(0, 15);
                    att_positioning = _potential - Globals.Random.Next(10, 40);
                    penalties = Globals.Random.Next(40, 80);
                    stamina = _potential - Globals.Random.Next(0, 15);
                    att_workrate = Globals.workrate.Medium;
                    def_workrate = Globals.workrate.High;
                    skillmoves = _skillmoves;
                    weakfoot = _weakfoot;
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.workrate.Medium, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            def_workrate = (Globals.workrate)result;
                        }
                    }
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.workrate.High, 30),
                            new ProbabilityObj(Globals.workrate.Low, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            att_workrate = (Globals.workrate)result;
                        }
                    }
                    break;

                case Globals.position.CenterMid:
                    aggression = _potential - Globals.Random.Next(10, 30);
                    att_positioning = _potential - Globals.Random.Next(0, 30);
                    penalties = Globals.Random.Next(50, 80);
                    stamina = _potential - Globals.Random.Next(0, 15);
                    att_workrate = Globals.workrate.High;
                    def_workrate = Globals.workrate.High;
                    skillmoves = _skillmoves;
                    weakfoot = _weakfoot;
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.workrate.Medium, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            def_workrate = (Globals.workrate)result;
                        }
                    }
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.workrate.Medium, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            att_workrate = (Globals.workrate)result;
                        }
                    }
                    break;

                case Globals.position.AttackingMid:
                    aggression = _potential - Globals.Random.Next(10, 40);
                    att_positioning = _potential - Globals.Random.Next(0, 10);
                    penalties = _potential - Globals.Random.Next(0, 15);
                    stamina = _potential - Globals.Random.Next(0, 20);
                    att_workrate = Globals.workrate.High;
                    def_workrate = Globals.workrate.Medium;
                    skillmoves = _skillmoves;
                    weakfoot = _weakfoot;
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.workrate.High, 30),
                            new ProbabilityObj(Globals.workrate.Low, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            def_workrate = (Globals.workrate)result;
                        }
                    }
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.workrate.Medium, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            att_workrate = (Globals.workrate)result;
                        }
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
                    aggression = _potential - Globals.Random.Next(10, 40);
                    att_positioning = _potential - Globals.Random.Next(0, 10);
                    penalties = _potential - Globals.Random.Next(0, 15);
                    stamina = _potential - Globals.Random.Next(0, 20);
                    att_workrate = Globals.workrate.High;
                    def_workrate = Globals.workrate.Medium;
                    skillmoves = _skillmoves;
                    weakfoot = _weakfoot;
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.workrate.High, 30),
                            new ProbabilityObj(Globals.workrate.Low, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            def_workrate = (Globals.workrate)result;
                        }
                    }
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.workrate.Medium, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            att_workrate = (Globals.workrate)result;
                        }
                    }
                    break;

                case Globals.position.Striker:
                    aggression = _potential - Globals.Random.Next(0, 40);
                    att_positioning = _potential - Globals.Random.Next(0, 10);
                    penalties = _potential - Globals.Random.Next(0, 15);
                    stamina = _potential - Globals.Random.Next(0, 20);
                    att_workrate = Globals.workrate.High;
                    def_workrate = Globals.workrate.Low;
                    skillmoves = _skillmoves;
                    weakfoot = _weakfoot;
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.workrate.Medium, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            def_workrate = (Globals.workrate)result;
                        }
                    }
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.workrate.Medium, 30)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            att_workrate = (Globals.workrate)result;
                        }
                    }
                    break;
            }
            if (_position != Globals.position.GoalKeeper)
            {
                switch (_height)
                {
                    case Globals.height.Short:
                        balance = _potential - Globals.Random.Next(0, 10);
                        jumping = _potential - Globals.Random.Next(10, 40);
                        {
                            List<ProbabilityObj> list = new List<ProbabilityObj>() {
                                new ProbabilityObj(Globals.traits.Power_Header, 10)
                            };
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
                            List<ProbabilityObj> list = new List<ProbabilityObj>() {
                                new ProbabilityObj(Globals.traits.Power_Header, 20)
                            };
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
                            List<ProbabilityObj> list = new List<ProbabilityObj>() {
                                new ProbabilityObj(Globals.traits.Power_Header, 30)
                            };
                            object result = Globals.testChances(list);
                            if (result != null)
                            {
                                traits.Add((Globals.traits)result);
                            }
                        }
                        break;

                }
                switch (_weight)
                {
                    case Globals.weight.Lean:
                        balance = balance - Globals.Random.Next(0, 5);
                        jumping = jumping - Globals.Random.Next(-5, 0);
                        aggression = aggression - Globals.Random.Next(0, 5);
                        break;
                    case Globals.weight.Average:
                        balance = balance - Globals.Random.Next(-2, 2);
                        jumping = jumping - Globals.Random.Next(-2, 2);
                        aggression = aggression - Globals.Random.Next(-2, 2);
                        break;
                    case Globals.weight.Stocky:
                        balance = balance - Globals.Random.Next(-5, 0);
                        jumping = jumping - Globals.Random.Next(0, 5);
                        aggression = aggression - Globals.Random.Next(-5, 0);
                        break;
                }

                //Skill moves and positioning
                switch (_position)
                {
                    case Globals.position.FullBack:
                        if (att_positioning >= 75)
                        {
                            {
                                List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Tries_To_Beat_Def_Line, 25),
                            new ProbabilityObj(Globals.traits.Backs_Into_Player, 10)
                        };
                                object result = Globals.testChances(list);
                                if (result != null)
                                {
                                    traits.Add((Globals.traits)result);
                                }
                            }
                        }
                        break;
                    case Globals.position.DefensiveMid:
                        if (att_positioning >= 75)
                        {
                            {
                                List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Tries_To_Beat_Def_Line, 15),
                            new ProbabilityObj(Globals.traits.Backs_Into_Player, 15)
                        };
                                object result = Globals.testChances(list);
                                if (result != null)
                                {
                                    traits.Add((Globals.traits)result);
                                }
                            }
                        }
                        break;
                    case Globals.position.CenterMid:
                        if (att_positioning >= 75)
                        {
                            {
                                List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Tries_To_Beat_Def_Line, 15),
                            new ProbabilityObj(Globals.traits.Backs_Into_Player, 15)
                        };
                                object result = Globals.testChances(list);
                                if (result != null)
                                {
                                    traits.Add((Globals.traits)result);
                                }
                            }
                        }
                        break;
                    case Globals.position.AttackingMid:
                        {
                            List<ProbabilityObj> list = new List<ProbabilityObj>() {
                        new ProbabilityObj(Globals.traits.Tries_To_Beat_Def_Line, 20),
                        new ProbabilityObj(Globals.traits.Backs_Into_Player, 20)
                        };
                            object result = Globals.testChances(list);
                            if (result != null)
                            {
                                traits.Add((Globals.traits)result);
                            }
                        }
                        break;
                    case Globals.position.Winger:
                        {
                            List<ProbabilityObj> list = new List<ProbabilityObj>() {
                        new ProbabilityObj(Globals.traits.Tries_To_Beat_Def_Line, 35),
                        new ProbabilityObj(Globals.traits.Backs_Into_Player, 20),
                        new ProbabilityObj(Globals.traits.Target_Forward, 15)
                        };
                            object result = Globals.testChances(list);
                            if (result != null)
                            {
                                traits.Add((Globals.traits)result);
                            }
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
                        {
                            List<ProbabilityObj> list = new List<ProbabilityObj>() {
                        new ProbabilityObj(Globals.traits.Tries_To_Beat_Def_Line, 25),
                        new ProbabilityObj(Globals.traits.Backs_Into_Player, 25),
                        new ProbabilityObj(Globals.traits.Target_Forward, 25)
                        };
                            object result = Globals.testChances(list);
                            if (result != null)
                            {
                                traits.Add((Globals.traits)result);
                            }
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
                    default:
                        break;

                }
                // set play specialist
                switch (_position) {
                    case Globals.position.FullBack:
                    case Globals.position.CenterBack:
                        if (_fkacc >= 60) {
                            {
                                List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Set_Play_Specialist, 20)
                                };
                                object result = Globals.testChances(list);
                                if (result != null)
                                {
                                    traits.Add((Globals.traits)result);
                                }
                            }
                            if (_curve <= _shotpower || _shotpower >= 60)
                            {
                                {
                                    List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Takes_Power_Freekicks, 30),
                            new ProbabilityObj(Globals.traits.Takes_Finesse_Freekicks, 15)
                                };
                                    object result = Globals.testChances(list);
                                    if (result != null)
                                    {
                                        traits.Add((Globals.traits)result);
                                    }
                                }
                            }
                            else if (_curve > _shotpower || _curve >= 60){
                                {
                                    List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Takes_Finesse_Freekicks, 30),
                            new ProbabilityObj(Globals.traits.Takes_Power_Freekicks, 15)
                                };
                                    object result = Globals.testChances(list);
                                    if (result != null)
                                    {
                                        traits.Add((Globals.traits)result);
                                        if ((Globals.traits)result == Globals.traits.Takes_Finesse_Freekicks)
                                        {
                                            List<ProbabilityObj> list2 = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Finesse_Shot, 30)
                                };
                                            object result2 = Globals.testChances(list2);
                                            if (result2 != null)
                                            {
                                                traits.Add((Globals.traits)result2);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case Globals.position.DefensiveMid:
                    case Globals.position.CenterMid:
                    case Globals.position.AttackingMid:
                    case Globals.position.Winger:
                    case Globals.position.Striker:
                        if (_fkacc >= 60)
                        {
                            {
                                List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Set_Play_Specialist, 35)
                                };
                                object result = Globals.testChances(list);
                                if (result != null)
                                {
                                    traits.Add((Globals.traits)result);
                                }
                            }
                            if (_curve <= _shotpower || _shotpower >= 60)
                            {
                                {
                                    List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Takes_Power_Freekicks, 35),
                            new ProbabilityObj(Globals.traits.Takes_Finesse_Freekicks, 15)
                                };
                                    object result = Globals.testChances(list);
                                    if (result != null)
                                    {
                                        traits.Add((Globals.traits)result);
                                    }
                                }
                            }
                            else if (_curve > _shotpower || _curve >= 60)
                            {
                                {
                                    List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Takes_Finesse_Freekicks, 35),
                            new ProbabilityObj(Globals.traits.Takes_Power_Freekicks, 15)
                                };
                                    object result = Globals.testChances(list);
                                    if (result != null)
                                    {
                                        traits.Add((Globals.traits)result);
                                        if ((Globals.traits)result == Globals.traits.Takes_Finesse_Freekicks)
                                        {
                                            List<ProbabilityObj> list2 = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Finesse_Shot, 30)
                                };
                                            object result2 = Globals.testChances(list2);
                                            if (result2 != null)
                                            {
                                                traits.Add((Globals.traits)result2);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                }

                if ((int)skillmoves < 4)
                {
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(true, 20)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            skillmoves = (Globals.skillmoves)((int)skillmoves + 1);
                        }
                    }
                }

                if ((int)weakfoot < 4)
                {
                    if ((int)weakfoot < 1) {
                        weakfoot = (Globals.weakfoot)((int)weakfoot + 1);
                    }
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(true, 20)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            weakfoot = (Globals.weakfoot)((int)weakfoot + 1);
                        }
                    }
                }
                if ((int)skillmoves > 2)
                {
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Technical_Dribbler, 40)
                        };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            traits.Add((Globals.traits)result);
                        }
                    }
                    switch (skillmoves)
                    {
                        case Globals.skillmoves.Five_Star:
                            traits.Add(Globals.traits.Flair);
                            break;
                        case Globals.skillmoves.Four_Star:
                            {
                                List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(true, 40)
                        };
                                object result = Globals.testChances(list);
                                if (result != null)
                                {
                                    traits.Add(Globals.traits.Flair);
                                }
                            }
                            break;
                    }
                }

                //outside foot
                if ((int)skillmoves > 2) {
                    switch (_weakfoot)
                    {
                        case Globals.weakfoot.Two_Star:
                        case Globals.weakfoot.Three_Star:
                            {
                                List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Outside_Foot_Shot, 40)
                            };
                                object result = Globals.testChances(list);
                                if (result != null)
                                {
                                    traits.Add((Globals.traits)result);
                                }
                            }
                            break;
                        case Globals.weakfoot.Four_Star:
                            {
                                List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Outside_Foot_Shot, 35)
                            };
                                object result = Globals.testChances(list);
                                if (result != null)
                                {
                                    traits.Add((Globals.traits)result);
                                }
                            }
                            break;
                        case Globals.weakfoot.Five_Star:
                            {
                                List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Outside_Foot_Shot, 30)
                            };
                                object result = Globals.testChances(list);
                                if (result != null)
                                {
                                    traits.Add((Globals.traits)result);
                                }
                            }
                            break;
                    }
                }

                //finesse shot
                if (traits.Contains(Globals.traits.Takes_Finesse_Freekicks)) {
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Finesse_Shot, 30)
                            };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            traits.Add((Globals.traits)result);
                        }
                    }
                }
                if (!traits.Contains(Globals.traits.Finesse_Shot) && _curve >= 60)
                {
                    {
                        List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Finesse_Shot, 30)
                            };
                        object result = Globals.testChances(list);
                        if (result != null)
                        {
                            traits.Add((Globals.traits)result);
                        }
                    }
                }

                //Injury
                {
                    List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Injury_Prone, 20),
                            new ProbabilityObj(Globals.traits.Solid_Player, 20)
                        };
                    object result = Globals.testChances(list);
                    if (result != null)
                    {
                        traits.Add((Globals.traits)result);
                    }
                }

                //Diver
                {
                    List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Diver, 10)
                        };
                    object result = Globals.testChances(list);
                    if (result != null)
                    {
                        traits.Add((Globals.traits)result);
                    }
                }

                // Early Crosser
                switch (_position)
                {
                    case Globals.position.FullBack:
                        {
                            List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Early_Crosser, 30)
                        };
                            object result = Globals.testChances(list);
                            if (result != null)
                            {
                                traits.Add((Globals.traits)result);
                            }
                        }
                        break;
                    case Globals.position.Winger:
                        {
                            List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Early_Crosser, 20)
                        };
                            object result = Globals.testChances(list);
                            if (result != null)
                            {
                                traits.Add((Globals.traits)result);
                            }
                        }
                        break;
                    case Globals.position.DefensiveMid:
                    case Globals.position.CenterMid:
                    case Globals.position.AttackingMid:
                        {
                            List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Early_Crosser, 10)
                        };
                            object result = Globals.testChances(list);
                            if (result != null)
                            {
                                traits.Add((Globals.traits)result);
                            }
                        }
                        break;
                }

                // Throw-In
                switch (_position)
                {
                    case Globals.position.FullBack:
                        {
                            List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Long_Throw_In, 20),
                            new ProbabilityObj(Globals.traits.Giant_Throw_In, 10)
                        };
                            object result = Globals.testChances(list);
                            if (result != null)
                            {
                                traits.Add((Globals.traits)result);
                            }
                        }
                        break;
                    case Globals.position.Winger:
                        {
                            List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Long_Throw_In, 10),
                            new ProbabilityObj(Globals.traits.Giant_Throw_In, 5)
                        };
                            object result = Globals.testChances(list);
                            if (result != null)
                            {
                                traits.Add((Globals.traits)result);
                            }
                        }
                        break;
                    case Globals.position.DefensiveMid:
                    case Globals.position.CenterMid:
                    case Globals.position.AttackingMid:
                        {
                            List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Long_Throw_In, 5)
                        };
                            object result = Globals.testChances(list);
                            if (result != null)
                            {
                                traits.Add((Globals.traits)result);
                            }
                        }
                        break;

                }
                composure = _potential - Globals.Random.Next(0, 10);
            }

            //////////////////////

            {
                List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Leadership, 5),
                            new ProbabilityObj(Globals.traits.Team_Player, 5)
                        };
                object result = Globals.testChances(list);
                if (result != null)
                {
                    traits.Add((Globals.traits)result);
                }
            }
            {
                List<ProbabilityObj> list = new List<ProbabilityObj>() {
                            new ProbabilityObj(Globals.traits.Blames_Teammates, 10)
                        };
                object result = Globals.testChances(list);
                if (result != null)
                {
                    traits.Add((Globals.traits)result);
                }
            }
            reactions = _potential - Globals.Random.Next(0, 10);
        }

    }

}
