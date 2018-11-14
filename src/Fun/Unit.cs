using System;

#pragma warning disable 1591

namespace Fun
{
    public readonly struct Unit : IEquatable<Unit>
    {
        public static readonly Unit Value = new Unit();

        public override int GetHashCode() =>
            0;

        public override bool Equals(object obj) =>
            obj is Unit;

        public override string ToString() =>
            "()";

        public bool Equals(Unit other) =>
            true;

        public static bool operator ==(Unit lhs, Unit rhs) =>
            true;

        public static bool operator !=(Unit lhs, Unit rhs) =>
            false;

        // with using static Fun.Unit, allows using unit instead of the ugly Unit.Value
        public static Unit unit =>
            Value;

        // with using static Fun.Unit, allows using ignore(anything) to have anything return unit
        public static Unit ignore<T>(T anything) =>
            unit;
    }
}
