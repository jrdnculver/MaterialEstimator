
namespace materialEstimatorCondensed
{
    partial class secondary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.showEstimateBtn = new System.Windows.Forms.Button();
            this.userUpdateLbl = new System.Windows.Forms.Label();
            this.homeBtn = new System.Windows.Forms.Button();
            this.secondaryListBox = new System.Windows.Forms.ListBox();
            this.addMaterialBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.sizeText = new System.Windows.Forms.TextBox();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.itemText = new System.Windows.Forms.TextBox();
            this.quanityLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.sizeLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.itemLbl = new System.Windows.Forms.Label();
            this.headerLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.categoryText = new System.Windows.Forms.TextBox();
            this.informationLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showEstimateBtn
            // 
            this.showEstimateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.showEstimateBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showEstimateBtn.ForeColor = System.Drawing.Color.White;
            this.showEstimateBtn.Location = new System.Drawing.Point(596, 229);
            this.showEstimateBtn.Name = "showEstimateBtn";
            this.showEstimateBtn.Size = new System.Drawing.Size(222, 41);
            this.showEstimateBtn.TabIndex = 10;
            this.showEstimateBtn.Text = "Show Estimate";
            this.showEstimateBtn.UseVisualStyleBackColor = false;
            this.showEstimateBtn.Click += new System.EventHandler(this.showEstimateBtn_Click);
            // 
            // userUpdateLbl
            // 
            this.userUpdateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userUpdateLbl.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userUpdateLbl.Location = new System.Drawing.Point(50, 507);
            this.userUpdateLbl.Name = "userUpdateLbl";
            this.userUpdateLbl.Size = new System.Drawing.Size(785, 18);
            this.userUpdateLbl.TabIndex = 31;
            this.userUpdateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.homeBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Location = new System.Drawing.Point(596, 172);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(222, 41);
            this.homeBtn.TabIndex = 9;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // secondaryListBox
            // 
            this.secondaryListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondaryListBox.FormattingEnabled = true;
            this.secondaryListBox.ItemHeight = 15;
            this.secondaryListBox.Location = new System.Drawing.Point(12, 309);
            this.secondaryListBox.Name = "secondaryListBox";
            this.secondaryListBox.Size = new System.Drawing.Size(860, 169);
            this.secondaryListBox.TabIndex = 29;
            this.secondaryListBox.SelectedIndexChanged += new System.EventHandler(this.secondaryListBox_SelectedIndexChanged);
            // 
            // addMaterialBtn
            // 
            this.addMaterialBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addMaterialBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addMaterialBtn.ForeColor = System.Drawing.Color.White;
            this.addMaterialBtn.Location = new System.Drawing.Point(596, 62);
            this.addMaterialBtn.Name = "addMaterialBtn";
            this.addMaterialBtn.Size = new System.Drawing.Size(222, 41);
            this.addMaterialBtn.TabIndex = 7;
            this.addMaterialBtn.Text = "Add Material";
            this.addMaterialBtn.UseVisualStyleBackColor = false;
            this.addMaterialBtn.Click += new System.EventHandler(this.addMaterialBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.clearBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(596, 118);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(222, 41);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // sizeText
            // 
            this.sizeText.Location = new System.Drawing.Point(204, 179);
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(239, 23);
            this.sizeText.TabIndex = 4;
            // 
            // quantityText
            // 
            this.quantityText.Location = new System.Drawing.Point(204, 240);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(239, 23);
            this.quantityText.TabIndex = 6;
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(204, 210);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(239, 23);
            this.priceText.TabIndex = 5;
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(204, 148);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(239, 23);
            this.descriptionText.TabIndex = 3;
            // 
            // itemText
            // 
            this.itemText.Location = new System.Drawing.Point(204, 116);
            this.itemText.Name = "itemText";
            this.itemText.Size = new System.Drawing.Size(239, 23);
            this.itemText.TabIndex = 2;
            // 
            // quanityLbl
            // 
            this.quanityLbl.AutoSize = true;
            this.quanityLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quanityLbl.Location = new System.Drawing.Point(91, 242);
            this.quanityLbl.Name = "quanityLbl";
            this.quanityLbl.Size = new System.Drawing.Size(80, 19);
            this.quanityLbl.TabIndex = 21;
            this.quanityLbl.Text = "Quantity";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLbl.Location = new System.Drawing.Point(91, 213);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(51, 19);
            this.priceLbl.TabIndex = 20;
            this.priceLbl.Text = "Price";
            // 
            // sizeLbl
            // 
            this.sizeLbl.AutoSize = true;
            this.sizeLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sizeLbl.Location = new System.Drawing.Point(91, 182);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(42, 19);
            this.sizeLbl.TabIndex = 19;
            this.sizeLbl.Text = "Size";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionLbl.Location = new System.Drawing.Point(91, 150);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(102, 19);
            this.descriptionLbl.TabIndex = 18;
            this.descriptionLbl.Text = "Description";
            // 
            // itemLbl
            // 
            this.itemLbl.AutoSize = true;
            this.itemLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemLbl.Location = new System.Drawing.Point(91, 118);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(46, 19);
            this.itemLbl.TabIndex = 17;
            this.itemLbl.Text = "Item";
            // 
            // headerLbl
            // 
            this.headerLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.headerLbl.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLbl.ForeColor = System.Drawing.Color.White;
            this.headerLbl.Location = new System.Drawing.Point(72, 20);
            this.headerLbl.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(438, 34);
            this.headerLbl.TabIndex = 16;
            this.headerLbl.Text = "header";
            this.headerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryLbl.Location = new System.Drawing.Point(91, 88);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(82, 19);
            this.categoryLbl.TabIndex = 17;
            this.categoryLbl.Text = "Category";
            // 
            // categoryText
            // 
            this.categoryText.Location = new System.Drawing.Point(204, 84);
            this.categoryText.Name = "categoryText";
            this.categoryText.Size = new System.Drawing.Size(239, 23);
            this.categoryText.TabIndex = 1;
            // 
            // informationLbl
            // 
            this.informationLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.informationLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.informationLbl.Location = new System.Drawing.Point(12, 283);
            this.informationLbl.Name = "informationLbl";
            this.informationLbl.Size = new System.Drawing.Size(860, 23);
            this.informationLbl.TabIndex = 32;
            // 
            // secondary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.informationLbl);
            this.Controls.Add(this.showEstimateBtn);
            this.Controls.Add(this.userUpdateLbl);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.secondaryListBox);
            this.Controls.Add(this.addMaterialBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.sizeText);
            this.Controls.Add(this.quantityText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.categoryText);
            this.Controls.Add(this.itemText);
            this.Controls.Add(this.quanityLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.sizeLbl);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.itemLbl);
            this.Controls.Add(this.headerLbl);
            this.Name = "secondary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Materials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showEstimateBtn;
        public System.Windows.Forms.Label userUpdateLbl;
        private System.Windows.Forms.Button homeBtn;
        public System.Windows.Forms.ListBox secondaryListBox;
        private System.Windows.Forms.Button addMaterialBtn;
        private System.Windows.Forms.Button clearBtn;
        public System.Windows.Forms.TextBox sizeText;
        public System.Windows.Forms.TextBox quantityText;
        public System.Windows.Forms.TextBox priceText;
        public System.Windows.Forms.TextBox descriptionText;
        public System.Windows.Forms.TextBox itemText;
        private System.Windows.Forms.Label quanityLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label sizeLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label itemLbl;
        public System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Label categoryLbl;
        public System.Windows.Forms.TextBox categoryText;
        private System.Windows.Forms.Label informationLbl;
    }
}