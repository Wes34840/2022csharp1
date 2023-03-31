namespace PropertyOpdracht1
{
    internal class Persoon
    {
        public Persoon()
        {
        }
        
        public string Naam 
        { 
            get; internal 

            set; 
        }
        public int Leeftijd { get; internal set; }

        private string naam
        {
            get { return Naam; }
            set { naam = Naam; }
        }

        private int leeftijd
        {
            get { return Leeftijd; }
            set { leeftijd = Leeftijd; } // geen idee of dit goed is
        }
    }
}