using Safari.Enums;

namespace Safari.Models.WarmHabitat.Mammals
{
    public class Lion : WarmMammals
    {
        public override SizeTypes Size { get; init; } = SizeTypes.Large;
        public override double Weight { get; init; } = 90;
        public override ColorTypes Color { get; init; } = ColorTypes.Orange;
        public override int Age { get; init; } = 13;
        public override bool IsPredator { get; init; } = true;
    }
}
