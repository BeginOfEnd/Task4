using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Library4
{
    /// <summary>
    /// Станок
    /// </summary>
    public class Machine
    {
        /// <summary>
        /// Длина станка
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Ширина станка
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// Координата икс верхнего левого угла станка
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Координата игрек верхнего левого угла станка
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Если станок работает
        /// </summary>
        public bool IsWorks { get; set; }
        public Machine(int x, int width, int y, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
        public void Work(Detail detail)
        {
            detail.IsReady = true;
        }
    }
}
