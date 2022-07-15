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
    public partial class Battle : Form
    {
        private Enemy enemy;
        private Player player;
        private MainWindow mainWindow;
        private Maze maze;
        public Battle()
        {
            InitializeComponent();
        }

        public Battle(Enemy god, Player player, Maze maze)
        {
            InitializeComponent();
            this.enemy = god;
            this.player = player;
            this.maze = maze;
            //this.mainWindow = mainWindow;
            if(god.getName() == "Zeus")
            {
                //poner foto
                pictureBox2.Image = Properties.Resources._89_895836_zeus_zeus_png_transparent;
            }else if(god.getName() == "Atenea")
            {
                //pooner foto
                pictureBox2.Image = Properties.Resources._02e80d6aadf2cf4b080230817d10629f;
            }
            else if(god.getName()== "Hades")
            {
                //poner foto
                pictureBox2.Image = Properties.Resources.smite_renders_hades_primary_by_kaiology_d9cor08_smite_hades_11563538199t9f82mplmi;
            }

            updatePlayer();
            updateEnemy();


        }

        public void updatePlayer()
        {

            //Player items
            this.playerItems.Items.Clear();
            foreach (Item it in this.player.getBag())
            {
                if (it.getNumberOfUses() > 0)
                {
                    this.playerItems.Items.Add(it);
                }
            }

            //PLayer HP
            int maxHP = this.player.getMaxHP();
            int HP = this.player.getHP();
            this.hpLabel.Text = "HP: " + this.player.getHP() + "/" + this.player.getMaxHP();
            if (HP <= 0)
            {
                MessageBox.Show("You died!");
                Environment.Exit(0);

            }
        }

        public void updateEnemy()
        {
            int enemyMaxHP = this.enemy.getMaxHP();
            int enemyHP = this.enemy.getHP();
            this.enemyHPLabel.Text = "HP: " + this.enemy.getHP() + "/" + this.enemy.getMaxHP();
            this.enemyLabel.Text = this.enemy.getName();

            if (enemyHP <= 0)
            {
                MessageBox.Show("You killed "+enemy.getName() + "!!");
                if (maze.getLevel() == 3)
                {
                    MessageBox.Show("You escaped with the power of the gods!!");
                    Environment.Exit(0);
                }
                this.mainWindow = new MainWindow(maze, player);
                this.mainWindow.Visible = true;
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //user attack
            this.enemy.getDamage(5);

            updateEnemy();

            //zeus attack
            godAttack();

            updatePlayer();
        }
        //use item
        private void button1_Click_1(object sender, EventArgs e)
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
                    it.Use(null, this.enemy);
                    MessageBox.Show("Number of uses of the item left: " + it.getNumberOfUses());
                    updateEnemy();
                }
                else
                {
                    it.Use(this.player, null);
                    MessageBox.Show("Number of uses of the item left: " + it.getNumberOfUses());
                    updatePlayer();
                }
                godAttack();
                updatePlayer();


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void godAttack()
        {
            if(enemy.getName() == "Zeus")
            {
                if(enemy.getHP()>= 15)
                {
                    System.Threading.Thread.Sleep(500);
                    player.getDamage(3);
                    MessageBox.Show("Zeus is attacking! -3HP");
                    updatePlayer();

                }
                else if (enemy.getHP() < 15)
                {
                    if(enemy.getHP() <= 0)
                    {
                        updatePlayer();
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(500);
                        MessageBox.Show("Zeus is furious! You receive 5 points of damage");
                        player.getDamage(5);
                        updatePlayer();
                    }

                }


            }else if(enemy.getName() == "Atenea")
            {
                if (enemy.getHP() >= 30)
                {
                    System.Threading.Thread.Sleep(500);
                    player.getDamage(5);
                    MessageBox.Show("Atenea is hitting with the shield! -5HP");
                    updatePlayer();

                }else if(enemy.getHP() < 30 && enemy.getHP() >= 15)
                {
                    System.Threading.Thread.Sleep(500);
                    player.getDamage(7);
                    MessageBox.Show("Atenea is hitting with the spear! -7HP");
                    updatePlayer();

                }
                else if(enemy.getHP() < 15)
                {
                    if (enemy.getHP() <= 0)
                    {
                        updatePlayer();
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(500);
                        player.getDamage(9);
                        MessageBox.Show("Atenea is faster! -9HP");
                        updatePlayer();
                    }
                }

            }
            else if(enemy.getName() == "Hades")
            {
                if (enemy.getHP() >= 40)
                {
                    System.Threading.Thread.Sleep(500);
                    player.getDamage(5);
                    MessageBox.Show("Hades is using dark spells on you! -5HP");
                    updatePlayer();

                }
                else if (enemy.getHP() < 40 && enemy.getHP() >= 15)
                {
                    System.Threading.Thread.Sleep(500);
                    player.getDamage(8);
                    MessageBox.Show("Hades is hitting with the reaper! -8HP");
                    updatePlayer();

                }
                else if (enemy.getHP() < 15)
                {
                    if (enemy.getHP() <= 0)
                    {
                        updatePlayer();
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(500);
                        player.getDamage(10);
                        MessageBox.Show("Hades is almost defeated, but he is using his best spell! -10HP");
                        updatePlayer();
                    }
                }
            }
        }

        private void infoDisplay_Click(object sender, EventArgs e)
        {
            Item it = (Item)this.playerItems.SelectedItem;
            if (it == null)
            {
                MessageBox.Show("Select an item!");
            }
            else
            {
                MessageBox.Show(it.getDescription());
            }
        }
    }
}
