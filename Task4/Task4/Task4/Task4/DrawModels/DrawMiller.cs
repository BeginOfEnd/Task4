using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library4;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Task4
{
    public class DrawMiller
    {
        public static void Draw(Graphics graphics, Miller miller)
        {
            graphics.FillEllipse(Brushes.Brown, miller.X, miller.Y, miller.Width, miller.Width);
        }
        /// <summary>
        /// перегрузка Draw для рисования потоками
        /// </summary>
        /// <param name="args"></param>
        public static void Draw(object args)
        {
            lock (args)
            {
                ArgsDrawMiller DrawArgs = args as ArgsDrawMiller;
                if (DrawArgs != null)
                {
                    //каст прошёл успешно
                    Draw(DrawArgs.graphics, DrawArgs.miller);
                }
                else
                {
                    MessageBox.Show("Аргументы надо передать правильные");
                }
            }
        }
        public static void DrawMillers(Graphics graphics, List<Miller> millers)
        {
            if (millers.Count() > 0)
            {
                for (int i = 0; i < millers.Count(); i++)
                {
                    Draw(graphics, millers[i]);
                }
            }
        }
        /// <summary>
        /// перегрузка DrawMillers для рисования потоками
        /// </summary>
        /// <param name="args"></param>
        public static void DrawMillers(object args)
        {
            lock (args)
            {
                ArgsDrawMiller DrawArgs = args as ArgsDrawMiller;
                if (DrawArgs != null)
                {
                    //каст прошёл успешно
                    DrawMillers(DrawArgs.graphics, DrawArgs.millers);
                }
                else
                {
                    MessageBox.Show("Аргументы надо передать правильные");
                }
            }
        }
    }
}
