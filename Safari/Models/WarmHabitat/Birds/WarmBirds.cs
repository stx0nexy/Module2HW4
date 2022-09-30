using Safari.Enums;

namespace Safari.Models.WarmHabitat.Birds
{
    public abstract class WarmBirds : WarmHabitat
    {
        public override AnimalsType Type { get; init; } = AnimalsType.Birds;
        public abstract bool IsFlying { get; init; }
    }
}
