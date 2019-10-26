using System;
using System.Collections.Generic;
using System.Text;

namespace OnePiece.Domain
{
    public class Character
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public string Gender { get; set; }
        public int PirateId { get; set; }
        public Pirate Pirate { get; set; }
        public ICollection<CharacterPosition> CharacterPositions { get; set; }
        public int DevilFruitId { get; set; }
        public DevilFruit DevilFruit { get; set; }
    }
}
