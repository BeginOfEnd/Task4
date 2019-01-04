using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library4
{
    /// <summary>
    /// Фрезеровщик
    /// </summary>
    public class Miller
    {
        /// <summary>
        /// Ширина фрезеровщика
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// Координата икс центра окружности
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Координата игрек центра окружности
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Станок, за которым работает фрезеровщик
        /// </summary>
        public  Machine machine { get; set; }
        /// <summary>
        /// Деталь, с которой работает фрезеровщик
        /// </summary>
        public Detail Detail1 { get; set; }
        public Miller(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Width = radius;
        }
        public void Work()
        {
            machine.Work(Detail1);
        }
    }
}
