using Safari.Enums;

namespace Safari.Models.ColdHabitat.Fish
{
    public class Pollack : ColdFish
    {
        public override SizeTypes Size { get; init; } = SizeTypes.small;
        public override double Weight { get; init; } = 0.770;
        public override ColorTypes Color { get; init; } = ColorTypes.brown;
        public override int Age { get; init; } = 7;
        public override bool IsPredator { get; init; } = true;
    }
}
