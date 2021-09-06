using Fifa_StatRandomizer.Entities;
using Fifa_StatRandomizer.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fifa_StatRandomizer
{
    public partial class Home : Form
    {
        private void populateComboBoxes() {
            height_dropDown.Items.Insert((int)Globals.height.Short, EnumUtils.GetDescriptionFromEnumValue(Globals.height.Short));
            height_dropDown.Items.Insert((int)Globals.height.Average, EnumUtils.GetDescriptionFromEnumValue(Globals.height.Average));
            height_dropDown.Items.Insert((int)Globals.height.Tall, EnumUtils.GetDescriptionFromEnumValue(Globals.height.Tall));

            weight_dropDown.Items.Insert((int)Globals.weight.Lean, EnumUtils.GetDescriptionFromEnumValue(Globals.weight.Lean));
            weight_dropDown.Items.Insert((int)Globals.weight.Average, EnumUtils.GetDescriptionFromEnumValue(Globals.weight.Average));
            weight_dropDown.Items.Insert((int)Globals.weight.Stocky, EnumUtils.GetDescriptionFromEnumValue(Globals.weight.Stocky));

            position_dropDown.Items.Insert((int)Globals.position.GoalKeeper, EnumUtils.GetDescriptionFromEnumValue(Globals.position.GoalKeeper));
            position_dropDown.Items.Insert((int)Globals.position.FullBack, EnumUtils.GetDescriptionFromEnumValue(Globals.position.FullBack));
            position_dropDown.Items.Insert((int)Globals.position.CenterBack, EnumUtils.GetDescriptionFromEnumValue(Globals.position.CenterBack));
            position_dropDown.Items.Insert((int)Globals.position.DefensiveMid, EnumUtils.GetDescriptionFromEnumValue(Globals.position.DefensiveMid));
            position_dropDown.Items.Insert((int)Globals.position.CenterMid, EnumUtils.GetDescriptionFromEnumValue(Globals.position.CenterMid));
            position_dropDown.Items.Insert((int)Globals.position.AttackingMid, EnumUtils.GetDescriptionFromEnumValue(Globals.position.AttackingMid));
            position_dropDown.Items.Insert((int)Globals.position.Winger, EnumUtils.GetDescriptionFromEnumValue(Globals.position.Winger));
            position_dropDown.Items.Insert((int)Globals.position.Striker, EnumUtils.GetDescriptionFromEnumValue(Globals.position.Striker));

            skillmoves__drpdwn.Items.Insert((int)Globals.skillmoves.One_Star, EnumUtils.GetDescriptionFromEnumValue(Globals.skillmoves.One_Star));
            skillmoves__drpdwn.Items.Insert((int)Globals.skillmoves.Two_Star, EnumUtils.GetDescriptionFromEnumValue(Globals.skillmoves.Two_Star));
            skillmoves__drpdwn.Items.Insert((int)Globals.skillmoves.Three_Star, EnumUtils.GetDescriptionFromEnumValue(Globals.skillmoves.Three_Star));
            skillmoves__drpdwn.Items.Insert((int)Globals.skillmoves.Four_Star, EnumUtils.GetDescriptionFromEnumValue(Globals.skillmoves.Four_Star));
            skillmoves__drpdwn.Items.Insert((int)Globals.skillmoves.Five_Star, EnumUtils.GetDescriptionFromEnumValue(Globals.skillmoves.Five_Star));

            weakfoot_drpdwn.Items.Insert((int)Globals.weakfoot.One_Star, EnumUtils.GetDescriptionFromEnumValue(Globals.weakfoot.One_Star));
            weakfoot_drpdwn.Items.Insert((int)Globals.weakfoot.Two_Star, EnumUtils.GetDescriptionFromEnumValue(Globals.weakfoot.Two_Star));
            weakfoot_drpdwn.Items.Insert((int)Globals.weakfoot.Three_Star, EnumUtils.GetDescriptionFromEnumValue(Globals.weakfoot.Three_Star));
            weakfoot_drpdwn.Items.Insert((int)Globals.weakfoot.Four_Star, EnumUtils.GetDescriptionFromEnumValue(Globals.weakfoot.Four_Star));
            weakfoot_drpdwn.Items.Insert((int)Globals.weakfoot.Five_Star, EnumUtils.GetDescriptionFromEnumValue(Globals.weakfoot.Five_Star));
        }
        private void resetComponents() {
            potential_numericUpDown.Value = Globals.NUMERICUPDOWN_DEFAULT_VALUE;
            fkacc_numupdwn.Value = Globals.NUMERICUPDOWN_DEFAULT_VALUE;
            curve_numupdwn.Value = Globals.NUMERICUPDOWN_DEFAULT_VALUE;
            shotpower_numupdwn.Value = Globals.NUMERICUPDOWN_DEFAULT_VALUE;
            height_dropDown.SelectedItem = null;
            height_dropDown.Text = Globals.COMBOBOX_DEFAULT_TEXT;
            weight_dropDown.SelectedItem = null;
            weight_dropDown.Text = Globals.COMBOBOX_DEFAULT_TEXT;
            position_dropDown.SelectedItem = null;
            position_dropDown.Text = Globals.COMBOBOX_DEFAULT_TEXT;
            skillmoves__drpdwn.SelectedItem = null;
            skillmoves__drpdwn.Text = Globals.COMBOBOX_DEFAULT_TEXT;
            weakfoot_drpdwn.SelectedItem = null;
            weakfoot_drpdwn.Text = Globals.COMBOBOX_DEFAULT_TEXT;
            aggression_txtbx.Text = null;
            attpositioning_txtbx.Text = null;
            balance_txtbx.Text = null;
            composure_txtbx.Text = null;
            jumping_txtbx.Text = null;
            penalties_txtbx.Text = null;
            reactions_txtbx.Text = null;
            stamina_txtbx.Text = null;
            attWorkRate_txtbx.Text = null;
            defWorkRate_txtbx.Text = null;
            skillmoves_txtbx.Text = null;
            weakfoot_txtbx.Text = null;
            traits_txtbx.Text = null;
            tattooRA_txtbx.Text = null;
            tattooLA_txtbx.Text = null;
            tattooRN_txtbx.Text = null;
            tattooLN_txtbx.Text = null;
            tattooBN_txtbx.Text = null;
        }
        private void generateMisc()
        {
            if (position_dropDown.SelectedItem == null)
            {
                Console.WriteLine("Error");
                return;
            }

            Misc misc = new Misc((Globals.position)position_dropDown.SelectedIndex);
            displayMisc(misc);
        }
        private void displayMisc(Misc _misc)
        {
            tattooRA_txtbx.Text = null;
            tattooLA_txtbx.Text = null;
            tattooRN_txtbx.Text = null;
            tattooLN_txtbx.Text = null;
            tattooBN_txtbx.Text = null;
            if (_misc.tattoo_rightArm > 0)
            {
                tattooRA_txtbx.Text = Convert.ToString(_misc.tattoo_rightArm);
            }
            if (_misc.tattoo_leftArm > 0)
            {
                tattooLA_txtbx.Text = Convert.ToString(_misc.tattoo_leftArm);
            }
            if (_misc.tattoo_rightNeck > 0)
            {
                tattooRN_txtbx.Text = Convert.ToString(_misc.tattoo_rightNeck);
            }
            if (_misc.tattoo_leftNeck > 0)
            {
                tattooLN_txtbx.Text = Convert.ToString(_misc.tattoo_leftNeck);
            }
            if (_misc.tattoo_backNeck > 0)
            {
                tattooBN_txtbx.Text = Convert.ToString(_misc.tattoo_backNeck);
            }
        }
        private void generateStats() {
            if (height_dropDown.SelectedItem == null || weight_dropDown.SelectedItem == null || position_dropDown.SelectedItem == null || skillmoves__drpdwn.SelectedItem == null || weakfoot_drpdwn.SelectedItem == null) {
                Console.WriteLine("Error");
                return;
            }
            Attributes attributes= new Attributes((int)potential_numericUpDown.Value, (int)fkacc_numupdwn.Value, (int)curve_numupdwn.Value, (int)shotpower_numupdwn.Value, (Globals.height)height_dropDown.SelectedIndex, (Globals.weight)weight_dropDown.SelectedIndex,(Globals.position)position_dropDown.SelectedIndex,(Globals.skillmoves)skillmoves__drpdwn.SelectedIndex, (Globals.weakfoot)weakfoot_drpdwn.SelectedIndex);
            displayStats(attributes);
        }
        private void displayStats(Attributes _attributes) {
            aggression_txtbx.Text = Convert.ToString(_attributes.aggression);
            attpositioning_txtbx.Text = Convert.ToString(_attributes.att_positioning);
            balance_txtbx.Text = Convert.ToString(_attributes.balance);
            composure_txtbx.Text = Convert.ToString(_attributes.composure);
            jumping_txtbx.Text = Convert.ToString(_attributes.jumping);
            penalties_txtbx.Text = Convert.ToString(_attributes.penalties);
            reactions_txtbx.Text = Convert.ToString(_attributes.reactions);
            stamina_txtbx.Text = Convert.ToString(_attributes.stamina);
            attWorkRate_txtbx.Text = EnumUtils.GetDescriptionFromEnumValue(_attributes.att_workrate);
            defWorkRate_txtbx.Text = EnumUtils.GetDescriptionFromEnumValue(_attributes.def_workrate);
            skillmoves_txtbx.Text = EnumUtils.GetDescriptionFromEnumValue(_attributes.skillmoves);
            weakfoot_txtbx.Text = EnumUtils.GetDescriptionFromEnumValue(_attributes.weakfoot);
            traits_txtbx.Text = generateTraits(_attributes.traits);
        }
        private string generateTraits(List<Globals.traits> traits)
        {
            string text = "";
            foreach (Globals.traits element in traits)
            { 
            text = text + EnumUtils.GetDescriptionFromEnumValue(element)+ "\r\n" ;
            }
            return text;
        }
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            populateComboBoxes();
            potential_numericUpDown.Focus();
        }

        private void reset_Btn_Click(object sender, EventArgs e)
        {
            resetComponents();
        }

        private void generate_Btn_Click(object sender, EventArgs e)
        {
            generateMisc();
            generateStats();
        }
    }
}
