using Safari.Enums;

namespace Safari.Models.WarmHabitat.Mammals
{
    public abstract class WarmMammals : WarmHabitat
    {
        public override AnimalsType Type { get; init; } = AnimalsType.Mammals;
        public abstract bool IsPredator { get; init; }
    }
}
