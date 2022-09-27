using Safari.Enums;

namespace Safari.Models.ColdHabitat.Mammals
{
    public abstract class ColdMammals : ColdHabitat
    {
        public override AnimalsType Type { get; init; } = AnimalsType.Mammals;
        public abstract bool IsPredator { get; init; }
    }
}
