using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

namespace DictionaryOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //maak een dictionary aan van EvoMonsters op naam;
            Dictionary<string, EvoMonster> monsters = new Dictionary<string, EvoMonster>();


            EvoMonster pickelChu = new EvoMonster() { Name = "pickleChu", EvolvesTo = "most popular" };
            EvoMonster boosDraakje = new EvoMonster() { Name = "boosDraakje", EvolvesTo = "nog koppiger" };
            EvoMonster mostPopular = new EvoMonster() { Name = "most popular", EvolvesTo = "idk bro a fucking duracell battery" };




            //voeg de bovenstaande monsters toe
            monsters.Add("pickleChu", pickelChu);
            monsters.Add("boosDraakje", boosDraakje);
            monsters.Add("most popular", mostPopular); // very bandaid fix, probably not intended




            //kies een monster uit de dictionary
            EvoMonster ikKiesJouw = pickelChu;

            Console.WriteLine(ikKiesJouw.Name + " wants to evolve may it? (y/n)");
            if (Console.ReadLine() == "y")
            {
                //als deze crashed wat ben je vergeten? wat moet er in monsters zitten?
                ikKiesJouw = ikKiesJouw.Evolve(monsters);//maak deze method af in EvoMonster.cs

                Console.WriteLine("you now have a " + ikKiesJouw.Name);
            }
        }
    }
}