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
        private Graphics map;
        private SolidBrush pen;
        bool mazeinit = false;

        public MainWindow()
        {
            InitializeComponent();
            map=pictureBox1.CreateGraphics();
            this.maze = new Maze();
            pen=new SolidBrush(Color.Black);
            this.player = new Player(maze.getStartRoom());
            updatePlayer();
            updateRoom();
        }

        private void updatePlayer()
        {
            //Player items
            this.playerItems.Items.Clear();
            foreach (Item it in this.player.getBag())
            {
                this.playerItems.Items.Add(it);
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


        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////
        //
        //
        //

        private void reqMovePlayer(char direction)
        {
            if (!mazeinit)
            {
                maze.getStartRoom().draw(map);
                mazeinit = true;
            }
            String move = player.move(direction);

            //MessageBox.Show(move);


            if (move == "open")
            {
                draw(direction);
                player.getCurrentRoom().drawPast(map);
                /**/
                player.setCurrentRoom(player.getCurrentRoom().getConnectedRoom(direction));
                this.updateRoom();
                if (player.getCurrentRoom() == maze.getWinningRoom())
                {
                    MessageBox.Show("You escaped with the power of the gods!");
                    Close();
                }
                else if (player.getCurrentRoom() == maze.getLosingRoom())
                {
                    MessageBox.Show("The torture room is full of unbelievable hideous images, decomposing bodies and bloodthirsty torture weapons. You can't help throwing up. You loose hp");

                }
                else
                {

                }
            }
            else if (move == "wall")
            {
                MessageBox.Show("That's a wall, stupid!");
            }
            else if (move == "challenge")
            {
                DialogResult d = MessageBox.Show("You will have to face Zeus to scape. Are you ready?", "", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    player.getCurrentRoom().drawPast(map);
                    draw(direction);
                    player.setCurrentRoom(player.getCurrentRoom().getConnectedRoom(direction));
                    this.updateRoom();
                }
            }
            else if (move == "closed")
            {
                MessageBox.Show("The door is closed");
            }


            player.getCurrentRoom().draw(map);

        }

        public void draw(char direction)
        {
            switch (direction)
            {
                case 'N':
                    player.getCurrentRoom().getConnectedRoom(direction).setPos(player.getCurrentRoom().getPos()[0], player.getCurrentRoom().getPos()[1] - 30);
                    break;
                case 'S':
                    player.getCurrentRoom().getConnectedRoom(direction).setPos(player.getCurrentRoom().getPos()[0], player.getCurrentRoom().getPos()[1] + 30);
                    break;
                case 'E':
                    player.getCurrentRoom().getConnectedRoom(direction).setPos(player.getCurrentRoom().getPos()[0] + 40, player.getCurrentRoom().getPos()[1]);
                    break;
                case 'W':
                    player.getCurrentRoom().getConnectedRoom(direction).setPos(player.getCurrentRoom().getPos()[0] - 40, player.getCurrentRoom().getPos()[1]);
                    break;
            }
        }

        //
        //
        //
        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////
        //
        //
        //
        private void northButton_Click(object sender, EventArgs e)
        {
            reqMovePlayer('N');
        }

        private void eastButton_Click(object sender, EventArgs e)
        {
            reqMovePlayer('E');
        }

        private void westButton_Click(object sender, EventArgs e)
        {
            reqMovePlayer('W');
        }

        private void southButton_Click(object sender, EventArgs e)
        {
            reqMovePlayer('S');
        }
        //
        //
        //
        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////

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
    }
}
