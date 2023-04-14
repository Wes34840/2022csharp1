namespace DictionaryOpdracht3
{
    class MonsterMaker
    {
        public string Name { get; set; }

        public Monster Make()
        {
            return new Monster() { Name = Name };
        }
    }
}