namespace com.chess.core.Entities
{
    public class BishopFigure : Figure
    {
        public BishopFigure()
        {
            MaxStep = (int)ChessBoard.Size;
            MoveDirections = MoveAbility.Diagonal | MoveAbility.Up | MoveAbility.Down | MoveAbility.Left | MoveAbility.Right;
            FightDirections = MoveAbility.Diagonal | MoveAbility.Up | MoveAbility.Down | MoveAbility.Left | MoveAbility.Right;
        }
    }
}