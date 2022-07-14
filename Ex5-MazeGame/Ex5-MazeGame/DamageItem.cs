using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_MazeGame
{
    class DamageItem : Item
    {
        private int damagePoints;
        public DamageItem(string name, bool pickable, int numerOfUses, int damagePoints, bool onEnemy) 
            : base(name, pickable, numerOfUses, onEnemy)
        {
            this.name = name;
            this.pickable = pickable;
            this.visible = true;
            this.numberOfUses = numerOfUses;
            this.damagePoints = damagePoints;
            this.onEnemy = true;
            this.description = "This item deals " + damagePoints + " damage and can be used up to " + numerOfUses + " times.";

        }
        public override void Use(Player user, Enemy enemy)
        {
            enemy.getDamage(damagePoints);

            if (numberOfUses > 0)
            {
                numberOfUses--;
            }
        }
        public override string getDescription()
        {
            return this.description;
        }
    }
}
