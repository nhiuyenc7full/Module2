using System;
using System.Collections.Generic;
using System.Text;

namespace OnePiece.Domain
{
    public class Position
    {
        public int PositionId { get; set; }
        public string Name { get; set; }
        public ICollection<CharacterPosition> CharacterPositions { get; set; }
    }
}
