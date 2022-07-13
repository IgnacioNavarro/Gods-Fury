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
            this.maze = new Maze(1);
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

            //potions
            Potion pocionAfrodita = new Potion("Aphrodite's Heal kiss", true, 1, 11, false);
            Potion healPotion = new Potion("Heal Potion", true, 2, 5, false);
            Potion godSake = new Potion("Gods' Elixir", true, 1, 15, false);
            Potion horn = new Potion("horn of plenty", true, 1, 20, false);

            //weapons
            DamageItem sword = new DamageItem("Elucidator Sword", true, 1, 8, true);
            DamageItem swrod2 = new DamageItem("Dark Repulse Sword", true, 1, 8, true);
            DamageItem AquilesShield = new DamageItem("Achilles' Shield", true, 2, 10, true);
            DamageItem chronosScythe = new DamageItem("Chronos' Scythe", true, 2, 13, true);
            DamageItem zeusLighting = new DamageItem("Zeus' lightning", true, 1, 10, true);
            DamageItem poseidontrident = new DamageItem("Poseidon's trident", true, 1, 10, true);

            //New max HP
            MaxPotion goldenApple = new MaxPotion("Golden Apple of Discord", true, 1, 15, false);
            MaxPotion adamantiumShield = new MaxPotion("Adamantium Armor", true, 1, 30, false);


            //starter kit
            addToBag(healPotion);
            addToBag(sword);
            addToBag(swrod2);

            //found around the map but for trying
            addToBag(goldenApple);
            addToBag(adamantiumShield);
            addToBag(AquilesShield);
            addToBag(horn);
            addToBag(pocionAfrodita);
            addToBag(godSake);
            addToBag(chronosScythe);
            addToBag(zeusLighting);
            addToBag(poseidontrident);




        }

        public int getMaxHP()
        {
            return this.maxHP;
        }

        public Maze getMaze()
        {
            return this.maze;
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

        public void newMaxHP(int newMax)
        {
            this.maxHP = this.maxHP + newMax;
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
