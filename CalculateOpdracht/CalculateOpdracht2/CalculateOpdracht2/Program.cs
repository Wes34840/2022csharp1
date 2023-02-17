using System;

namespace CalculateOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //we gaan nu dingen kopen

            int controllersInMandje = 0;

            controllersInMandje += 2;
            //koop 2 controllers


            //hij is in voorraad snel kopen!
            int ps5 = 0;

            //koop 1 ps5

            ps5++;

            //koop de games:

            int eldenRing = 0;

            int shantae = 0;

            int spongebob = 0;

            eldenRing++;

            shantae++;

            spongebob++;

            //hmmm weten we het zeker?
            //haal 1 game weg met -- of -= 1

            shantae--;

            //nu nog de prijs


            double ps5Prijs = 499.99;
            double controllerPrijs = 69.99;
            double gamePrijs = 59.99;


            double totaalControllerPrijs = 0;// controllersInMandje keer controllerPrijs

            totaalControllerPrijs = controllerPrijs * 2;

            double totaalGamePrijs = 0;// game1 keer gamePrijs  + game2 keer gamePrijs (let op je haakjes!)

            totaalGamePrijs = gamePrijs * 2;

            double totaalPrijs = 0;// tel hier alles bij elkaar op

            totaalPrijs = ps5Prijs + totaalControllerPrijs + totaalGamePrijs;

            //er moet nu 759.95 staan
            Console.Write(totaalPrijs);
        }
    }
}