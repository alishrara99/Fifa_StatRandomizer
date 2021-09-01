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
            height_dropDown.Items.Insert((int)height.Short, EnumUtils.GetDescriptionFromEnumValue(height.Short));
            height_dropDown.Items.Insert((int)height.Average, EnumUtils.GetDescriptionFromEnumValue(height.Average));
            height_dropDown.Items.Insert((int)height.Tall, EnumUtils.GetDescriptionFromEnumValue(height.Tall));

            weight_dropDown.Items.Insert((int)weight.Lean, EnumUtils.GetDescriptionFromEnumValue(weight.Lean));
            weight_dropDown.Items.Insert((int)weight.Average, EnumUtils.GetDescriptionFromEnumValue(weight.Average));
            weight_dropDown.Items.Insert((int)weight.Stocky, EnumUtils.GetDescriptionFromEnumValue(weight.Stocky));

            position_dropDown.Items.Insert((int)position.GoalKeeper, EnumUtils.GetDescriptionFromEnumValue(position.GoalKeeper));
            position_dropDown.Items.Insert((int)position.FullBack, EnumUtils.GetDescriptionFromEnumValue(position.FullBack));
            position_dropDown.Items.Insert((int)position.CenterBack, EnumUtils.GetDescriptionFromEnumValue(position.CenterBack));
            position_dropDown.Items.Insert((int)position.DefensiveMid, EnumUtils.GetDescriptionFromEnumValue(position.DefensiveMid));
            position_dropDown.Items.Insert((int)position.CenterMid, EnumUtils.GetDescriptionFromEnumValue(position.CenterMid));
            position_dropDown.Items.Insert((int)position.AttackingMid, EnumUtils.GetDescriptionFromEnumValue(position.AttackingMid));
            position_dropDown.Items.Insert((int)position.Winger, EnumUtils.GetDescriptionFromEnumValue(position.Winger));
            position_dropDown.Items.Insert((int)position.Striker, EnumUtils.GetDescriptionFromEnumValue(position.Striker));
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
            Attributes attributes= new Attributes((int)potential_numericUpDown.Value,(height)height_dropDown.SelectedIndex, (weight)weight_dropDown.SelectedIndex,(position)position_dropDown.SelectedIndex);
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
    }
}
