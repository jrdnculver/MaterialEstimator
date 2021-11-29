using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace materialEstimatorCondensed
{
    public partial class secondary : Form
    {
        public static secondary floor = new secondary();
        public static secondary wall = new secondary();
        public static secondary openings = new secondary();
        public static secondary roof = new secondary();

        public secondary()
        {
            InitializeComponent();
            // initialize potential forms
            floor = this;
            wall = this;
            openings = this;
            roof = this;
            informationLbl.Text = "Select an item from the listbox, fill in the quanity, and press Add Material";
        }

        // Will add selected material
        private void addMaterialBtn_Click(object sender, EventArgs e)
        {
            secondary form = primary.material.getCorrectForm();

            primary.material.addTextBoxValues(form);

        }

        // Clear textboxes
        private void clearBtn_Click(object sender, EventArgs e)
        {
            secondary form = primary.material.getCorrectForm();

            primary.material.clearTextBoxes(form);
        }

        // Return to home
        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            secondary form = primary.material.getCorrectForm();

            primary.material.clearTextBoxes(form);

            primary.material.clearListBox(form);

            primary.home.Show();
        }

        // Go to eimate page
        private void showEstimateBtn_Click(object sender, EventArgs e)
        {
            finalEstimate final = new finalEstimate();

            this.Hide();

            final.Show();
        }

        // if item selected, will set textbox values to item selection
        private void secondaryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            secondary form = primary.material.getCorrectForm();

            string selectedItem = secondaryListBox.SelectedItem.ToString();

            List<string> finalSelected = primary.estimate.ObjectSelection(selectedItem);

            primary.material.setTextBoxValues(form, finalSelected);

        }
    }
}
