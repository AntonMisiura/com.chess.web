using System;

namespace com.chess.core.Entities
{
    /// <summary>
    /// Move Ability Enum, Using Flags
    /// </summary>
    [Flags]
    public enum MoveAbility
    {
        Up = 1,
        Down = 2,
        Left = 4,
        Right = 16,

        Straight = 32,
        Diagonal = 64,
        Ldirection = 128
    }
}