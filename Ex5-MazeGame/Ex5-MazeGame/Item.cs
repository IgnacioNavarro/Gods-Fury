using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_MazeGame
{
    public class Item
    {

        private string name;
        private bool pickable;
        private bool visible;

        public Item (string name, bool pickable)
        {
            this.name = name;
            this.pickable = pickable;
            visible = true;
        }

        public Item(string name, bool pickable, bool visible)
        {
            this.name=name;
            this.pickable = pickable;
            this.visible = visible;
        }

        public string Name { 
            get { return this.name; }
            set { this.name = value; }
        }

        public override string ToString()
        {
            return this.name;
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

        public void use(Player user)
        {

        }
    }
}
