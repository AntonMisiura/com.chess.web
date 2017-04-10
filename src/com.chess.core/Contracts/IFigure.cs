using com.chess.core.Entities;

namespace com.chess.core.Contracts
{
    public interface IFigure
    {
        int X { get; }

        int Y { get; }

        int MaxStep { get; }

        string Name { get; }


        MoveAbility MoveDirections { get; }

        MoveAbility FightDirections { get; }


        bool Move(int X, int Y);
    }
}
