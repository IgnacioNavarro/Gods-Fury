using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_MazeGame
{
    internal class Maze
    {

        private Room startRoom;
        private Room winningRoom;
        private Room losingRoom;
        private Room throneRoom = new Room("Zeus' Trhone Room", "#FFF", false, false, false, false, false, false, true);        //all doors closed but south
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
            winningRoom = exit;
            losingRoom = tortureChamber;

            //setting connections
            throneRoom.setConnectedRoom(null, null, null, hallC2);
            armory.setConnectedRoom(null, hallC2, null, eternalGarden);
            hallC2.setConnectedRoom(throneRoom, null, armory, hallC3);
            eternalGarden.setConnectedRoom(armory, hallC3, null, hallB4);
            hallC3.setConnectedRoom(hallC2, clockChamb, eternalGarden, hallC4);
            clockChamb.setConnectedRoom(null, kronosSymbol, hallC3, hallD4);
            kronosSymbol.setConnectedRoom(null, null, clockChamb, null);
            tortureChamber.setConnectedRoom(null, hallB4, null, null);
            hallB4.setConnectedRoom(eternalGarden, hallC4, tortureChamber, hermesDorm);
            hallC4.setConnectedRoom(hallC3, hallD4, hallB4, null);
            hallD4.setConnectedRoom(clockChamb, null, hallC4, zeusChallenge);
            hermesDorm.setConnectedRoom(hallB4, null, null, null);
            zeusChallenge.setConnectedRoom(hallD4, null, null, exit);
            exit.setConnectedRoom(zeusChallenge, null, null, null);
        }

        public void updateMap(System.Drawing.Graphics map, System.Drawing.SolidBrush pen)
        {

            map.FillRectangle(pen, 50, 10, 20, 10);
            pen.Dispose();
            map.Dispose();
        }

        public Room getStartRoom()
        {
            return this.startRoom;
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
