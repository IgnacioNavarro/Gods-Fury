using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_MazeGame
{
    public class Enemy
    {


        private string Name;
        private int maxHP;
        private int HP;
        private Room bossRoom;


        public string getName()
        {
            return this.Name;
        }

        public int getMaxHP()
        {
            return this.maxHP;
        }

        public int getHP()
        {
            return this.HP;
        }

        public Enemy(string name, int maxHP, Room bossRoom)
        {
            this.Name=name;
            this.maxHP=maxHP;
            this.HP = maxHP;
            this.bossRoom = bossRoom;
        }


        public void getHeal(int heal)
        {
            if ((this.HP + heal) >= this.maxHP)
            {
                this.HP = this.maxHP;
            }
            else
            {
                this.HP += heal;
            }
        }

        public void getDamage(int damage)
        {
            if (damage >= this.HP)
            {
                this.HP = 0;
            }
            else
            {
                this.HP -= damage;
            }
        }
    }
}
