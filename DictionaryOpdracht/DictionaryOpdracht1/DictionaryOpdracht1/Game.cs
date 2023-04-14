using System;
using System.Collections.Generic;

namespace DictionaryOpdracht1
{
    internal class Game
    {
        //stel we hebben rooms waar je tussen kan warpen
        Dictionary<string, Room> rooms = new Dictionary<string, Room>();
        Room currentRoom;
        public Game()
        {
            MakeRooms();

        }

        internal void Run()
        {


            WarpToRoom("start");

            WarpToRoom(currentRoom.WarpForward);//naar kamer 2
            WarpToRoom(currentRoom.WarpBackward);//terug naar start
            WarpToRoom(currentRoom.WarpForward);//weer naar kamer 2
            WarpToRoom(currentRoom.WarpForward);//naar kamer 3??

        }
        private void WarpToRoom(string warpTo)
        {
            //haal warpTo heeft de key (Name) van de Room, gebruik die om de ROom uit de dictionary te halen
            Room target = rooms[warpTo];
            //geef this.currentRoom als waarde target
            currentRoom = target;
            Console.WriteLine("player warped to " + currentRoom.Name);
        }


        private void MakeRooms()
        {
            Room start = new Room
            {
                Name = "start",
                WarpBackward = "start",//UITLEG:: gaat naar zichzelf om niet te crashen
                WarpForward = "spookkamer"
            };

            //voeg nu de start kamer toe aan de dictionary met de Add method.
            //gebruik Name als key
            rooms.Add("start", start);


            //voeg nog 2 kamers toe, leg de verbindingen (WarpBackward en WarpForward) goed let op de Name van de Room waar je heen wil!

            Room spookkamer = new Room
            {
                Name = "spookkamer",
                WarpBackward = "start",
                WarpForward = "kistkamer"
            };

            rooms.Add("spookkamer", spookkamer);

            Room kistkamer = new Room
            {
                Name = "kistkamer",
                WarpBackward = "spookkamer",
                WarpForward = "dead end"
            };

            rooms.Add("kistkamer", kistkamer);
        }
    }
}