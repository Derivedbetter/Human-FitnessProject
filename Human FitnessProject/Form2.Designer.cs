
namespace Human_FitnessProject
{
    partial class intake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(intake));
            this.backbutton = new System.Windows.Forms.Button();
            this.initialInfo = new System.Windows.Forms.Label();
            this.physicalInfo = new System.Windows.Forms.Label();
            this.initialinfo2 = new System.Windows.Forms.Label();
            this.boom = new System.Windows.Forms.Label();
            this.initinfoPanel = new System.Windows.Forms.Panel();
            this.dobBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.clientDOB = new System.Windows.Forms.Label();
            this.clientAge = new System.Windows.Forms.Label();
            this.clientName = new System.Windows.Forms.Label();
            this.attribPanel = new System.Windows.Forms.Panel();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.genderBox = new System.Windows.Forms.TextBox();
            this.clientHeight = new System.Windows.Forms.Label();
            this.clientWeight = new System.Windows.Forms.Label();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.clientGender = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.nextButton = new System.Windows.Forms.Button();
            this.save1 = new System.Windows.Forms.Button();
            this.save2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logo3 = new System.Windows.Forms.PictureBox();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.initinfoPanel.SuspendLayout();
            this.attribPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Crimson;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backbutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backbutton.Location = new System.Drawing.Point(10, 559);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(434, 37);
            this.backbutton.TabIndex = 1;
            this.backbutton.Text = "Take me Back to where I started...";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // initialInfo
            // 
            this.initialInfo.AutoSize = true;
            this.initialInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.initialInfo.Location = new System.Drawing.Point(37, 206);
            this.initialInfo.Name = "initialInfo";
            this.initialInfo.Size = new System.Drawing.Size(303, 25);
            this.initialInfo.TabIndex = 5;
            this.initialInfo.Text = "Now that you are here, let\'s gather";
            // 
            // physicalInfo
            // 
            this.physicalInfo.AutoSize = true;
            this.physicalInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.physicalInfo.Location = new System.Drawing.Point(1055, 233);
            this.physicalInfo.Name = "physicalInfo";
            this.physicalInfo.Size = new System.Drawing.Size(238, 25);
            this.physicalInfo.TabIndex = 6;
            this.physicalInfo.Text = "Initial Physical Attributes";
            // 
            // initialinfo2
            // 
            this.initialinfo2.AutoSize = true;
            this.initialinfo2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.initialinfo2.Location = new System.Drawing.Point(78, 241);
            this.initialinfo2.Name = "initialinfo2";
            this.initialinfo2.Size = new System.Drawing.Size(215, 25);
            this.initialinfo2.TabIndex = 7;
            this.initialinfo2.Text = "some initial information";
            // 
            // boom
            // 
            this.boom.AutoSize = true;
            this.boom.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boom.Location = new System.Drawing.Point(447, -5);
            this.boom.Name = "boom";
            this.boom.Size = new System.Drawing.Size(494, 79);
            this.boom.TabIndex = 8;
            this.boom.Text = "BOOM! You did it!";
            // 
            // initinfoPanel
            // 
            this.initinfoPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.initinfoPanel.Controls.Add(this.dobBox);
            this.initinfoPanel.Controls.Add(this.ageBox);
            this.initinfoPanel.Controls.Add(this.nameBox);
            this.initinfoPanel.Controls.Add(this.clientDOB);
            this.initinfoPanel.Controls.Add(this.clientAge);
            this.initinfoPanel.Controls.Add(this.clientName);
            this.initinfoPanel.Location = new System.Drawing.Point(10, 268);
            this.initinfoPanel.Name = "initinfoPanel";
            this.initinfoPanel.Size = new System.Drawing.Size(365, 239);
            this.initinfoPanel.TabIndex = 9;
            this.initinfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.initinfoPanel_Paint);
            // 
            // dobBox
            // 
            this.dobBox.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobBox.Location = new System.Drawing.Point(170, 197);
            this.dobBox.Name = "dobBox";
            this.dobBox.Size = new System.Drawing.Size(179, 38);
            this.dobBox.TabIndex = 6;
            this.dobBox.Visible = false;
            this.dobBox.TextChanged += new System.EventHandler(this.dobBox_TextChanged);
            // 
            // ageBox
            // 
            this.ageBox.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBox.Location = new System.Drawing.Point(172, 137);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(176, 38);
            this.ageBox.TabIndex = 5;
            this.ageBox.Visible = false;
            this.ageBox.TextChanged += new System.EventHandler(this.ageBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(172, 76);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(176, 38);
            this.nameBox.TabIndex = 4;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // clientDOB
            // 
            this.clientDOB.AutoSize = true;
            this.clientDOB.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientDOB.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clientDOB.Location = new System.Drawing.Point(3, 197);
            this.clientDOB.Name = "clientDOB";
            this.clientDOB.Size = new System.Drawing.Size(173, 33);
            this.clientDOB.TabIndex = 2;
            this.clientDOB.Text = "Date Of Birth:";
            this.clientDOB.Click += new System.EventHandler(this.label3_Click);
            // 
            // clientAge
            // 
            this.clientAge.AutoSize = true;
            this.clientAge.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAge.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clientAge.Location = new System.Drawing.Point(31, 137);
            this.clientAge.Name = "clientAge";
            this.clientAge.Size = new System.Drawing.Size(63, 33);
            this.clientAge.TabIndex = 1;
            this.clientAge.Text = "Age:";
            // 
            // clientName
            // 
            this.clientName.AutoSize = true;
            this.clientName.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clientName.Location = new System.Drawing.Point(31, 76);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(134, 33);
            this.clientName.TabIndex = 0;
            this.clientName.Text = "Full Name:";
            // 
            // attribPanel
            // 
            this.attribPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.attribPanel.Controls.Add(this.heightBox);
            this.attribPanel.Controls.Add(this.genderBox);
            this.attribPanel.Controls.Add(this.clientHeight);
            this.attribPanel.Controls.Add(this.clientWeight);
            this.attribPanel.Controls.Add(this.weightBox);
            this.attribPanel.Controls.Add(this.clientGender);
            this.attribPanel.Location = new System.Drawing.Point(981, 268);
            this.attribPanel.Name = "attribPanel";
            this.attribPanel.Size = new System.Drawing.Size(365, 239);
            this.attribPanel.TabIndex = 10;
            this.attribPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.attribPanel_Paint);
            // 
            // heightBox
            // 
            this.heightBox.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightBox.Location = new System.Drawing.Point(161, 131);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(179, 38);
            this.heightBox.TabIndex = 8;
            this.heightBox.Visible = false;
            this.heightBox.TextChanged += new System.EventHandler(this.heightBox_TextChanged);
            // 
            // genderBox
            // 
            this.genderBox.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderBox.Location = new System.Drawing.Point(161, 191);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(179, 38);
            this.genderBox.TabIndex = 7;
            this.genderBox.Visible = false;
            this.genderBox.TextChanged += new System.EventHandler(this.genderBox_TextChanged);
            // 
            // clientHeight
            // 
            this.clientHeight.AutoSize = true;
            this.clientHeight.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientHeight.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clientHeight.Location = new System.Drawing.Point(-6, 131);
            this.clientHeight.Name = "clientHeight";
            this.clientHeight.Size = new System.Drawing.Size(181, 33);
            this.clientHeight.TabIndex = 2;
            this.clientHeight.Text = "Height (inches):";
            // 
            // clientWeight
            // 
            this.clientWeight.AutoSize = true;
            this.clientWeight.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientWeight.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clientWeight.Location = new System.Drawing.Point(3, 71);
            this.clientWeight.Name = "clientWeight";
            this.clientWeight.Size = new System.Drawing.Size(152, 33);
            this.clientWeight.TabIndex = 1;
            this.clientWeight.Text = "Weight (lbs):";
            // 
            // weightBox
            // 
            this.weightBox.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightBox.Location = new System.Drawing.Point(161, 71);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(179, 38);
            this.weightBox.TabIndex = 0;
            this.weightBox.Visible = false;
            this.weightBox.TextChanged += new System.EventHandler(this.weightBox_TextChanged);
            // 
            // clientGender
            // 
            this.clientGender.AutoSize = true;
            this.clientGender.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientGender.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clientGender.Location = new System.Drawing.Point(3, 191);
            this.clientGender.Name = "clientGender";
            this.clientGender.Size = new System.Drawing.Size(96, 33);
            this.clientGender.TabIndex = 3;
            this.clientGender.Text = "Gender:";
            this.clientGender.Click += new System.EventHandler(this.label4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(449, 71);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(472, 39);
            this.progressBar1.TabIndex = 11;
            // 
            // nextButton
            // 
            this.nextButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.nextButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.nextButton.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nextButton.Location = new System.Drawing.Point(927, 559);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(419, 39);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "I\'m Done Here...Let\'s Go!";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // save1
            // 
            this.save1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.save1.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save1.Location = new System.Drawing.Point(83, 514);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(203, 39);
            this.save1.TabIndex = 13;
            this.save1.Text = "Save Info";
            this.save1.UseVisualStyleBackColor = false;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // save2
            // 
            this.save2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.save2.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save2.Location = new System.Drawing.Point(1041, 514);
            this.save2.Name = "save2";
            this.save2.Size = new System.Drawing.Size(203, 39);
            this.save2.TabIndex = 14;
            this.save2.Text = "Save Attributes";
            this.save2.UseVisualStyleBackColor = false;
            this.save2.Click += new System.EventHandler(this.save2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Human_FitnessProject.Properties.Resources.color_logo___with_background;
            this.pictureBox2.Location = new System.Drawing.Point(449, 503);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(472, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // logo3
            // 
            this.logo3.Image = ((System.Drawing.Image)(resources.GetObject("logo3.Image")));
            this.logo3.Location = new System.Drawing.Point(1198, 10);
            this.logo3.Name = "logo3";
            this.logo3.Size = new System.Drawing.Size(147, 148);
            this.logo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo3.TabIndex = 3;
            this.logo3.TabStop = false;
            // 
            // logo2
            // 
            this.logo2.Image = global::Human_FitnessProject.Properties.Resources.Color_logo_with_background;
            this.logo2.Location = new System.Drawing.Point(10, 10);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(147, 148);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo2.TabIndex = 2;
            this.logo2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Human_FitnessProject.Properties.Resources.beach_workout;
            this.pictureBox1.Location = new System.Drawing.Point(447, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // intake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1359, 634);
            this.ControlBox = false;
            this.Controls.Add(this.save2);
            this.Controls.Add(this.save1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.attribPanel);
            this.Controls.Add(this.initinfoPanel);
            this.Controls.Add(this.boom);
            this.Controls.Add(this.initialinfo2);
            this.Controls.Add(this.physicalInfo);
            this.Controls.Add(this.initialInfo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.logo3);
            this.Controls.Add(this.logo2);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1385, 705);
            this.Name = "intake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WE ARE SO GLAD YOU MADE IT HERE!";
            this.Load += new System.EventHandler(this.intake_Load);
            this.initinfoPanel.ResumeLayout(false);
            this.initinfoPanel.PerformLayout();
            this.attribPanel.ResumeLayout(false);
            this.attribPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.PictureBox logo2;
        private System.Windows.Forms.PictureBox logo3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label initialInfo;
        private System.Windows.Forms.Label physicalInfo;
        private System.Windows.Forms.Label initialinfo2;
        private System.Windows.Forms.Label boom;
        private System.Windows.Forms.Panel initinfoPanel;
        private System.Windows.Forms.Panel attribPanel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label clientGender;
        private System.Windows.Forms.Label clientDOB;
        private System.Windows.Forms.Label clientAge;
        private System.Windows.Forms.Label clientName;
        private System.Windows.Forms.TextBox genderBox;
        private System.Windows.Forms.TextBox dobBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label clientHeight;
        private System.Windows.Forms.Label clientWeight;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.Button save2;
    }
}