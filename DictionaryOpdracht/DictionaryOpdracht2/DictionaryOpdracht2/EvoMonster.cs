using System;
using System.Collections.Generic;

namespace DictionaryOpdracht2
{
    class EvoMonster
    {
        public string Name { get; set; }
        public string EvolvesTo { get; set; }

        internal EvoMonster Evolve(Dictionary<string, EvoMonster> monsters)
        {
            //als deze crashed wat ben je vergeten? wat moet er in monsters zitten?
            EvoMonster next = monsters["most popular"];
            return next;
        }
    }
}