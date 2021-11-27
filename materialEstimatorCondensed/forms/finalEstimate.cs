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
            final = this;
        }

        private void finalEstimate_Load(object sender, EventArgs e)
        {
            primary.estimateList.settingFinalEstimate();
            finalListBox.HorizontalScrollbar = true;
        }

        private void saveEstimateBtn_Click_1(object sender, EventArgs e)
        {
            primary.saved.createItemsReceipt();
        }

        private void clearEstimateBtn_Click_1(object sender, EventArgs e)
        {
            primary.estimateList.clearAllFinalListBox();
        }

        private void removeItemBtn_Click_1(object sender, EventArgs e)
        {
            primary.estimateList.clearSingleFinalListBox();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Close();

            primary.home.Show();
        }
    }
}
