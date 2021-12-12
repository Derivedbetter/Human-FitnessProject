
namespace Human_FitnessProject
{
    partial class recalcBMIform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recalcBMIform));
            this.squareLogo = new System.Windows.Forms.PictureBox();
            this.squareLogo2 = new System.Windows.Forms.PictureBox();
            this.explainLabel = new System.Windows.Forms.Label();
            this.bmiButton = new System.Windows.Forms.Button();
            this.bmiCalculated = new System.Windows.Forms.Label();
            this.bmiPanel = new System.Windows.Forms.Panel();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.newheightBox = new System.Windows.Forms.TextBox();
            this.newweightBox = new System.Windows.Forms.TextBox();
            this.longLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.goalsLabel = new System.Windows.Forms.Label();
            this.gobackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.squareLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareLogo2)).BeginInit();
            this.bmiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.longLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // squareLogo
            // 
            this.squareLogo.Image = global::Human_FitnessProject.Properties.Resources.Color_logo_with_background;
            this.squareLogo.Location = new System.Drawing.Point(12, 9);
            this.squareLogo.Name = "squareLogo";
            this.squareLogo.Size = new System.Drawing.Size(147, 148);
            this.squareLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.squareLogo.TabIndex = 44;
            this.squareLogo.TabStop = false;
            // 
            // squareLogo2
            // 
            this.squareLogo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.squareLogo2.Image = global::Human_FitnessProject.Properties.Resources.Color_logo_with_background;
            this.squareLogo2.Location = new System.Drawing.Point(1199, 9);
            this.squareLogo2.Name = "squareLogo2";
            this.squareLogo2.Size = new System.Drawing.Size(147, 148);
            this.squareLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.squareLogo2.TabIndex = 46;
            this.squareLogo2.TabStop = false;
            // 
            // explainLabel
            // 
            this.explainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.explainLabel.AutoSize = true;
            this.explainLabel.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explainLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.explainLabel.Location = new System.Drawing.Point(43, 0);
            this.explainLabel.Name = "explainLabel";
            this.explainLabel.Size = new System.Drawing.Size(467, 196);
            this.explainLabel.TabIndex = 0;
            this.explainLabel.Text = resources.GetString("explainLabel.Text");
            this.explainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.explainLabel.Click += new System.EventHandler(this.explainLabel_Click);
            // 
            // bmiButton
            // 
            this.bmiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bmiButton.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bmiButton.Location = new System.Drawing.Point(80, 403);
            this.bmiButton.Name = "bmiButton";
            this.bmiButton.Size = new System.Drawing.Size(409, 41);
            this.bmiButton.TabIndex = 1;
            this.bmiButton.Text = "ReCalcualte BMI";
            this.bmiButton.UseVisualStyleBackColor = false;
            this.bmiButton.Click += new System.EventHandler(this.bmiButton_Click);
            // 
            // bmiCalculated
            // 
            this.bmiCalculated.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bmiCalculated.Font = new System.Drawing.Font("Monotype Corsiva", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiCalculated.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bmiCalculated.Location = new System.Drawing.Point(83, 352);
            this.bmiCalculated.Name = "bmiCalculated";
            this.bmiCalculated.Size = new System.Drawing.Size(406, 39);
            this.bmiCalculated.TabIndex = 2;
            this.bmiCalculated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bmiPanel
            // 
            this.bmiPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bmiPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bmiPanel.Controls.Add(this.instructionsLabel);
            this.bmiPanel.Controls.Add(this.heightLabel);
            this.bmiPanel.Controls.Add(this.weightLabel);
            this.bmiPanel.Controls.Add(this.newheightBox);
            this.bmiPanel.Controls.Add(this.newweightBox);
            this.bmiPanel.Controls.Add(this.bmiCalculated);
            this.bmiPanel.Controls.Add(this.bmiButton);
            this.bmiPanel.Controls.Add(this.explainLabel);
            this.bmiPanel.Location = new System.Drawing.Point(355, 76);
            this.bmiPanel.Name = "bmiPanel";
            this.bmiPanel.Size = new System.Drawing.Size(556, 447);
            this.bmiPanel.TabIndex = 54;
            this.bmiPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bmiPanel_Paint);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.instructionsLabel.Location = new System.Drawing.Point(104, 314);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(359, 24);
            this.instructionsLabel.TabIndex = 7;
            this.instructionsLabel.Text = "Fill in the Boxes above and then press Recalculate";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.heightLabel.Location = new System.Drawing.Point(397, 269);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(77, 28);
            this.heightLabel.TabIndex = 6;
            this.heightLabel.Text = "Height";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.weightLabel.Location = new System.Drawing.Point(75, 269);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(133, 28);
            this.weightLabel.TabIndex = 5;
            this.weightLabel.Text = "New Weight";
            // 
            // newheightBox
            // 
            this.newheightBox.Location = new System.Drawing.Point(353, 240);
            this.newheightBox.Name = "newheightBox";
            this.newheightBox.Size = new System.Drawing.Size(157, 26);
            this.newheightBox.TabIndex = 4;
            // 
            // newweightBox
            // 
            this.newweightBox.Location = new System.Drawing.Point(61, 240);
            this.newweightBox.Name = "newweightBox";
            this.newweightBox.Size = new System.Drawing.Size(165, 26);
            this.newweightBox.TabIndex = 3;
            this.newweightBox.TextChanged += new System.EventHandler(this.newweightBox_TextChanged);
            // 
            // longLogo
            // 
            this.longLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.longLogo.Image = ((System.Drawing.Image)(resources.GetObject("longLogo.Image")));
            this.longLogo.Location = new System.Drawing.Point(416, 529);
            this.longLogo.Name = "longLogo";
            this.longLogo.Size = new System.Drawing.Size(449, 96);
            this.longLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.longLogo.TabIndex = 45;
            this.longLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Human_FitnessProject.Properties.Resources.BMI;
            this.pictureBox1.Location = new System.Drawing.Point(908, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // goalsLabel
            // 
            this.goalsLabel.AutoSize = true;
            this.goalsLabel.Font = new System.Drawing.Font("Monotype Corsiva", 22.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.goalsLabel.Location = new System.Drawing.Point(295, 9);
            this.goalsLabel.Name = "goalsLabel";
            this.goalsLabel.Size = new System.Drawing.Size(534, 45);
            this.goalsLabel.TabIndex = 48;
            this.goalsLabel.Text = "You can Recalculate your BMI here!\r\n";
            this.goalsLabel.Click += new System.EventHandler(this.goalsLabel_Click);
            // 
            // gobackButton
            // 
            this.gobackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gobackButton.BackColor = System.Drawing.Color.Red;
            this.gobackButton.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gobackButton.Location = new System.Drawing.Point(39, 577);
            this.gobackButton.Name = "gobackButton";
            this.gobackButton.Size = new System.Drawing.Size(330, 42);
            this.gobackButton.TabIndex = 51;
            this.gobackButton.Text = "Go Back";
            this.gobackButton.UseVisualStyleBackColor = false;
            this.gobackButton.Click += new System.EventHandler(this.gobackButton_Click);
            // 
            // recalcBMIform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1359, 634);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bmiPanel);
            this.Controls.Add(this.longLogo);
            this.Controls.Add(this.gobackButton);
            this.Controls.Add(this.goalsLabel);
            this.Controls.Add(this.squareLogo2);
            this.Controls.Add(this.squareLogo);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "recalcBMIform";
            this.Text = "Wow! How did you find this page? Happy easter egging!";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.squareLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareLogo2)).EndInit();
            this.bmiPanel.ResumeLayout(false);
            this.bmiPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.longLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox squareLogo;
        private System.Windows.Forms.PictureBox squareLogo2;
        private System.Windows.Forms.Label explainLabel;
        private System.Windows.Forms.Button bmiButton;
        private System.Windows.Forms.Label bmiCalculated;
        private System.Windows.Forms.Panel bmiPanel;
        private System.Windows.Forms.PictureBox longLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label goalsLabel;
        private System.Windows.Forms.Button gobackButton;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox newheightBox;
        private System.Windows.Forms.TextBox newweightBox;
        private System.Windows.Forms.Label instructionsLabel;
    }
}