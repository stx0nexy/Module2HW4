using Safari.Helpers;
using Safari.Models;
using Safari.Providers.Abstract;
using Safari.Services.Abstract;
using System;

namespace Safari.Services
{
    public class SectionService : ISectionService
    {
        private readonly IAnimalProvider _animalProvider;
        public SectionService(IAnimalProvider AnimalProvider)
        {
            _animalProvider = AnimalProvider;
        }

        private Animal[] Animals { get; set; }
        public void Add(Animal[] animals)
        {
            Animals = animals;
        }

        public void SortBySize(Animal[] animals)
        {
            Array.Sort(Animals, new AnimalsComparer());
        }

        public Animal[] AnimalsAtSection(Animal[] animals)
        {
            return Animals;
        }
    }
}
