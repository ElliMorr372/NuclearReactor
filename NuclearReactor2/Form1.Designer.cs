namespace NuclearReactor2
{
    partial class background1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(background1));
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.reactor1Label = new System.Windows.Forms.Label();
            this.reactor2Label = new System.Windows.Forms.Label();
            this.reactor1StateLabel = new System.Windows.Forms.Label();
            this.reactor2StateLabel = new System.Windows.Forms.Label();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel1
            // 
            this.titleLabel1.Font = new System.Drawing.Font("Rockwell", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.Location = new System.Drawing.Point(339, 9);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(387, 41);
            this.titleLabel1.TabIndex = 0;
            this.titleLabel1.Text = "Nuclear Reactor Control";
            this.titleLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reactor1Label
            // 
            this.reactor1Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reactor1Label.Location = new System.Drawing.Point(144, 115);
            this.reactor1Label.Name = "reactor1Label";
            this.reactor1Label.Size = new System.Drawing.Size(156, 35);
            this.reactor1Label.TabIndex = 1;
            this.reactor1Label.Text = "Reactor 1";
            this.reactor1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reactor2Label
            // 
            this.reactor2Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor2Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reactor2Label.Location = new System.Drawing.Point(755, 115);
            this.reactor2Label.Name = "reactor2Label";
            this.reactor2Label.Size = new System.Drawing.Size(156, 35);
            this.reactor2Label.TabIndex = 2;
            this.reactor2Label.Text = "Reactor 2";
            this.reactor2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reactor1StateLabel
            // 
            this.reactor1StateLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.reactor1StateLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reactor1StateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reactor1StateLabel.Location = new System.Drawing.Point(140, 178);
            this.reactor1StateLabel.Name = "reactor1StateLabel";
            this.reactor1StateLabel.Size = new System.Drawing.Size(160, 160);
            this.reactor1StateLabel.TabIndex = 3;
            this.reactor1StateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reactor2StateLabel
            // 
            this.reactor2StateLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.reactor2StateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reactor2StateLabel.Location = new System.Drawing.Point(751, 178);
            this.reactor2StateLabel.Name = "reactor2StateLabel";
            this.reactor2StateLabel.Size = new System.Drawing.Size(160, 160);
            this.reactor2StateLabel.TabIndex = 4;
            // 
            // outputLabel1
            // 
            this.outputLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputLabel1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputLabel1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.outputLabel1.Location = new System.Drawing.Point(138, 493);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(773, 45);
            this.outputLabel1.TabIndex = 5;
            this.outputLabel1.Text = "Reactors Stable";
            this.outputLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(394, 357);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(255, 58);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start Reactors";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // background1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1071, 571);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.outputLabel1);
            this.Controls.Add(this.reactor2StateLabel);
            this.Controls.Add(this.reactor1StateLabel);
            this.Controls.Add(this.reactor2Label);
            this.Controls.Add(this.reactor1Label);
            this.Controls.Add(this.titleLabel1);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "background1";
            this.Text = "Nuclear Power Plant";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Label reactor1Label;
        private System.Windows.Forms.Label reactor2Label;
        private System.Windows.Forms.Label reactor1StateLabel;
        private System.Windows.Forms.Label reactor2StateLabel;
        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.Button startButton;
    }
}

