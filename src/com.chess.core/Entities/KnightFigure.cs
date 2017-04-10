namespace com.chess.core.Entities
{
    public class KnightFigure : Figure
    {
        public KnightFigure()
        {
            MaxStep = 4;
            MoveDirections = MoveAbility.Ldirection | MoveAbility.Up | MoveAbility.Down | MoveAbility.Left | MoveAbility.Right;
            FightDirections = MoveAbility.Ldirection | MoveAbility.Up | MoveAbility.Down | MoveAbility.Left | MoveAbility.Right;
        }
    }
}