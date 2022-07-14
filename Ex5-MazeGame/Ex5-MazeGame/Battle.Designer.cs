namespace Ex5_MazeGame
{
    partial class Battle
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.attackButton = new System.Windows.Forms.Button();
            this.useButton = new System.Windows.Forms.Button();
            this.playerItems = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.enemyLabel = new System.Windows.Forms.Label();
            this.enemyHPLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoDisplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(211, 26);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 13);
            this.titleLabel.TabIndex = 0;
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(21, 315);
            this.attackButton.Margin = new System.Windows.Forms.Padding(2);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(130, 53);
            this.attackButton.TabIndex = 1;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // useButton
            // 
            this.useButton.Location = new System.Drawing.Point(162, 315);
            this.useButton.Margin = new System.Windows.Forms.Padding(2);
            this.useButton.Name = "useButton";
            this.useButton.Size = new System.Drawing.Size(130, 53);
            this.useButton.TabIndex = 2;
            this.useButton.Text = "Use Object";
            this.useButton.UseVisualStyleBackColor = true;
            this.useButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // playerItems
            // 
            this.playerItems.FormattingEnabled = true;
            this.playerItems.Location = new System.Drawing.Point(314, 315);
            this.playerItems.Margin = new System.Windows.Forms.Padding(2);
            this.playerItems.Name = "playerItems";
            this.playerItems.Size = new System.Drawing.Size(141, 134);
            this.playerItems.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Player";
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel.Location = new System.Drawing.Point(260, 269);
            this.hpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(135, 31);
            this.hpLabel.TabIndex = 16;
            this.hpLabel.Text = "HP: 30/30";
            // 
            // enemyLabel
            // 
            this.enemyLabel.AutoSize = true;
            this.enemyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyLabel.Location = new System.Drawing.Point(309, 11);
            this.enemyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enemyLabel.Name = "enemyLabel";
            this.enemyLabel.Size = new System.Drawing.Size(75, 31);
            this.enemyLabel.TabIndex = 18;
            this.enemyLabel.Text = "Zeus";
            this.enemyLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // enemyHPLabel
            // 
            this.enemyHPLabel.AutoSize = true;
            this.enemyHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyHPLabel.Location = new System.Drawing.Point(309, 43);
            this.enemyHPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enemyHPLabel.Name = "enemyHPLabel";
            this.enemyHPLabel.Size = new System.Drawing.Size(135, 31);
            this.enemyHPLabel.TabIndex = 19;
            this.enemyHPLabel.Text = "HP: 30/30";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ex5_MazeGame.Properties.Resources.smite_renders_hades_primary_by_kaiology_d9cor08_smite_hades_11563538199t9f82mplmi;
            this.pictureBox2.Location = new System.Drawing.Point(458, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 291);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ex5_MazeGame.Properties.Resources.kindpng_3476120;
            this.pictureBox1.Location = new System.Drawing.Point(21, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // infoDisplay
            // 
            this.infoDisplay.Location = new System.Drawing.Point(162, 396);
            this.infoDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.infoDisplay.Name = "infoDisplay";
            this.infoDisplay.Size = new System.Drawing.Size(130, 53);
            this.infoDisplay.TabIndex = 20;
            this.infoDisplay.Text = "Object Info";
            this.infoDisplay.UseVisualStyleBackColor = true;
            this.infoDisplay.Click += new System.EventHandler(this.infoDisplay_Click);
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 465);
            this.Controls.Add(this.infoDisplay);
            this.Controls.Add(this.enemyHPLabel);
            this.Controls.Add(this.enemyLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.playerItems);
            this.Controls.Add(this.useButton);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(705, 504);
            this.MinimumSize = new System.Drawing.Size(705, 504);
            this.Name = "Battle";
            this.Text = "Battle with the gods!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button useButton;
        private System.Windows.Forms.ListBox playerItems;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label enemyLabel;
        private System.Windows.Forms.Label enemyHPLabel;
        private System.Windows.Forms.Button infoDisplay;
    }
}