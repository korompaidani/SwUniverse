using AutoMapper;
using System.Linq;

namespace StarWars.Data.Profiles
{
    public static class MapExtension
    {
        public static TDestination Map<TDestination>(this IMapper mapper, params object[] sources) where TDestination : new()
        {
            return Map(mapper, new TDestination(), sources);
        }

        public static TDestination Map<TDestination>(this IMapper mapper, TDestination destination, params object[] sources) where TDestination : new()
        {
            if (!sources.Any())
                return destination;

            foreach (var src in sources)
                destination = mapper.Map(src, destination);

            return destination;
        }
    }
}
