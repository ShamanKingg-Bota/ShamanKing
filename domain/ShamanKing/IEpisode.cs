using System;
using System.Collections.Generic;
using System.Text;

namespace ShamanKing
{
    interface IEpisode
    {
        Episode[] GetAllTitle(string titlePart);//этот метод будет получать часть названия и 1 или несколько,или ни 1го эпизодов
 
    }
}
