
namespace materialEstimatorCondensed
{
    partial class primary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitBtn = new System.Windows.Forms.Button();
            this.roofBtn = new System.Windows.Forms.Button();
            this.openingBtn = new System.Windows.Forms.Button();
            this.wallsBtn = new System.Windows.Forms.Button();
            this.floorBtn = new System.Windows.Forms.Button();
            this.headerLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.exitBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(-2, 506);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(125, 56);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // roofBtn
            // 
            this.roofBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.roofBtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roofBtn.ForeColor = System.Drawing.Color.White;
            this.roofBtn.Location = new System.Drawing.Point(712, 507);
            this.roofBtn.Name = "roofBtn";
            this.roofBtn.Size = new System.Drawing.Size(125, 56);
            this.roofBtn.TabIndex = 4;
            this.roofBtn.Text = "Roof";
            this.roofBtn.UseVisualStyleBackColor = false;
            this.roofBtn.Click += new System.EventHandler(this.roofBtn_Click);
            // 
            // openingBtn
            // 
            this.openingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.openingBtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openingBtn.ForeColor = System.Drawing.Color.White;
            this.openingBtn.Location = new System.Drawing.Point(593, 507);
            this.openingBtn.Name = "openingBtn";
            this.openingBtn.Size = new System.Drawing.Size(125, 56);
            this.openingBtn.TabIndex = 3;
            this.openingBtn.Text = "Openings";
            this.openingBtn.UseVisualStyleBackColor = false;
            this.openingBtn.Click += new System.EventHandler(this.openingBtn_Click);
            // 
            // wallsBtn
            // 
            this.wallsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.wallsBtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wallsBtn.ForeColor = System.Drawing.Color.White;
            this.wallsBtn.Location = new System.Drawing.Point(475, 507);
            this.wallsBtn.Name = "wallsBtn";
            this.wallsBtn.Size = new System.Drawing.Size(125, 56);
            this.wallsBtn.TabIndex = 2;
            this.wallsBtn.Text = "Walls";
            this.wallsBtn.UseVisualStyleBackColor = false;
            this.wallsBtn.Click += new System.EventHandler(this.wallsBtn_Click);
            // 
            // floorBtn
            // 
            this.floorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.floorBtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.floorBtn.ForeColor = System.Drawing.Color.White;
            this.floorBtn.Location = new System.Drawing.Point(353, 507);
            this.floorBtn.Name = "floorBtn";
            this.floorBtn.Size = new System.Drawing.Size(125, 56);
            this.floorBtn.TabIndex = 1;
            this.floorBtn.Text = "Floor";
            this.floorBtn.UseVisualStyleBackColor = false;
            this.floorBtn.Click += new System.EventHandler(this.floorBtn_Click);
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.BackColor = System.Drawing.Color.Transparent;
            this.headerLbl.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.headerLbl.Location = new System.Drawing.Point(262, 39);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(338, 33);
            this.headerLbl.TabIndex = 100;
            this.headerLbl.Text = "Material Cost Estimator";
            // 
            // primary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.roofBtn);
            this.Controls.Add(this.openingBtn);
            this.Controls.Add(this.wallsBtn);
            this.Controls.Add(this.floorBtn);
            this.Controls.Add(this.headerLbl);
            this.Name = "primary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material Estimator";
            this.Load += new System.EventHandler(this.primary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        public System.Windows.Forms.Button roofBtn;
        public System.Windows.Forms.Button openingBtn;
        public System.Windows.Forms.Button wallsBtn;
        public System.Windows.Forms.Button floorBtn;
        private System.Windows.Forms.Label headerLbl;
    }
}

