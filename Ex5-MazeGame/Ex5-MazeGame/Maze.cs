﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_MazeGame
{
    internal class Maze
    {

        private int level=1;
        ///////////////////////////////////////////             1st maze            //////////////////////////////////////////////////
        private Room startRoom;
        private Room winningRoom;
        private Room losingRoom;
        private Room throneRoom = new Room("Zeus' Throne Room", "#FFF", false, false, false, false, false, false, true);        //all doors closed but south
        private Room armory = new Room("Armory", "#FFF", false, false, false, false, false, false, true);                       //all doors closed but south
        private Room eternalGarden = new Room("Eternal Garden", "#FFF", false, false, false, true);
        private Room hermesDorm = new Room("Hermes' Dormitory", "#FFF", false, false, false, true);
        private Room clockChamb = new Room("Clock's Chamber", "#FFF", false, false, false, true);
        private Room tortureChamber = new Room("Torture Chamber", "#FFF", false, false, false, true);
        private Room kronosSymbol = new Room("Krono's Symbol", "#FFF", false, false, false, true);
        private Room hallC2 = new Room("Palace's corridors I", "#FFF", false, false, false, false, false, false, true);       //all doors closed but south
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
        private Room thornsPath1 = new Room("Path of the Mountain", "#FFF", false, false, false, true);
        private Room thornsPath2 = new Room("Path of the Mountain", "#FFF", false, false, false, true);
        private Room flowersPath1 = new Room("Path of the Mountain", "#FFF", false, false, false, true);
        private Room flowersPath2 = new Room("Path of the Mountain", "#FFF", false, false, false, true);
        private Room poseidon = new Room("Poseidon's Cliff", "#FFF", false, false, false, true);
        private Room abandHouse = new Room("One simple abandoned house", "#FFF", false, false, false, true);
        private Room gardBehind = new Room("Garden behind the house", "#FFF", false, false, false, true);
        private Room graveyard = new Room("Graveyard", "#FFF", false, false, false, true);
        private Room acropView = new Room("View of the Akropolis", "#FFF", false, false, false, true);
        private Room stadium = new Room("Atena's Stadium", "#FFF", false, false, false, true);
        private Room exit2 = new Room("Exit", "#FFF", false, false, false, true);

        ///////////////////////////////////////////             //////////            //////////////////////////////////////////////////

        public Maze()
        {
            //creating the rooms premade


            //creating objects
            Item key = new Item("Flying Key", true);
            Item coin = new Item("Coin", true);
            Item statue = new Item("Statue", false);
            Item bomb = new Item("Bomb", true);
            Item lamp = new Item("Lamp", true);
            Item camera = new Item("Camera", true);
            Item pen = new Item("Pen", true);
            Item book = new Item("Book", true);


            //placing the items
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
            eternalGarden.setConnectedRoom(armory, hallC3, null, hallB4);
            //eternalGarden.setPos(0, 90);
            hallC3.setConnectedRoom(hallC2, clockChamb, eternalGarden, hallC4);
            //hallC3.setPos(0, 120);
            clockChamb.setConnectedRoom(null, kronosSymbol, hallC3, hallD4);
            //clockChamb.setPos(30, 0);
            kronosSymbol.setConnectedRoom(null, null, clockChamb, null);
            //kronosSymbol.setPos(30, 30);
            tortureChamber.setConnectedRoom(null, hallB4, null, null);
            //tortureChamber.setPos(30, 60);
            hallB4.setConnectedRoom(eternalGarden, hallC4, tortureChamber, hermesDorm);
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
        }

        public void updateMap(System.Drawing.Graphics map, System.Drawing.SolidBrush pen, List<int> pos)
        {

            //map.FillRectangle(pen, pos[0], pos[1], 20, 10);
            map.FillRectangle(pen, 0, 0, 20, 10);

            pen.Dispose();
            map.Dispose();
        }

        public void setLevel(int i)
        {
            level = i;
        }
        public int getLevel()
        {
            return level;
        }

        public Room getStartRoom()
        {
            switch (level)
            {
                case 1:
                    return this.throneRoom;

                case 2:
                    return this.mounPathA1;

                case 3:
                    return null;

                default:
                    return this.throneRoom;
            }
        }

        public Room getWinningRoom()
        {
            switch (level)
            {
                case 1:
                    return this.exit;

                case 2:
                    return this.exit2;

                case 3:
                    return null;

                default:
                    return this.exit;
            }
        }

        public Room getLosingRoom()
        {
            return this.losingRoom;
        }

        public Room getChallengeRoom()
        {

            Console.WriteLine(level);
            switch (level)
            {
                case 1:
                    return this.zeusChallenge;

                case 2:
                    return this.stadium;

                case 3:
                    return null;

                default:
                    return this.zeusChallenge;
            }
        }


    }
}
