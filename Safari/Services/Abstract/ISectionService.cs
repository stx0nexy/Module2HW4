using Safari.Models;

namespace Safari.Services.Abstract
{
    public interface ISectionService
    {
        void Add(Animal[] animals);
        void SortBySize(Animal[] animals);
        Animal[] AnimalsAtSection(Animal[] animals);
    }
}
