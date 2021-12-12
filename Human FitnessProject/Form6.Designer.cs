
namespace Human_FitnessProject
{
    partial class waiverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(waiverForm));
            this.submit = new System.Windows.Forms.Button();
            this.nameBox1 = new System.Windows.Forms.TextBox();
            this.emailBox2 = new System.Windows.Forms.TextBox();
            this.addressBox1 = new System.Windows.Forms.TextBox();
            this.phoneBox1 = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit.Location = new System.Drawing.Point(345, 757);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(202, 45);
            this.submit.TabIndex = 0;
            this.submit.Text = "Continue!";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Visible = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // nameBox1
            // 
            this.nameBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox1.Location = new System.Drawing.Point(124, 113);
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(314, 26);
            this.nameBox1.TabIndex = 1;
            // 
            // emailBox2
            // 
            this.emailBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailBox2.Location = new System.Drawing.Point(65, 157);
            this.emailBox2.Name = "emailBox2";
            this.emailBox2.Size = new System.Drawing.Size(429, 26);
            this.emailBox2.TabIndex = 2;
            // 
            // addressBox1
            // 
            this.addressBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBox1.Location = new System.Drawing.Point(65, 237);
            this.addressBox1.Multiline = true;
            this.addressBox1.Name = "addressBox1";
            this.addressBox1.Size = new System.Drawing.Size(429, 46);
            this.addressBox1.TabIndex = 3;
            this.addressBox1.TextChanged += new System.EventHandler(this.addressBox1_TextChanged);
            // 
            // phoneBox1
            // 
            this.phoneBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneBox1.Location = new System.Drawing.Point(65, 200);
            this.phoneBox1.Name = "phoneBox1";
            this.phoneBox1.Size = new System.Drawing.Size(429, 26);
            this.phoneBox1.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(137, 757);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(202, 45);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save and Print";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.BackColor = System.Drawing.Color.Red;
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(12, 757);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(119, 45);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dateBox
            // 
            this.dateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateBox.Location = new System.Drawing.Point(280, 711);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(140, 26);
            this.dateBox.TabIndex = 7;
            // 
            // waiverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Human_FitnessProject.Properties.Resources.Waiverform;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(559, 814);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.phoneBox1);
            this.Controls.Add(this.addressBox1);
            this.Controls.Add(this.emailBox2);
            this.Controls.Add(this.nameBox1);
            this.Controls.Add(this.submit);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1170, 1770);
            this.Name = "waiverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liability and Coaching Waiver";
            this.Load += new System.EventHandler(this.waiverForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox nameBox1;
        private System.Windows.Forms.TextBox emailBox2;
        private System.Windows.Forms.TextBox addressBox1;
        private System.Windows.Forms.TextBox phoneBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox dateBox;
    }
}