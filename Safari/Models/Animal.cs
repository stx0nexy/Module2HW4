using Safari.Enums;

namespace Safari.Models
{
    public abstract class Animal
    {
        public abstract SizeTypes Size { get; init; }
        public abstract AnimalsType Type { get; init; }
        public abstract double Weight { get; init; }
        public abstract ColorTypes Color { get; init; }
        public abstract HabitatTemperatureTypes HabitatTemperature { get; init; }
        public abstract int Age { get; init; }
    }
}
