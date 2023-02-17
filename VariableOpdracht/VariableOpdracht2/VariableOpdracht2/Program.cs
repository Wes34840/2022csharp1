using System;

namespace VariableOpdracht2
{
    internal class Program
    {
        //class variables & gebruik
        static void Main(string[] args)
        {

            //ga naar de file TwitchStream.cs in je solution explorer in visual studio
            TwitchStream twitchStream = new TwitchStream();

            //geef nu de stream de volgende waardes:
            //name, waarde: je favoriete streamer
            //lastStreamName, waarde: de streamname van de laatste keer
            //streamGame, waarde een nieuwe instance van Game (new Game("naam van de game hier"})
            //followers, waarde: hoeveel followers
            //automod, waarde: staat automod aan?
            twitchStream.name = "Draqu_";
            twitchStream.lastStreamName = "Doom Eternal 100% Ultra Nightmare Speedrun";
            twitchStream.streamGame = new Game("Doom Eternal");
            twitchStream.followers = 32600;
            twitchStream.automod = true;

            Console.WriteLine("Hello, World!");
        }
    }
}