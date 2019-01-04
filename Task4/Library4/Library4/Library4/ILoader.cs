using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library4
{
    public interface ILoader
    {
        /// <summary>
        /// Координата икс левого верхнего угла погрузчика
        /// </summary>
        int X { get; set; }
        /// <summary>
        /// Координата игрек левого верхнего угла погрузчика
        /// </summary>
        int Y { get; set; }
        /// <summary>
        /// Ширина погрузчика(квадратная модель)
        /// </summary>
        int Width { get; set; }
        /// <summary>
        /// Деталь, которая находится у погрузчика
        /// </summary>
        Detail Detail1 { get; set; }
        void TakeDetailFromMiller(Miller miller);
        /// <summary>
        /// Передать деталь фрезеровщику
        /// </summary>
        void TransferDetailToMiller(Miller miller);
    }
}
