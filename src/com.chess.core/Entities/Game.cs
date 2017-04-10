using System.Collections.Generic;

namespace com.chess.core.Entities
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public IEnumerable<Figure> Figures { get; set; }
    }
}