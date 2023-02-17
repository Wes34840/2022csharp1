using System;

namespace CalculateOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            double totaalPrijs = 759.95;// tel hier alles bij elkaar op

            //oof wat duur, maar we hebben een kortings bon! 20% korting

            //eerst even uitrekenen wat we dan eigenlijk betalen , 100% - 20%

            double prijsProcentBetalen = 100 - 20;// maak hier de som  100% - 20% (% mag je weglaten)


            //nu de echte prijs dan moeten we eerst de prijs door 100.0 delen en dan keer prijsProcentBetalen
            //(niet)
            double doorHonderd = totaalPrijs / 100;//maak hier de totalPrijs GEDEELD DOOR 100.0 som

            double teBetalen = doorHonderd * prijsProcentBetalen;//nu doorHondered KEER prijsProcentBetalen

            Console.WriteLine(prijsProcentBetalen);

            //er moet nu 607.96 staan
            Console.WriteLine($"te betalen {teBetalen}");

            double teBetalenMakkelijk = totaalPrijs * 0.8; //makkelijkere manier

            Console.WriteLine($"te betalen {teBetalenMakkelijk}"); //hetzelfde antwoord
        }
    }
}