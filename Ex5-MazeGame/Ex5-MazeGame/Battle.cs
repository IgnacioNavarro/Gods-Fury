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

            if(god.getName() == "Zeus")
            {
                this.titleLabel.Text = "Battle vs Zeus";
            }
        }

        public void updatePlayer()
        {
            int maxHP = this.player.getMaxHP();
            int HP = this.player.getHP();
            //this.hpLabel.Text = "HP: " + HP + "/" + maxHP;
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

            if(enemyHP <= 0)
            {
                MessageBox.Show("You killed Zeus!!");
                this.mainWindow.Visible = true;
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.enemy.getDamage(50);
            updateEnemy();
            updatePlayer();
        }
    }
}
