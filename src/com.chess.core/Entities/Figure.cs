using com.chess.core.Contracts;
using System;

namespace com.chess.core.Entities
{
    public abstract class Figure : IFigure
    {
        public int X { get; protected set; }

        public int Y { get; protected set; }

        public int MaxStep { get; protected set; }

        public string Name { get; protected set; }


        public MoveAbility MoveDirections { get; protected set; }

        public MoveAbility FightDirections { get; protected set; }


        public bool Move(int X, int Y)
        {
            throw new NotImplementedException();
        }
    }
}
