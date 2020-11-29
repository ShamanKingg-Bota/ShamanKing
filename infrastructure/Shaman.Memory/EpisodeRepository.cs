using System;
using System.Linq;
using ShamanKing;

namespace Shaman.Memory
{
    public class EpisodeRepository : IEpisodeRepository
    {
        private readonly Episode[] episodes = new[]
        {
            new Episode(1, "Мальчик, танцующий с призраками"),
            new Episode(2, " Ожидающий самурай"),
            new Episode(3,"Другой шаман"),
        };
        public Episode[] GetAllByTitle(string titlePart)
        {
            return episodes.Where(episode => episode.Title.Contains(titlePart))
                .ToArray();
        }
    }
}
