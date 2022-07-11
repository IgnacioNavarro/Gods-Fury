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


        public Player(Room currentRoom)
        {
            this.currentRoom = currentRoom;
            this.bag = new List<Item>();
            this.maze = new Maze();
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

        public Room getCurrentRoom()
        {
            return currentRoom;
        }

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

        public String move(char direction)
        {

         if(this.currentRoom.getConnectedRoom(direction)!= null)
            {
                if (this.currentRoom.isOpen(direction))
                {
                    if (getCurrentRoom() == maze.getChallengeRoom() && direction == 'S')
                    {

                    }
                    else
                    {
                    this.currentRoom = this.currentRoom.getConnectedRoom(direction);
                    return "open";
                    }
                }

                return "closed";
                
            }

                return "wall";
            
        }
    }
}
