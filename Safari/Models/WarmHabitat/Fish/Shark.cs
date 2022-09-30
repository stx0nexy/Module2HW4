using Safari.Enums;

namespace Safari.Models.WarmHabitat.Fish
{
    public class Shark : WarmFish
    {
        public override SizeTypes Size { get; init; } = SizeTypes.Large;
        public override double Weight { get; init; } = 770;
        public override ColorTypes Color { get; init; } = ColorTypes.Grey;
        public override int Age { get; init; } = 15;
        public override bool IsPredator { get; init; } = true;
    }
}
