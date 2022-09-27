using Safari.Enums;

namespace Safari.Models.WarmHabitat.Fish
{
    public abstract class WarmFish : WarmHabitat
    {
        public override AnimalsType Type { get; init; } = AnimalsType.Fish;
        public abstract bool IsPredator { get; init; }
    }
}
