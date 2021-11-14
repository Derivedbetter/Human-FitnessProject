
namespace Human_FitnessProject
{
    partial class parQ2form
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
            this.backtopage1 = new System.Windows.Forms.Button();
            this.submitandforward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backtopage1
            // 
            this.backtopage1.BackColor = System.Drawing.Color.Red;
            this.backtopage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtopage1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backtopage1.Location = new System.Drawing.Point(14, 771);
            this.backtopage1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.backtopage1.Name = "backtopage1";
            this.backtopage1.Size = new System.Drawing.Size(272, 41);
            this.backtopage1.TabIndex = 1;
            this.backtopage1.Text = "Change Scares Me!";
            this.backtopage1.UseVisualStyleBackColor = false;
            this.backtopage1.Click += new System.EventHandler(this.backtopage1_Click);
            // 
            // submitandforward
            // 
            this.submitandforward.BackColor = System.Drawing.SystemColors.HotTrack;
            this.submitandforward.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitandforward.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.submitandforward.Location = new System.Drawing.Point(285, 771);
            this.submitandforward.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.submitandforward.Name = "submitandforward";
            this.submitandforward.Size = new System.Drawing.Size(264, 41);
            this.submitandforward.TabIndex = 2;
            this.submitandforward.Text = "Let\'s Keep Moving!";
            this.submitandforward.UseVisualStyleBackColor = false;
            this.submitandforward.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // parQ2form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Human_FitnessProject.Properties.Resources.ParQpage2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(549, 814);
            this.ControlBox = false;
            this.Controls.Add(this.submitandforward);
            this.Controls.Add(this.backtopage1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1170, 1770);
            this.Name = "parQ2form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParQ and You Page 2";
            this.Load += new System.EventHandler(this.parQ2form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backtopage1;
        private System.Windows.Forms.Button submitandforward;
    }
}