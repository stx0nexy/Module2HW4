using Safari.Enums;

namespace Safari.Models.WarmHabitat.Birds
{
    public class Flamingo : WarmBirds
    {
        public override SizeTypes Size { get; init; } = SizeTypes.Medium;
        public override double Weight { get; init; } = 4;
        public override ColorTypes Color { get; init; } = ColorTypes.Pink;
        public override int Age { get; init; } = 2;
        public override bool IsFlying { get; init; } = true;
    }
}
