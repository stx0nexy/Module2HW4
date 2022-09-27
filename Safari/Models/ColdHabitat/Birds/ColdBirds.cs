using Safari.Enums;

namespace Safari.Models.ColdHabitat.Birds
{
    public abstract class ColdBirds : ColdHabitat
    {
        public override AnimalsType Type { get; init; } = AnimalsType.Birds;
        public abstract bool IsFlying { get; init; }
    }
}
