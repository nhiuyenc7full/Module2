using System;
using System.Collections.Generic;
using System.Text;

namespace OnePiece.Domain
{
    public class CharacterPosition
    {
        public int CharacterId { get; set; }
        public Character Character { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
