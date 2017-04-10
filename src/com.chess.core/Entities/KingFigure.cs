namespace com.chess.core.Entities
{
    public class KingFigure : Figure
    {
        public KingFigure()
        {
            MaxStep = 2;
            MoveDirections = MoveAbility.Diagonal | MoveAbility.Straight | MoveAbility.Up | MoveAbility.Down | MoveAbility.Left | MoveAbility.Right;
            FightDirections = MoveAbility.Diagonal | MoveAbility.Straight | MoveAbility.Up | MoveAbility.Down | MoveAbility.Left | MoveAbility.Right;
        }
    }
}