using System.Collections.Generic;

namespace com.chess.core.Entities
{
    public class Figures : Figure
    {
        public Figure Pawn { get; set; }
        public Figure King { get; set; }
        public Figure Rook { get; set; }
        public Figure Bishop { get; set; }
        public Figure Queen { get; set; }
        public Figure Knight { get; set; }
    }
}
