using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_MazeGame
{
    class Potion : Item
    {
        public Potion(string name, bool pickable, int numerOfUses) : base(name, pickable, numerOfUses)
        {
            this.name = name;
            this.pickable = pickable;
            this.visible = true;
            this.numberOfUses = numerOfUses;

        }
        public  void Use(Player user)
        {
            user.getHeal(10);

            if (numberOfUses > 0)
            {
                numberOfUses--;
            }
        }
    }
}
