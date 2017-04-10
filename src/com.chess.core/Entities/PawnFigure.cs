namespace com.chess.core.Entities
{
    public class PawnFigure : Figure
    {
        public PawnFigure()
        {
            MaxStep = 3;
            MoveDirections = MoveAbility.Straight | MoveAbility.Up;
            FightDirections = MoveAbility.Diagonal | MoveAbility.Left | MoveAbility.Right;
        }
    }
}