﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_MazeGame
{
    class MaxPotion : Item
    {
        private int healPoints;
        public MaxPotion(string name, bool pickable, int numerOfUses, int healpoints, bool onEnemy) : base(name, pickable, numerOfUses, onEnemy)
        {
            this.name = name;
            this.pickable = pickable;
            this.visible = true;
            this.numberOfUses = numerOfUses;
            this.healPoints = healpoints;
            this.onEnemy = onEnemy;

        }
        public override void Use(Player user, Enemy enemy)
        {
            user.newMaxHP(healPoints);
            user.getHeal(999);

            if (numberOfUses > 0)
            {
                numberOfUses--;
            }
        }
    }
}
