using Safari.Enums;
using Safari.Models;

namespace Safari.Helpers
{
    public static class FindAnimalBySize
    {
        public static Animal Find(this Animal[] animals, SizeTypes size)
        {
            Animal result = null;
            foreach (var animal in animals)
            {
                if (animal != null && animal.Size == size)
                {
                    result = animal;
                    break;
                }
            }

            return result;
        }
    }
}
