
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.saveInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backtopage1
            // 
            this.backtopage1.BackColor = System.Drawing.Color.Red;
            this.backtopage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtopage1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backtopage1.Location = new System.Drawing.Point(14, 771);
            this.backtopage1.Margin = new System.Windows.Forms.Padding(5);
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
            this.submitandforward.Margin = new System.Windows.Forms.Padding(5);
            this.submitandforward.Name = "submitandforward";
            this.submitandforward.Size = new System.Drawing.Size(264, 41);
            this.submitandforward.TabIndex = 2;
            this.submitandforward.Text = "Print File";
            this.submitandforward.UseVisualStyleBackColor = false;
            this.submitandforward.Visible = false;
            this.submitandforward.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(65, 580);
            this.nameBox.MaximumSize = new System.Drawing.Size(300, 20);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(300, 38);
            this.nameBox.TabIndex = 3;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Monotype Corsiva", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(65, 619);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(331, 38);
            this.emailBox.TabIndex = 4;
            // 
            // saveInfo
            // 
            this.saveInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.saveInfo.Location = new System.Drawing.Point(341, 724);
            this.saveInfo.Name = "saveInfo";
            this.saveInfo.Size = new System.Drawing.Size(140, 42);
            this.saveInfo.TabIndex = 5;
            this.saveInfo.Text = "Save Info!";
            this.saveInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveInfo.Click += new System.EventHandler(this.saveInfo_Click);
            // 
            // parQ2form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Human_FitnessProject.Properties.Resources.ParQpage2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(549, 814);
            this.ControlBox = false;
            this.Controls.Add(this.saveInfo);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.nameBox);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backtopage1;
        private System.Windows.Forms.Button submitandforward;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label saveInfo;
        public System.Windows.Forms.TextBox nameBox;
    }
}