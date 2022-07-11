using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5_MazeGame
{
    public partial class MainWindow : Form
    {

        private Maze maze;
        private Player player;
        private Enemy zeus;

        public MainWindow()
        {
            InitializeComponent();
            this.maze = new Maze();
            this.player = new Player(maze.getStartRoom());
            this.zeus = new Enemy("Zeus", 30, maze.getChallengeRoom());
            updatePlayer();
            updateRoom();
        }


        private void updateEnemy()
        {

        }

        private void updatePlayer()
        {
            //Player items
            this.playerItems.Items.Clear();
            foreach (Item it in this.player.getBag())
            {
                this.playerItems.Items.Add(it);
            }

            int maxHP = this.player.getMaxHP();
            int HP = this.player.getHP();
            this.hpLabel.Text ="HP: "+  HP + "/" + maxHP;

            if(HP <= 0)
            {
                MessageBox.Show("You died!");
                Close();
            }

        }

        private void updateRoom()
        {
            this.currentRoom.Text = this.player.getCurrentRoom().getName();
            
            //Room items
            this.roomItems.Items.Clear();
            foreach(Item it in this.player.getCurrentRoom().getContent())
            {
                roomItems.Items.Add(it);
            }


        }

        private void movePlayer(char direction)
        {
            String move = player.move(direction);
            if (player.getCurrentRoom().getConnectedRoom('S') == maze.getChallengeRoom() && direction == 'S')
                {
                    DialogResult d = MessageBox.Show("You will have to face Zeus to scape. Are you ready?", "", MessageBoxButtons.YesNo);
                    if (d == DialogResult.No)
                    {
                        move = "";
                    }
                }

            if (move=="open")
            {
                this.updateRoom();
                if (player.getCurrentRoom() == maze.getWinningRoom())
                {
                    MessageBox.Show("You escaped with the power of the gods!");
                    Close();
                }
                else if (player.getCurrentRoom() == maze.getLosingRoom())
                {
                    MessageBox.Show("You died :(");
                    Close();

                }
                else 
                {
                    
                }
            }
            else if(move == "wall")
            {
                MessageBox.Show("That's a wall, stupid!");
            }
            else
            {
                player.move('N');
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void northButton_Click(object sender, EventArgs e)
        {
            movePlayer('N');
        }

        private void eastButton_Click(object sender, EventArgs e)
        {
            movePlayer('E');
        }

        private void westButton_Click(object sender, EventArgs e)
        {
            movePlayer('W');
        }

        private void southButton_Click(object sender, EventArgs e)
        {
            movePlayer('S');
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pickUpButton_Click(object sender, EventArgs e)
        {
            Item it = (Item)this.roomItems.SelectedItem;
            if (it == null)
            {
                MessageBox.Show("Select an item!");
            }
            else
            {
                if (!it.isPickable()) MessageBox.Show("Too heavy!");
                else
                {
                    //remove from room content and the listbox
                    this.player.getCurrentRoom().deleteContent(it);
                    updateRoom();
                    //add to player bag and listbox
                    this.player.addToBag(it);
                    updatePlayer();
                }
                
            }
            
        }

        private void roomItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dropButton_Click(object sender, EventArgs e)
        {
            Item it = (Item)this.playerItems.SelectedItem;
            if (it == null)
            {
                MessageBox.Show("Select an item!");
            }
            else
            {
                if (!it.isPickable())
                {
                    MessageBox.Show("Too heavy!");
                }
                else
                {
                    //remove from room content and the listbox
                    this.player.deleteFromBag(it);
                    updatePlayer();
                    //add to room items and listbox
                    player.addToBag(it);
                    this.player.getCurrentRoom().addContent(it);
                    updateRoom();
                }
                
            }
            

            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
