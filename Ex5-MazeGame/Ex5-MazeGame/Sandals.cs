using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_MazeGame
{
    class Sandals : Item
    {
        public Sandals(string name, bool pickable, int numerOfUses, bool onEnemy) : base(name, pickable, numerOfUses, onEnemy)
        {
            this.name = name;
            this.pickable = pickable;
            this.visible = true;
            this.numberOfUses = numerOfUses;
            this.onEnemy = false;
            this.description = "This flying sandals were one of the God Herme's most precious possessions. Maybe you can find any utility for them";

        }

        public override void Use(Player user, Enemy enemy)
        {
            Console.WriteLine("using sandals");
            if (user.getCurrentRoom().getName() == "Forgotten's Abyss")
            {
                System.Windows.Forms.DialogResult d = System.Windows.Forms.MessageBox.Show("You will have to face a god to scape. Are you ready?", "", System.Windows.Forms.MessageBoxButtons.YesNo);
                if (d == System.Windows.Forms.DialogResult.Yes)
                {
                    user.deleteFromBag(this);
                    this.numberOfUses--;
                    user.setCurrentRoom(user.getMaze().getChallengeRoom());
                    Battle battle = new Battle(new Enemy("Hades", 60, null), user, user.getMaze());
                    battle.Show();


                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Remember prof. Rowan's words: there's a time and place for everything! But not now.");
            }
            
        }
        public override string getDescription()
        {
            return this.description;
        }
    }
}
