using Safari.Enums;

namespace Safari.Models.ColdHabitat.Fish
{
    public abstract class ColdFish :ColdHabitat
    {
        public override AnimalsType Type { get; init; } = AnimalsType.Fish;
        public abstract bool IsPredator { get; init; }
    }
}
