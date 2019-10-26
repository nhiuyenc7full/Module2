using System;
using System.Collections.Generic;
using System.Text;

namespace OnePiece.Domain
{
    public class Pirate
    {
        public int PirateId { get; set; }
        public string Name { get; set; }
        public ICollection<Character> Character { get; set; }
    }
}
