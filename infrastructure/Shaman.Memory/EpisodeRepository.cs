using System;
using System.Linq;
using ShamanKing;

namespace Shaman.Memory
{
    public class EpisodeRepository : IEpisodeRepository
    {
        private readonly Episode[] episodes = new[]
        {
            new Episode(1, " 1 серия - Мальчик, танцующий с призраками"),
            new Episode(2, " 2 серия - Ожидающий самурай"),
            new Episode(3,"3 серия - Другой шаман"),
            new Episode(4,"4 серия - Стопроцентный контроль"),
            new Episode(5,"5 серия - Шаманка, которая старше своего возраста"),
            new Episode(6,"6 серия - Мастер кунг-фу"),
            new Episode(7,"7 серия - Пай-Лон, удар ярости"),
            new Episode(8,"8 серия - Жизнь шамана"),
            new Episode(9,"9 серия - Мальчик с севера"),
            new Episode(10,"10 серия - Судьба шестисот лет"),
            new Episode(11,"11 серия - Весенний дождь"),
            new Episode(12,"12 серия - Звезда — сигнал начала"),
            new Episode(13,"13 серия - Дух бесплотный"),
            new Episode(14,"14 серия - Бой шаманов"),
            new Episode(15,"15 серия - Кости-убийцы"),
            new Episode(16,"16 серия - Любовь Фауста"),
            new Episode(17,"17 серия - Путешествие двух людей к святой обители"),
            new Episode(18,"18 серия - Йо!"),
            new Episode(19,"19 серия - Большие духи двоих"),
            new Episode(20,"20 серия - Кладбище духов Мата"),
            new Episode(21,"21 серия - Вера"),
            new Episode(22,"22 серия - Наши смертельные ошибки"),
            new Episode(23,"23 серия - Восставшие зомби Дзиото"),
            new Episode(24,"24 серия - Неуязвимый Ен Тао"),
            new Episode(25,"25 серия - Путешествие шаманов"),
            new Episode(26,"26 серия - Большая Америка"),
            new Episode(27,"27 серия - Революция даузинга"),
            new Episode(28,"28 серия - Мститель Лайсерг"),
            new Episode(29,"29 серия - Природа природы"),
            new Episode(30,"30 серия - Украденный мобильный оракул"),
            new Episode(31,"31 серия - Город призраков"),
            new Episode(32,"32 серия - Очень Хороший день"),
            new Episode(33,"33 серия - Атака Хао"),
            new Episode(34,"34 серия - Великолепный западный курорт"),
            new Episode(35,"35 серия - Засада вампира"),
            new Episode(36,"36 серия - Крылатые разрушители"),
            new Episode(37,"37 серия - Изюминка"),
            new Episode(38,"38 серия - Пять великих вождей"),
            new Episode(39,"39 серия - Готичная атака"),
            new Episode(40,"40 серия - Прикосновение дьявола"),
            new Episode(41,"41 серия - Безупречный контроль"),
            new Episode(42,"42 серия - Двойная трансформация"),
            new Episode(43,"43 серия - Промах Лайсерга"),
            new Episode(44,"44 серия - Команда Ледяная комета"),
            new Episode(45,"45 серия - Деревня Добби или провал"),
            new Episode(46,"46 серия - Мёртвый дух Тао"),
            new Episode(47,"47 серия - Такой наивный!"),
            new Episode(48,"48 серия - Дракон судьбы"),
            new Episode(49,"49 серия - Доктор, доктор"),
            new Episode(50,"50 серия - В моём сердце тьма"),
            new Episode(51,"51 серия - Охота шамана"),
            new Episode(52,"52 серия - Спец-тренировка"),
            new Episode(53,"53 серия - Пока, пока"),
            new Episode(54,"54 серия - Восьмой ангел"),
            new Episode(55,"55 серия - Врата Вавилона"),
            new Episode(56,"56 серия - Двери Вавилона"),
            new Episode(57,"57 серия - Конец турнира шаманов"),
            new Episode(58,"58 серия - Горящий ангел"),
            new Episode(59,"59 серия - Секретный путь звёзд"),
            new Episode(60,"60 серия - Друг"),
            new Episode(61,"61 серия - Прощай навсегда"),
            new Episode(62,"62 серия - Умри! Сражайся!"),
            new Episode(63,"63 серия - Ты должен жить"),
            new Episode(64,"64 серия - Эпилог"),
        };
        public Episode[] GetAllByTitle(string titlePart)
        {
            return episodes.Where(episode => episode.Title.Contains(titlePart))
                .ToArray();
        }
    }
}
