using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace materialEstimatorCondensed
{
    public partial class primary : Form
    {
        public static primary home = new primary();

        public static Material material = new Material();

        public static MaterialSelection estimate = new MaterialSelection();

        public static EstimateList estimateList = new EstimateList();

        public static Saving saved = new Saving();

        
        public primary()
        {
            InitializeComponent();
            // initialize form
            home = this;
        }

        // close the program
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // reads json and leads to correct form Floor
        private void floorBtn_Click(object sender, EventArgs e)
        {
            EstimateList.ActiveForm = 1;
            material.readJson();
            material.setFloor();
            this.Hide();
            secondary.floor.Show();
        }

        // reads json and leads to correct form Wall
        private void wallsBtn_Click(object sender, EventArgs e)
        {
            EstimateList.ActiveForm = 2;
            material.readJson();
            material.setWall();
            this.Hide();
            secondary.wall.Show();

        }

        // reads json and leads to correct form Openings
        private void openingBtn_Click(object sender, EventArgs e)
        {
            EstimateList.ActiveForm = 3;
            material.readJson();
            material.setOpenings();
            this.Hide();
            secondary.openings.Show();
        }

        // reads json and leads to correct form Roof
        private void roofBtn_Click(object sender, EventArgs e)
        {
            EstimateList.ActiveForm = 4;
            material.readJson();
            material.setRoof();
            this.Hide();
            secondary.roof.Show();
        }

        // find image and set as background of primary form
        private void primary_Load(object sender, EventArgs e)
        {
            string imagePath = material.getImageLocation(@"houseNiceSky.jpg");
            Image primaryBackground = new Bitmap(imagePath);
            this.BackgroundImage = primaryBackground;
        }
    }
}
