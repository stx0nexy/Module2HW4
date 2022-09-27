using Safari.Models;
using System.Collections.Generic;

namespace Safari.Helpers
{
    public class AnimalsComparer : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            if (x == null || y == null)
            {
                return 0;
            }

            switch (x?.Size - y?.Size)
            {
                case > 0:
                    return 1;
                case < 0:
                    return -1;
            }

            return 0;
        }
    }
}
