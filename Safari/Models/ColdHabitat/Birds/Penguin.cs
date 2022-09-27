using Safari.Enums;

namespace Safari.Models.ColdHabitat.Birds
{
    public class Penguin : ColdBirds
    {
        public override SizeTypes Size { get; init; } = SizeTypes.medium;
        public override double Weight { get; init; } = 35;
        public override ColorTypes Color { get; init; } = ColorTypes.black;
        public override int Age { get; init; } = 3;
        public override bool IsFlying { get; init; } = false;
    }
}
