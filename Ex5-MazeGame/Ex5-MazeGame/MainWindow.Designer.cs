using System;

namespace Ex5_MazeGame
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.northButton = new System.Windows.Forms.Button();
            this.westButton = new System.Windows.Forms.Button();
            this.eastButton = new System.Windows.Forms.Button();
            this.southButton = new System.Windows.Forms.Button();
            this.labelNavigation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.currentRoom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.playerItems = new System.Windows.Forms.ListBox();
            this.roomItems = new System.Windows.Forms.ListBox();
            this.dropButton = new System.Windows.Forms.Button();
            this.pickUpButton = new System.Windows.Forms.Button();
            this.useButton = new System.Windows.Forms.Button();
            this.hpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // northButton
            // 
            this.northButton.Location = new System.Drawing.Point(604, 170);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(75, 75);
            this.northButton.TabIndex = 0;
            this.northButton.Text = "N";
            this.northButton.UseVisualStyleBackColor = true;
            this.northButton.Click += new System.EventHandler(this.northButton_Click);
            // 
            // westButton
            // 
            this.westButton.Location = new System.Drawing.Point(533, 251);
            this.westButton.Name = "westButton";
            this.westButton.Size = new System.Drawing.Size(75, 75);
            this.westButton.TabIndex = 1;
            this.westButton.Text = "W";
            this.westButton.UseVisualStyleBackColor = true;
            this.westButton.Click += new System.EventHandler(this.westButton_Click);
            // 
            // eastButton
            // 
            this.eastButton.Location = new System.Drawing.Point(677, 251);
            this.eastButton.Name = "eastButton";
            this.eastButton.Size = new System.Drawing.Size(75, 75);
            this.eastButton.TabIndex = 2;
            this.eastButton.Text = "E";
            this.eastButton.UseVisualStyleBackColor = true;
            this.eastButton.Click += new System.EventHandler(this.eastButton_Click);
            // 
            // southButton
            // 
            this.southButton.Location = new System.Drawing.Point(604, 332);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(75, 75);
            this.southButton.TabIndex = 3;
            this.southButton.Text = "S";
            this.southButton.UseVisualStyleBackColor = true;
            this.southButton.Click += new System.EventHandler(this.southButton_Click);
            // 
            // labelNavigation
            // 
            this.labelNavigation.AutoSize = true;
            this.labelNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNavigation.Location = new System.Drawing.Point(593, 122);
            this.labelNavigation.Name = "labelNavigation";
            this.labelNavigation.Size = new System.Drawing.Size(104, 25);
            this.labelNavigation.TabIndex = 4;
            this.labelNavigation.Text = "Navigation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your mission:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(544, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "You have stealed the power of the gods of Olympus, and they have sent you into th" +
    "is maze. ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Try to escape the maze before the gods find you and kill you!.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "You are currently on:";
            // 
            // currentRoom
            // 
            this.currentRoom.AutoSize = true;
            this.currentRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRoom.Location = new System.Drawing.Point(16, 153);
            this.currentRoom.Name = "currentRoom";
            this.currentRoom.Size = new System.Drawing.Size(181, 58);
            this.currentRoom.TabIndex = 9;
            this.currentRoom.Text = "ROOM";
            this.currentRoom.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "You have:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "The rooms contains: ";
            // 
            // playerItems
            // 
            this.playerItems.FormattingEnabled = true;
            this.playerItems.ItemHeight = 16;
            this.playerItems.Location = new System.Drawing.Point(26, 268);
            this.playerItems.Name = "playerItems";
            this.playerItems.Size = new System.Drawing.Size(134, 148);
            this.playerItems.TabIndex = 12;
            this.playerItems.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // roomItems
            // 
            this.roomItems.FormattingEnabled = true;
            this.roomItems.ItemHeight = 16;
            this.roomItems.Location = new System.Drawing.Point(264, 268);
            this.roomItems.Name = "roomItems";
            this.roomItems.Size = new System.Drawing.Size(134, 148);
            this.roomItems.TabIndex = 13;
            this.roomItems.SelectedIndexChanged += new System.EventHandler(this.roomItems_SelectedIndexChanged);
            // 
            // dropButton
            // 
            this.dropButton.Location = new System.Drawing.Point(172, 303);
            this.dropButton.Name = "dropButton";
            this.dropButton.Size = new System.Drawing.Size(75, 23);
            this.dropButton.TabIndex = 14;
            this.dropButton.Text = "Drop";
            this.dropButton.UseVisualStyleBackColor = true;
            this.dropButton.Click += new System.EventHandler(this.dropButton_Click);
            // 
            // pickUpButton
            // 
            this.pickUpButton.Location = new System.Drawing.Point(172, 358);
            this.pickUpButton.Name = "pickUpButton";
            this.pickUpButton.Size = new System.Drawing.Size(75, 23);
            this.pickUpButton.TabIndex = 15;
            this.pickUpButton.Text = "Pick Up";
            this.pickUpButton.UseVisualStyleBackColor = true;
            this.pickUpButton.Click += new System.EventHandler(this.pickUpButton_Click);
            // 
            // useButton
            // 
            this.useButton.Location = new System.Drawing.Point(53, 433);
            this.useButton.Name = "useButton";
            this.useButton.Size = new System.Drawing.Size(75, 23);
            this.useButton.TabIndex = 16;
            this.useButton.Text = "Use";
            this.useButton.UseVisualStyleBackColor = true;
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel.Location = new System.Drawing.Point(545, 436);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(62, 29);
            this.hpLabel.TabIndex = 17;
            this.hpLabel.Text = "HP: ";
            this.hpLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.useButton);
            this.Controls.Add(this.pickUpButton);
            this.Controls.Add(this.dropButton);
            this.Controls.Add(this.roomItems);
            this.Controls.Add(this.playerItems);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.currentRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNavigation);
            this.Controls.Add(this.southButton);
            this.Controls.Add(this.eastButton);
            this.Controls.Add(this.westButton);
            this.Controls.Add(this.northButton);
            this.MaximumSize = new System.Drawing.Size(818, 530);
            this.MinimumSize = new System.Drawing.Size(818, 530);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.Button westButton;
        private System.Windows.Forms.Button eastButton;
        private System.Windows.Forms.Button southButton;
        private System.Windows.Forms.Label labelNavigation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label currentRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox playerItems;
        private System.Windows.Forms.ListBox roomItems;
        private System.Windows.Forms.Button dropButton;
        private System.Windows.Forms.Button pickUpButton;
        private System.Windows.Forms.Button useButton;
        private System.Windows.Forms.Label hpLabel;
    }
}

