using Safari.Models;
using Safari.Models.ColdHabitat.Birds;
using Safari.Models.ColdHabitat.Fish;
using Safari.Models.ColdHabitat.Mammals;
using Safari.Models.WarmHabitat.Birds;
using Safari.Models.WarmHabitat.Fish;
using Safari.Models.WarmHabitat.Mammals;
using Safari.Providers.Abstract;

namespace Safari.Providers
{
    class AnimalProvider : IAnimalProvider
    {
        public Animal[] GetAnimals()
        {
            return new Animal[]
            {
                new Penguin(),
                new Pollack(),
                new PlarBear(),
                new Flamingo(),
                new Shark(),
                new Lion()
            };
        }
    }
}
