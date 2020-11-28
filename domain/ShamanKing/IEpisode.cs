using System;
using System.Collections.Generic;
using System.Text;

namespace ShamanKing
{
    interface IEpisode
    {
        Episode[] GetAllByTitle(string titlePart);//этот метод будет получать часть названия, и возращать эпизод
    }
}
