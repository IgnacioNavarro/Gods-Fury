using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_MazeGame
{
    internal class Maze
    {

        private int level;
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

        public Maze()
        {
            //creating the rooms premade

            level = 1;

            //creating objects
            Item key = new Item("Flying Key", true,1, false);

            Item statue = new Item("Statue", false, 1, false);
            Item bomb = new Item("Bomb", true,1, false);



            //placing the items

            throneRoom.addContent(bomb);
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
            winningRoom = exit;
            losingRoom = tortureChamber;

            //setting connections
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
        }

        public void updateMap(System.Drawing.Graphics map, System.Drawing.SolidBrush pen, List<int> pos)
        {

            //map.FillRectangle(pen, pos[0], pos[1], 20, 10);
            map.FillRectangle(pen, 0, 0, 20, 10);

            pen.Dispose();
            map.Dispose();
        }

        public Room getStartRoom()
        {
            switch (level)
            {
                case 1:
                    return this.throneRoom;

                case 2:
                    return null;

                case 3:
                    return null;

                default:
                    return this.throneRoom;
            }
        }

        public Room getWinningRoom()
        {
            return this.winningRoom;
        }

        public Room getLosingRoom()
        {
            return this.losingRoom;
        }

        public Room getChallengeRoom()
        {
            return this.zeusChallenge;
        }


    }
}
