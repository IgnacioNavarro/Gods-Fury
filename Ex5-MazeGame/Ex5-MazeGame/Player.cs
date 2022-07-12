using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_MazeGame
{
    public class Player
    {
        private Room currentRoom;
        private List<Item> bag;

        private Maze maze;
        private int maxHP;
        private int HP;


        public Player(Room currentRoom)
        {
            this.currentRoom = currentRoom;
            this.bag = new List<Item>();
            this.maze = new Maze();
            this.maxHP = 30;
            this.HP = this.maxHP;
            /*
            //add items to the bag
            Item lightning = new Item("Lightning", true);
            Item rock = new Item("Rock", true);
            Item bigRock = new Item("Big rock", false);

            addToBag(lightning);
            addToBag(rock);
            addToBag(bigRock);
            */
        }

        public int getMaxHP()
        {
            return this.maxHP;
        }

        public int getHP()
        {
            return this.HP;
        }

        public Room getCurrentRoom()
        {
            return currentRoom;
        }

        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////
        //
        //
        //
        public void setCurrentRoom(Room r)
        {
            this.currentRoom = r;

        }
        //
        //
        //
        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////

        public List<Item> getBag()
        {
            return this.bag;
        }

        public void addToBag(Item item)
        {
            this.bag.Add(item);
        }

        public void deleteFromBag(Item item)
        {
            this.bag.Remove(item);
        }

        public void getHeal(int heal)
        {
            if((this.HP +heal)  >= this.maxHP ){
                this .HP = this.maxHP;
            }
            else
            {
                this.HP += heal; 
            }
        }

        public void getDamage(int damage)
        {
            if(damage >= this.HP)
            {
                this.HP = 0;
                //you die
            }
            else
            {
                this.HP -= damage;
            }
        }

        public String move(char direction)
        {

            if (this.currentRoom.getConnectedRoom(direction) != null)
            {
                if (this.currentRoom.isOpen(direction))
                {
                    Console.WriteLine(getCurrentRoom().getConnectedRoom(direction).getName());
                    Console.WriteLine(maze.getChallengeRoom().getName());
                    Console.WriteLine("///////////////////");
                    if (getCurrentRoom().getConnectedRoom(direction).getName() == maze.getChallengeRoom().getName())
                    {
                        return "challenge";
                    }
                    else
                    {
                        return "open";
                    }
                }

                return "closed";

            }

            return "wall";

        }
        //
        //
        //
        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////
    }
}
