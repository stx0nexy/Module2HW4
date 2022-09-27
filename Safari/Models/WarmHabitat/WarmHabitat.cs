using Safari.Enums;

namespace Safari.Models.WarmHabitat
{
    public abstract class WarmHabitat : Animal
    {
        public override HabitatTemperatureTypes HabitatTemperature { get; init; } = HabitatTemperatureTypes.WarmHabitat;
    }
}
