using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_MazeGame
{
    public class Maze
    {

        private int level;
        ///////////////////////////////////////////             1st maze            //////////////////////////////////////////////////
        private Room startRoom;
        private Room winningRoom;
        private Room losingRoom;
        private Room throneRoom = new Room("Zeus' Throne Room", "#FFF", false, false, false, true);     
        private Room armory = new Room("Armory", "#FFF", false, false, false, true);                      
        private Room eternalGarden = new Room("Eternal Garden", "#FFF", false, false, false, true);
        private Room hermesDorm = new Room("Hermes' Dormitory", "#FFF", false, false, false, true);
        private Room clockChamb = new Room("Clock's Chamber", "#FFF", false, false, false, true);
        private Room tortureChamber = new Room("Torture Chamber", "#FFF", false, false, false, true);
        private Room kronosSymbol = new Room("Krono's Symbol", "#FFF", false, false, false, true);
        private Room hallC2 = new Room("Palace's corridors I", "#FFF", false, false, false, true);    
        private Room hallC3 = new Room("Palace's corridors II", "#FFF", false, false, false, true);
        private Room hallC4 = new Room("Palace's corridors III", "#FFF", false, false, false, true);
        private Room hallB4 = new Room("Palace's corridors IV", "#FFF", false, false, false, true);
        private Room hallD4 = new Room("Palace's corridors V", "#FFF", false, false, false, true);
        private Room zeusChallenge = new Room("Zeus' Challenge", "#FFF", false, false, false, true);
        private Room exit = new Room("Exit", "#FFF", false, false, false, true);

        ///////////////////////////////////////////             //////////            //////////////////////////////////////////////////



        ///////////////////////////////////////////             2nd maze            //////////////////////////////////////////////////
        
        private Room mounPathA1 = new Room("Path of the Mountain", "#FFF", false, false, false, true);
        private Room mounPathB1 = new Room("Path of the Mountain", "#FFF", false, false, false, true);
        private Room mounPathB2 = new Room("Path of the Mountain", "#FFF", false, false, false, true);
        private Room mounPathC2 = new Room("Path of the Mountain", "#FFF", false, false, false, true);
        private Room mounPathD2 = new Room("Path of the Mountain", "#FFF", false, false, false, true);
        private Room mounPathC3 = new Room("Path of the Mountain", "#FFF", false, false, false, true);
        private Room mounPathC4 = new Room("Path of the Mountain", "#FFF", false, false, false, true);
        private Room mounPathC5 = new Room("Path of the Mountain", "#FFF", false, false, false, true);
        private Room thornsPath1 = new Room("Thorns Path", "#FFF", false, false, false, true);
        private Room thornsPath2 = new Room("Thorns Path", "#FFF", false, false, false, true);
        private Room flowersPath1 = new Room("Flowers Path", "#FFF", false, false, false, true);
        private Room flowersPath2 = new Room("Flowers Path", "#FFF", false, false, false, true);
        private Room poseidon = new Room("Poseidon's Cliff", "#FFF", false, false, false, true);
        private Room abandHouse = new Room("Abandoned house", "#FFF", false, false, false, true);
        private Room gardBehind = new Room("Garden behind the house", "#FFF", false, false, false, true);
        private Room graveyard = new Room("Graveyard", "#FFF", false, false, false, true);
        private Room acropView = new Room("View of the Akropolis", "#FFF", false, false, false, true);
        private Room stadium = new Room("Atena's Stadium", "#FFF", false, false, false, true);
        private Room exit2 = new Room("Exit", "#FFF", false, false, false, true);

        ///////////////////////////////////////////             //////////            //////////////////////////////////////////////////


        ///////////////////////////////////////////             3rd maze            //////////////////////////////////////////////////

        private Room witheredPathB1 = new Room("Withered Path", "#FFF", false, false, false, true);
        private Room witheredPathC1 = new Room("Withered Path", "#FFF", false, false, false, true);
        private Room witheredPathD1 = new Room("Withered Path", "#FFF", false, false, false, true);
        private Room witheredPathB2 = new Room("Withered Path", "#FFF", false, false, false, true);
        private Room witheredPathD2 = new Room("Withered Path", "#FFF", false, false, false, true);
        private Room witheredPathC3 = new Room("Withered Path", "#FFF", false, false, false, true);
        private Room witheredPathD3 = new Room("Withered Path", "#FFF", false, false, false, true);
        private Room undCavesB4 = new Room("Underworld's Caves", "#FFF", false, false, false, true);
        private Room undCavesC5 = new Room("Underworld's Caves", "#FFF", false, false, false, true);
        private Room undCavesD5 = new Room("Underworld's Caves", "#FFF", false, false, false, true);
        private Room undCavesC6 = new Room("Underworld's Caves", "#FFF", false, false, false, true);
        private Room undCavesB6 = new Room("Underworld's Caves", "#FFF", false, false, false, true);
        private Room heroGrav = new Room("Heroe's Graveyard", "#FFF", false, false, false, true);
        private Room tower = new Room("Tower of Skulls", "#FFF", false, false, false, true);
        private Room gate = new Room("Hade's Domain's Gate", "#FFF", false, false, false, true);
        private Room abyss = new Room("Forgotten's Abyss", "#FFF", false, false, false, true);
        private Room deadIsland = new Room("Dead Island", "#FFF", false, false, false, true);
        private Room exit3 = new Room("Exit", "#FFF", false, false, false, true);


        ///////////////////////////////////////////             //////////            //////////////////////////////////////////////////

        public Maze(int startLevel)
        {
            //creating the rooms premade
            level = startLevel;

            //creating objects
            Item key = new Item("Flying Key", true,1, false);

            Item statue = new Item("Statue", false, 1, false);

            //Potions
            Potion pocionAfrodita = new Potion("Aphrodite's Heal kiss", true, 1, 11, false);
            Potion horn = new Potion("horn of plenty", true, 1, 20, false);
            Potion godSake = new Potion("Gods' Elixir", true, 1, 15, false);

            //Max HP
            MaxPotion goldenApple = new MaxPotion("Golden Apple of Discord", true, 1, 15, false);
            MaxPotion adamantiumShield = new MaxPotion("Adamantium Armor", true, 1, 30, false);

            //Weapons
            DamageItem AquilesShield = new DamageItem("Achilles' Shield", true, 2, 10, true);
            DamageItem zeusLighting = new DamageItem("Zeus' lightning", true, 1, 10, true);
            DamageItem chronosScythe = new DamageItem("Chronos' Scythe", true, 2, 13, true);
            DamageItem poseidontrident = new DamageItem("Poseidon's trident", true, 1, 10, true);

            //Specials
            Sandals sandals = new Sandals("Herme's Sandals", true, 1, false);



            //placing the items
            throneRoom.addContent(zeusLighting);
            kronosSymbol.addContent(chronosScythe);
            eternalGarden.addContent(goldenApple);
            armory.addContent(AquilesShield);

            acropView.addContent(pocionAfrodita);
            poseidon.addContent(poseidontrident);
            thornsPath2.addContent(horn);

            tower.addContent(sandals);
            heroGrav.addContent(adamantiumShield);
            undCavesD5.addContent(godSake);

/*
            bathroom.addContent(key);
            bathroom.addContent(coin);
            kitchen.addContent(statue);
            kitchen.addContent(bomb);
            livingroom.addContent(lamp);
            livingroom.addContent(camera);
            bedroom.addContent(pen);
            bedroom.addContent(book);*/

            //setting the checkpoints
            startRoom = throneRoom;
            winningRoom = exit2;
            losingRoom = tortureChamber;

            //setting connections MAZE 1
            throneRoom.setConnectedRoom(null, null, null, hallC2);
            throneRoom.setPos(192, 20);
            armory.setConnectedRoom(null, hallC2, null, eternalGarden);
            //armory.setPos(0, 30);
            hallC2.setConnectedRoom(throneRoom, null, armory, hallC3);
            //hallC2.setPos(0, 60);
            eternalGarden.setConnectedRoom(armory, null, null, null);
            //eternalGarden.setPos(0, 90);
            hallC3.setConnectedRoom(hallC2, null, null, hallC4);
            //hallC3.setPos(0, 120);
            clockChamb.setConnectedRoom(null, kronosSymbol, null, hallD4);
            //clockChamb.setPos(30, 0);
            kronosSymbol.setConnectedRoom(null, null, clockChamb, null);
            //kronosSymbol.setPos(30, 30);
            tortureChamber.setConnectedRoom(null, hallB4, null, null);
            //tortureChamber.setPos(30, 60);
            hallB4.setConnectedRoom(null, hallC4, tortureChamber, hermesDorm);
            //hallB4.setPos(30, 90);
            hallC4.setConnectedRoom(hallC3, hallD4, hallB4, null);
            //hallC4.setPos(30, 120);
            hallD4.setConnectedRoom(clockChamb, null, hallC4, zeusChallenge);
            //hallD4.setPos(60, 0);
            hermesDorm.setConnectedRoom(hallB4, null, null, null);
            //hermesDorm.setPos(60, 30);
            zeusChallenge.setConnectedRoom(hallD4, null, null, exit);
            //zeusChallenge.setPos(60, 60);
            exit.setConnectedRoom(zeusChallenge, null, null, null);
            //exit.setPos(60, 90);

            // Set connections MAZE 2

            mounPathA1.setConnectedRoom(null, mounPathB1, null, null);              //      UP      RIGHT       LEFT        DOWN
            mounPathA1.setPos(20, 20);
            mounPathB1.setConnectedRoom(null, null, mounPathA1, mounPathB2);
            mounPathB2.setConnectedRoom(mounPathB1, mounPathC2, null, null);
            mounPathC2.setConnectedRoom(null, mounPathD2, mounPathB2, mounPathC3);
            mounPathD2.setConnectedRoom(graveyard, null, mounPathC2, acropView);
            mounPathC3.setConnectedRoom(mounPathC2, null, abandHouse, mounPathC4);
            mounPathC4.setConnectedRoom(mounPathC3, null, null, mounPathC5);
            mounPathC5.setConnectedRoom(mounPathC4, flowersPath1, thornsPath1, null);
            thornsPath1.setConnectedRoom(null, mounPathC5, null, thornsPath2);
            thornsPath2.setConnectedRoom(thornsPath1, stadium, null, null);
            flowersPath1.setConnectedRoom(null, null, mounPathC5, flowersPath2);
            flowersPath2.setConnectedRoom(flowersPath1, null, stadium, null);
            poseidon.setConnectedRoom(null, abandHouse, null, null);
            abandHouse.setConnectedRoom(null, mounPathC3, poseidon, gardBehind);
            graveyard.setConnectedRoom(null, null, null, mounPathD2);
            acropView.setConnectedRoom(mounPathD2, null, null, null);
            gardBehind.setConnectedRoom(abandHouse, null, null, null);
            stadium.setConnectedRoom(null, flowersPath2, thornsPath2, exit2);


            // Set connections MAZE 3

            witheredPathB1.setConnectedRoom(null, witheredPathC1, null, witheredPathB2);  //      UP      RIGHT       LEFT        DOWN
            witheredPathC1.setConnectedRoom(null, witheredPathD1, witheredPathB1, null);
            witheredPathD1.setPos(250, 20);
            witheredPathD1.setConnectedRoom(null, null, witheredPathC1, witheredPathD2);
            witheredPathB2.setConnectedRoom(witheredPathB1, heroGrav, null, null);
            witheredPathD2.setConnectedRoom(witheredPathD1, null, null, witheredPathD3);
            witheredPathC3.setConnectedRoom(null, witheredPathD3, null, gate);
            witheredPathD3.setConnectedRoom(witheredPathD2, null, witheredPathC3, null);
            undCavesB4.setConnectedRoom(null, gate, tower, null);
            undCavesC5.setConnectedRoom(gate, undCavesD5, null, undCavesC6);
            undCavesD5.setConnectedRoom(null, null, undCavesC5, null);
            undCavesC6.setConnectedRoom(undCavesC5, null, undCavesB6, null);
            undCavesB6.setConnectedRoom(null, undCavesC6, null, abyss);
            heroGrav.setConnectedRoom(null, null, witheredPathB2, null);
            tower.setConnectedRoom(null, undCavesB4, null, null);
            gate.setConnectedRoom(witheredPathC3, null, undCavesB4, undCavesC5);
            abyss.setConnectedRoom(undCavesB6, null, null, null);
            deadIsland.setConnectedRoom(null, null, null, exit3);
            deadIsland.setPos(30, 350);
            exit3.setConnectedRoom(deadIsland, null, null, null);


            //  Setting Messages

            tortureChamber.setMsg("The torture room is full of unbelievable hideous images, decomposing bodies and bloodthirsty torture weapons. You can't help throwing up. You loose 5 hp");
            thornsPath2.setMsg("The thorns of those beautiful roses were poisonous. You get 5 HP damage");
            heroGrav.setMsg("The corpses of all the Heroes who tried to face the gods lay on this Graveyard. Your brother is here too. You loose 5 HP");
            abyss.setMsg("An abyss stands in front of you, where all the agonic souls are awaiting a new friend to play with. At the other side of the cliff, Hades observes you holding the key that would let you escape. If you just had a flying item you could use to cross the abyss");

        }

        public void updateMap(System.Drawing.Graphics map, System.Drawing.SolidBrush pen, List<int> pos)
        {

            //map.FillRectangle(pen, pos[0], pos[1], 20, 10);
            map.FillRectangle(pen, 0, 0, 20, 10);

            pen.Dispose();
            map.Dispose();
        }

        public void nextLevel()
        {
            level ++;
        }
        public int getLevel()
        {
            return this.level;
        }

        public Room getStartRoom()
        {
            switch (getLevel())
            {
                case 1:
                    return this.throneRoom;

                case 2:
                    return this.mounPathA1;

                case 3:
                    return witheredPathD1;

                default:
                    return this.throneRoom;
            }
        }

        public Room getHealingRoom()
        {
            switch (getLevel())
            {
                case 1:
                    return this.hermesDorm;

                case 2:
                    return this.gardBehind;

                case 3:
                    return this.tower;

                default:
                    return this.throneRoom;
            }
        }

        public Room getWinningRoom()
        {
            switch (getLevel())
            {
                case 1:
                    return this.exit;

                case 2:
                    return this.exit2;

                case 3:
                    return this.exit3;

                default:
                    return this.exit;
            }
        }

        public Room getLosingRoom()
        {
            switch (level)
            {
                case 1:
                    return this.tortureChamber;

                case 2:
                    return this.thornsPath2;

                case 3:
                    return this.heroGrav;

                default:
                    return this.tortureChamber;
            }
        }

        public Room getChallengeRoom()
        {
            switch (level)
            {
                case 1:
                    return this.zeusChallenge;

                case 2:
                    return this.stadium;

                case 3:
                    return deadIsland;

                default:
                    return this.zeusChallenge;
            }
        }


    }
}
