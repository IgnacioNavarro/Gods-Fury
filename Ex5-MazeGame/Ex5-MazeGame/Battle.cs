﻿using System;
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
        public Battle()
        {
            InitializeComponent();
        }

        public Battle(Enemy god, Player player, MainWindow mainWindow)
        {
            InitializeComponent();
            this.enemy = god;
            this.player = player;
            this.mainWindow = mainWindow;

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
                this.mainWindow.Close();
                Close();

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
                MessageBox.Show("You killed Zeus!!");
                this.mainWindow.Visible = true;
                Close();
                if (enemy.getHP() <= 0)
                {
                    //player.setCurrentRoom(player.getCurrentRoom().getConnectedRoom('S'));

                }
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
                updateEnemy();


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

            }
            else if(enemy.getName() == "Poseidon")
            {

            }
        }
    }
}
