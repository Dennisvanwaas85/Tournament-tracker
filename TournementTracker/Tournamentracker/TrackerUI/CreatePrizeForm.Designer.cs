namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            this.createTeam = new System.Windows.Forms.Label();
            this.PlaceNumberValue = new System.Windows.Forms.TextBox();
            this.PlaceNumberLabel = new System.Windows.Forms.Label();
            this.priceNameValue = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.pricePercentageValue = new System.Windows.Forms.TextBox();
            this.pricePercentageLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTeam
            // 
            resources.ApplyResources(this.createTeam, "createTeam");
            this.createTeam.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createTeam.Name = "createTeam";
            // 
            // PlaceNumberValue
            // 
            resources.ApplyResources(this.PlaceNumberValue, "PlaceNumberValue");
            this.PlaceNumberValue.Name = "PlaceNumberValue";
            this.PlaceNumberValue.TextChanged += new System.EventHandler(this.firstNameValue_TextChanged);
            // 
            // PlaceNumberLabel
            // 
            resources.ApplyResources(this.PlaceNumberLabel, "PlaceNumberLabel");
            this.PlaceNumberLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PlaceNumberLabel.Name = "PlaceNumberLabel";
            // 
            // priceNameValue
            // 
            resources.ApplyResources(this.priceNameValue, "priceNameValue");
            this.priceNameValue.Name = "priceNameValue";
            // 
            // placeNameLabel
            // 
            resources.ApplyResources(this.placeNameLabel, "placeNameLabel");
            this.placeNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.placeNameLabel.Name = "placeNameLabel";
            // 
            // prizeAmountValue
            // 
            resources.ApplyResources(this.prizeAmountValue, "prizeAmountValue");
            this.prizeAmountValue.Name = "prizeAmountValue";
            // 
            // prizeAmountLabel
            // 
            resources.ApplyResources(this.prizeAmountLabel, "prizeAmountLabel");
            this.prizeAmountLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            // 
            // pricePercentageValue
            // 
            resources.ApplyResources(this.pricePercentageValue, "pricePercentageValue");
            this.pricePercentageValue.Name = "pricePercentageValue";
            // 
            // pricePercentageLabel
            // 
            resources.ApplyResources(this.pricePercentageLabel, "pricePercentageLabel");
            this.pricePercentageLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pricePercentageLabel.Name = "pricePercentageLabel";
            // 
            // orLabel
            // 
            resources.ApplyResources(this.orLabel, "orLabel");
            this.orLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.orLabel.Name = "orLabel";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.createPrizeButton, "createPrizeButton");
            this.createPrizeButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // CreatePrizeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.pricePercentageValue);
            this.Controls.Add(this.pricePercentageLabel);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.priceNameValue);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.PlaceNumberValue);
            this.Controls.Add(this.PlaceNumberLabel);
            this.Controls.Add(this.createTeam);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Name = "CreatePrizeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTeam;
        private System.Windows.Forms.TextBox PlaceNumberValue;
        private System.Windows.Forms.Label PlaceNumberLabel;
        private System.Windows.Forms.TextBox priceNameValue;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox prizeAmountValue;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.TextBox pricePercentageValue;
        private System.Windows.Forms.Label pricePercentageLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button createPrizeButton;
    }
}