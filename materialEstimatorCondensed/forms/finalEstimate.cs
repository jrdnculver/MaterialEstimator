using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace materialEstimatorCondensed
{
    public partial class finalEstimate : Form
    {

        public static finalEstimate final = new finalEstimate();

        public finalEstimate()
        {
            InitializeComponent();
            // initialize form
            final = this;
        }

        // setting estimate list to listbox and applying horizontal bar
        private void finalEstimate_Load(object sender, EventArgs e)
        {
            primary.estimateList.settingFinalEstimate();
            finalListBox.HorizontalScrollbar = true;
        }

        // saving all items to a receipt file
        private void saveEstimateBtn_Click_1(object sender, EventArgs e)
        {
            primary.saved.createItemsReceipt();
        }

        // clears all items from estimate list
        private void clearEstimateBtn_Click_1(object sender, EventArgs e)
        {
            primary.estimateList.clearAllFinalListBox();
        }

        // clear a single item from the estimate list
        private void removeItemBtn_Click_1(object sender, EventArgs e)
        {
            primary.estimateList.clearSingleFinalListBox();
        }

        // return to the home form
        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Close();

            primary.home.Show();
        }
    }
}
