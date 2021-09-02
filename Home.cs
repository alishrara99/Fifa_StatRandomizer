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
        }
        private void resetComponents() {
            potential_numericUpDown.Value = Globals.NUMERICUPDOWN_DEFAULT_VALUE;
            height_dropDown.SelectedItem = null;
            height_dropDown.Text = Globals.COMBOBOX_DEFAULT_TEXT;
            weight_dropDown.SelectedItem = null;
            weight_dropDown.Text = Globals.COMBOBOX_DEFAULT_TEXT;
            position_dropDown.SelectedItem = null;
            position_dropDown.Text = Globals.COMBOBOX_DEFAULT_TEXT;
            aggression_txtbx.Text = null;
            attpositioning_txtbx.Text = null;
            balance_txtbx.Text = null;
            composure_txtbx.Text = null;
            jumping_txtbx.Text = null;
            penalties_txtbx.Text = null;
            reactions_txtbx.Text = null;
            stamina_txtbx.Text = null;
        }
        private void generateStats() {
            if (height_dropDown.SelectedItem == null || weight_dropDown.SelectedItem == null || position_dropDown.SelectedItem == null) {
                Console.WriteLine("Error");
                return;
            }
            Attributes attributes= new Attributes((int)potential_numericUpDown.Value,(Globals.height)height_dropDown.SelectedIndex, (Globals.weight)weight_dropDown.SelectedIndex,(Globals.position)position_dropDown.SelectedIndex);
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
        }
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            populateComboBoxes();
        }

        private void reset_Btn_Click(object sender, EventArgs e)
        {
            resetComponents();
        }

        private void generate_Btn_Click(object sender, EventArgs e)
        {
            generateStats();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
