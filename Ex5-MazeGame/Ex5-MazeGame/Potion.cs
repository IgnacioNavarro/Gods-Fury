﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_MazeGame
{
    class Potion : Item
    {
        private int healPoints;
        public Potion(string name, bool pickable, int numerOfUses, int healpoints, bool onEnemy) : base(name, pickable, numerOfUses, onEnemy)
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
            user.getHeal(healPoints);

            if (numberOfUses > 0)
            {
                numberOfUses--;
            }
        }
    }
}
