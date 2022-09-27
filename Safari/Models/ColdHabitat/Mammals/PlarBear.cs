using Safari.Enums;

namespace Safari.Models.ColdHabitat.Mammals
{
    public class PlarBear : ColdMammals
    {
        public override SizeTypes Size { get; init; } = SizeTypes.large;
        public override double Weight { get; init; } = 250;
        public override ColorTypes Color { get; init; } = ColorTypes.wight;
        public override int Age { get; init; } = 15;
        public override bool IsPredator { get; init; } = true;
    }
}
