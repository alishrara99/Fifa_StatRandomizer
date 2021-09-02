using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        public Attributes(int _potential, Globals.height _height , Globals.weight _weight , Globals.position _position)
        {
            aggression = _potential - Globals.Random.Next(0, 1);
            att_positioning = _potential - Globals.Random.Next(0, 10);
            balance = _potential - Globals.Random.Next(0, 10);
            composure = _potential - Globals.Random.Next(0,10);
            jumping = _potential - Globals.Random.Next(0, 10);
            penalties = _potential - Globals.Random.Next(0, 10);
            reactions = _potential - Globals.Random.Next(0, 10);
            stamina = Globals.Random.Next(65, _potential);
        }

    }
}
