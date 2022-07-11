﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5_MazeGame
{
    public class Room
    {
        private Room northRoom;
        private Room southRoom;
        private Room westRoom;
        private Room eastRoom;
        private string name;
        private string paint = "#000";
        private bool NisOpened;
        private bool EisOpened;
        private bool WisOpened;
        private bool SisOpened;
        private bool lights;
        private bool enemies;
        private bool chest;
        private List<Item> content;


        public Room(string name, string paint,bool lights, bool enemies, bool chest, bool isOpened )
        {
            this.name = name;
            this.lights = false;
            this.enemies =enemies;
            this.chest = chest;
            this.NisOpened = isOpened;
            this.EisOpened = isOpened;
            this.WisOpened = isOpened;
            this.SisOpened = isOpened;
            this.paint = paint ;
            this.content = new List<Item>();
        }
        public Room(string name, string paint, bool lights, bool enemies, bool chest, bool NisOpened, bool EisOpened, bool WisOpened, bool SisOpened)
        {
            this.name = name;
            this.lights = false;
            this.enemies = enemies;
            this.chest = chest;
            this.NisOpened = NisOpened;
            this.EisOpened = EisOpened;
            this.WisOpened = WisOpened;
            this.SisOpened = SisOpened;
            this.paint = paint;
            this.content = new List<Item>();
        }

        public string getName()
        {
            return this.name;
        }


        public void addContent(Item item)
        {
            this.content.Add(item);
        }

        public void deleteContent(Item item)
        {
            this.content.Remove(item);
        }

        public List<Item> getContent()
        {
            return content;

        }

        public void setConnectedRoom(Room north, Room east, Room west, Room south)
        {
            this.northRoom = north;
            this.eastRoom = east;
            this.westRoom = west;
            this.southRoom = south;
        }

        public Room getConnectedRoom(char direction)
        {
            switch (direction)
            {
                case 'N':
                    return northRoom;
                case 'S':
                    return southRoom;
                case 'W':
                    return westRoom;
                case 'E':
                    return eastRoom;
                default:
                    return null;

            }
        }

        public bool isOpen(char direction)
        {
            if (direction == 'N')
            {
                return NisOpened;
            }
            else if (direction == 'E')
            {
                return EisOpened;
            }
            else if (direction == 'W')
            {
                return WisOpened;
            }
            else if (direction == 'S')
            {
                return SisOpened;
            } else
            {
                return false;
            }
        }

        public void changeStateDoor(bool isOpened, char direction)
        {
            if (direction == 'N')
            {
                this.NisOpened = !isOpened;
            } 
            else if (direction == 'E')
            {
                this.EisOpened = !isOpened;
            }
            else if (direction == 'W')
            {
                this.WisOpened = !isOpened;
            }
            else if (direction == 'S')
            {
                this.SisOpened = !isOpened;
            }
            else
            {

            }
        }

        public void changeStateLight(bool lights)
        {
            this.lights=!lights;
        }

        public bool chestInRoom(bool chest)
        {
            if (chest) return true;
            else return false;
        }

    }
}