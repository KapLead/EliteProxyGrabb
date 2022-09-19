using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EliteProxyGrabb.LanFunc
{

    public delegate void FindEventHandler(IFinder sender, List<Proxy> newProxyList);
    /// <summary> Реализация поиска прокси для конкретного ресурса  </summary>
    public interface IFinder
    {
        /// <summary> Дата последнего сканирования </summary>
        DateTime LastCheck { get; set; }

        /// <summary> Время следующего сканирования </summary>
        int NextCheck { get; set; }

        /// <summary> Надо ли произвести сканирование </summary>
        bool NeedCheck { get; }

        /// <summary> Парсинг прокси </summary>
        Task<Proxy[]> Grab();

        event FindEventHandler Finding;
    }
}
