using System;
using System.Collections.Generic;

namespace DictionaryOpdracht3
{
    internal class Game
    {
        private Dictionary<string, MonsterMaker> makers = new Dictionary<string, MonsterMaker>();
        private Room[] rooms = new Room[4];
        internal Game()
        {
            MonsterMaker orcMaker = new MonsterMaker() { Name = "orc" };
            MonsterMaker slimeMaker = new MonsterMaker() { Name = "slime" };

            //voeg de orc en slime toe aan de dictionary

            makers.Add(orcMaker.Name, orcMaker);
            makers.Add(slimeMaker.Name, slimeMaker);

            //maak nog 2 andere monstermakers aan
            MonsterMaker goblinMaker = new MonsterMaker() { Name = "goblin" };
            MonsterMaker dwarfMaker = new MonsterMaker() { Name = "dwarf" };

            makers.Add(goblinMaker.Name, goblinMaker);
            makers.Add(dwarfMaker.Name, dwarfMaker);

            MakeRooms();
        }

        private void MakeRooms()
        {
            rooms[0] = new Room()
            {
                allowedMonsters = new string[] { "orc" },
                monsters = new Monster[2]
            };

            //maak nog 3 andere rooms aan. in de array voor index 1,2 & 3

            rooms[1] = new Room()
            {
                allowedMonsters = new string[] { "orc", "slime" },
                monsters = new Monster[4]
            };


            rooms[2] = new Room()
            {
                allowedMonsters = new string[] { "orc", "slime", "goblin" },
                monsters = new Monster[6]
            };

            rooms[3] = new Room()
            {
                allowedMonsters = new string[] { "orc", "slime", "goblin", "dwarf" },
                monsters = new Monster[8]
            };

            

        }

        internal void RunGameSim()
        {
            Random random = new Random();

            Room room = rooms[random.Next(rooms.Length)];

            //maak een monster voor elke monster in de room, gebruik room.monsters
            
            for (int i = 0; i < room.monsters.Length; i++)
            {
                //selecteer een monster type uit room.allowedMonsters met de random, zie ook de room random
                string toMake = room.allowedMonsters[random.Next(room.allowedMonsters.Length)];

                //haal de maker op uit de dictionary op basis van de naam
                MonsterMaker maker = makers[toMake];
                Monster m = maker.Make();
                Console.WriteLine(m.Name);
                room.monsters[i] = m;//zet het monster in de kamer
            }
        }
    }
}