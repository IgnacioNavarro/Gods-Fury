using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_MazeGame
{
    public class Item
    {

        protected string name;
        protected bool pickable;
        protected bool visible;
        protected int numberOfUses;
        protected bool onEnemy;
        protected string description;

        public Item (string name, bool pickable, int numerOfUses, bool onEnemy)
        {
            this.name = name;
            this.pickable = pickable;
            this.visible = true;
            this.numberOfUses = numerOfUses;
            this.onEnemy = onEnemy;
            this.description = "";
        }

        public Item(string name, bool pickable, bool visible)
        {
            this.name=name;
            this.pickable = pickable;
            this.visible = visible;
        }

        public virtual string getDescription()
        {
            return this.description;
        }

        public string Name { 
            get { return this.name; }
            set { this.name = value; }
        }

        public override string ToString()
        {
            return this.name;
        }

        public bool getOnEnemy()
        {
            return this.onEnemy;
        }

        public int getNumberOfUses()
        {
            return numberOfUses;
        }

        public bool isPickable()
        {
            if (this.pickable) return true;
            return false;
        }

        public bool isVisible()
        {
            if (this.visible) return true;
            return false;
        }

        public void setVisible()
        {
            this.visible = true;
        }

        public virtual void Use(Player user, Enemy enemy)
        {

            if(numberOfUses> 0)
            {
                numberOfUses--;
            }
        }
        /*
        public virtual void Use(Player user)
        {
            if(user.getCurrentRoom().getName() == "Forgotten's Abyss")
            {
                user.setCurrentRoom(user.getMaze().getWinningRoom());
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Remember prof. Rowan's words: there's a time and place for everything! But not now.");
            }
            

        }*/

    }
}
