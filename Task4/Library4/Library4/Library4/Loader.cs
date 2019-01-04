using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library4
{
    public class Loader : ILoader
    {
        /// <summary>
        /// Координата икс левого верхнего угла погрузчика
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Старая координата икс левого верхнего угла погрузчика
        /// </summary>
        public int OldX { get; set; }
        /// <summary>
        /// Координата игрек левого верхнего угла погрузчика
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Ширина погрузчика(квадратная модель)
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// Деталь, которая находится у погрузчика
        /// </summary>
        public Detail Detail1 { get; set; }
        public Loader(int x, int y, int width, Detail detail)
        {
            X = x;
            Y = y;
            Width = width;
            Detail1 = detail;
        }
        /// <summary>
        /// Взять деталь у фрезеровщика
        /// </summary>
        public void TakeDetailFromMiller(Miller miller)
        {
            Detail1 = miller.Detail1;
            miller.Detail1 = null;
        }
        /// <summary>
        /// Передать деталь фрезеровщику
        /// </summary>
        public void TransferDetailToMiller(Miller miller)
        {
            miller.Detail1 = Detail1;
            Detail1 = null;
        }
    }
}
