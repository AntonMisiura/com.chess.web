namespace com.chess.core.Entities
{
    public class QueenFigure : Figure
    {
        public QueenFigure()
        {
            MaxStep = (int)ChessBoard.Size;
            MoveDirections = MoveAbility.Diagonal | MoveAbility.Straight | MoveAbility.Up | MoveAbility.Down | MoveAbility.Left | MoveAbility.Right;
            FightDirections = MoveAbility.Diagonal | MoveAbility.Straight | MoveAbility.Up | MoveAbility.Down | MoveAbility.Left | MoveAbility.Right;
        }
    }
}