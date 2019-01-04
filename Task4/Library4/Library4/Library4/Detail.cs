using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library4
{
    public class Detail
    {
        /// <summary>
        /// Высота детали
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Ширина детали
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// Координата икс верхнего левого угла детали
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Координата игрек верхнего левого угла детали
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// "Степень готовности" детали-если true, значит, деталь готова, если false-не готова
        /// </summary>
        public bool IsReady { get; set; }
        public Detail(int x, int width, int y, int height, bool isReady)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            IsReady = isReady;
        }
    }
}
