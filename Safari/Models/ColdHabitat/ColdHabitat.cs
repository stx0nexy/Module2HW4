using Safari.Enums;

namespace Safari.Models.ColdHabitat
{
    public abstract class ColdHabitat : Animal
    {
        public override HabitatTemperatureTypes HabitatTemperature { get; init; } = HabitatTemperatureTypes.ColdHabitat;
    }
}
