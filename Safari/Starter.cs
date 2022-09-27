using Safari.Enums;
using Safari.Helpers;
using Safari.Models;
using Safari.Providers;
using Safari.Services;
using System;

namespace Safari
{
    public class Starter
    {
        private readonly AnimalProvider _animalProvider;
        private readonly SectionService _sectionService;
        private Animal[] _section;
        public Starter()
        {
            _animalProvider = new AnimalProvider() ;
            _sectionService = new SectionService(_animalProvider);
        }
        public void Run()
        {
            _section = _animalProvider.GetAnimals();
            _sectionService.Add(_section);
            _sectionService.SortBySize(_section);
            foreach (var animal in _section)
            {
                Console.WriteLine($"{animal.GetType().Name}, size: {animal.Size}");
            }
            Console.WriteLine($"Found animal:{FindAnimalBySize.Find(_section, SizeTypes.medium).GetType().Name}, size: {FindAnimalBySize.Find(_section, SizeTypes.medium).Size}");

           
        }
    }
}
