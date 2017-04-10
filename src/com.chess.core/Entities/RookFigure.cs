namespace com.chess.core.Entities
{
    public class RookFigure : Figure
    {
        public RookFigure()
        {
            MaxStep = (int)ChessBoard.Size;
            MoveDirections = MoveAbility.Straight | MoveAbility.Up | MoveAbility.Down | MoveAbility.Left | MoveAbility.Right;
            FightDirections = MoveAbility.Straight | MoveAbility.Up | MoveAbility.Down | MoveAbility.Left | MoveAbility.Right;
        }
    }
}