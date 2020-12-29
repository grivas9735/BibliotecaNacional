using System.Collections.Generic;
using System.Linq;

namespace Biblioteca_Extensions
{
    public static class ListExtension
    {
        public static bool NullOrEmpty<T>(this IEnumerable<T> genericList)
        {
            return genericList == null || !genericList.Any();
        }
    }
}
