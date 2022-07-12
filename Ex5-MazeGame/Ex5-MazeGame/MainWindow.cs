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
        private Enemy enemy;
        bool mazeinit = false;

        public MainWindow()
        {
            InitializeComponent();
            map =pictureBox1.CreateGraphics();
            this.maze = new Maze(1);
            this.pen=new SolidBrush(Color.Black);
            this.player = new Player(maze.getStartRoom());
            this.enemy = new Enemy("Zeus", 30, maze.getChallengeRoom());
            updatePlayer();
            updateRoom();
            MessageBox.Show("You are a human that climbed the whole Olympus and stole the power of the eleventh god.");
            MessageBox.Show("You made it and now you have the Anemo power (Wind), but...");
            MessageBox.Show("the rest of the gods now want to kill you and recover the power.");
            MessageBox.Show("Your mission is to successfully escape without dying, to do that you will have to fight them while going down the Olympus.");
            MessageBox.Show("Good luck, Player...");
        }

        public MainWindow(Maze maze, Player player)
        {
            MessageBox.Show("You escaped... for now");
            InitializeComponent();
            map = pictureBox1.CreateGraphics();
            this.maze = maze;
            this.player = player;
            maze.nextLevel();
            player.getMaze().nextLevel();
            player.setCurrentRoom(maze.getStartRoom());
            this.pen = new SolidBrush(Color.Black);
            if(maze.getLevel()== 2)
            {
                this.enemy = new Enemy("Atenea", 45, maze.getChallengeRoom());
            }
            if(maze.getLevel()== 3)
            {
                this.enemy = new Enemy("Poseidon", 60, maze.getChallengeRoom());
            }

            updatePlayer();
            updateRoom();

        }

        private void updatePlayer()
        {
            //Player items
            this.playerItems.Items.Clear();
            foreach (Item it in this.player.getBag())
            {
                if(it.getNumberOfUses() > 0)
                {
                    this.playerItems.Items.Add(it);
                }
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
                    if (maze.getLevel() < 2)
                    {

                        //maze.nextLevel();
                        //player.getMaze().nextLevel();
                        //player.setCurrentRoom(maze.getStartRoom());
                        // TODO : close window and open again

                        //this.Visible = false;

                        //MessageBox.Show("You escaped... for now");

                        //this.Visible = true;
                        //this.updateRoom();

                    } else
                    {
                        MessageBox.Show("You win!");
                        this.Close();
                    }




                }
                else if (player.getCurrentRoom() == maze.getLosingRoom())
                {
                    MessageBox.Show("The torture room is full of unbelievable hideous images, decomposing bodies and bloodthirsty torture weapons. You can't help throwing up. You loose 5 hp");
                    this.player.getDamage(5);
                    updatePlayer();
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
                DialogResult d = MessageBox.Show("You will have to face a god to scape. Are you ready?", "", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    player.getCurrentRoom().drawPast(map);
                    draw(direction);
                    player.setCurrentRoom(player.getCurrentRoom().getConnectedRoom(direction));
                    this.updateRoom();
                    Battle battle = new Battle(enemy, player, maze);
                    this.Visible = false;
                    battle.Show();


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
                    if(player.getBag().Count() >= 11)
                    {
                        MessageBox.Show("Limit reached.");
                    }
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
                    //player.addToBag(it);
                    this.player.getCurrentRoom().addContent(it);
                    updateRoom();
                }
                
            }
            

            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void useButton_Click(object sender, EventArgs e)
        {
            Item it = (Item)this.playerItems.SelectedItem;
            if (it == null)
            {
                MessageBox.Show("Select an item!");
            }
            else
            {
                if (it.getOnEnemy())
                {
                    MessageBox.Show("Remember prof. Rowan's words: there's a time and place for everything! But not now.");
                }
                else
                {
                    it.Use(player, null);
                    MessageBox.Show("Number of uses of the item left: " + it.getNumberOfUses());
                }
                updateRoom();
                updatePlayer();

                

            }
        }
    }
}
