using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library4;
using System.Drawing;
using System.Windows.Forms;

namespace Task4
{
    public class DrawDetail
    {
        public static void Draw(Graphics graphics, Detail detail)
        {
            graphics.FillRectangle(Brushes.Black, detail.X, detail.Y, detail.Width, detail.Height);
        }
        /// <summary>
        /// перегрузка Draw для рисования потоками
        /// </summary>
        /// <param name="args"></param>
        public static void Draw(object args)
        {
            lock (args)
            {
                ArgsDrawDetail DrawArgs = args as ArgsDrawDetail;
                if (DrawArgs != null)
                {
                    //каст прошёл успешно
                    Draw(DrawArgs.graphics, DrawArgs.detail);
                }
                else
                {
                    MessageBox.Show("Аргументы надо передать правильные");
                }
            }
        }
        public static void DrawOnMachine(Graphics graphics, Detail detail, Machine machine)
        {
            detail.X = machine.X + machine.Width / 2;
            detail.Y = machine.Y + machine.Height / 2;
            Draw(graphics, detail);
        }
        /// <summary>
        /// перегрузка DrawOnMachine для рисования потоками
        /// </summary>
        /// <param name="args"></param>
        public static void DrawOnMachine(object args)
        {
            lock (args)
            {
                ArgsDrawDetail DrawArgs = args as ArgsDrawDetail;
                if (DrawArgs != null)
                {
                    //каст прошёл успешно
                    DrawOnMachine(DrawArgs.graphics, DrawArgs.detail, DrawArgs.machine);
                }
                else
                {
                    MessageBox.Show("Аргументы надо передать правильные");
                }
            }
        }
        //public static void DrawBetweenLoaderAndMiller(Graphics graphics, Detail detail, Loader loader)
        //{
        //    detail.X = loader.X - 12;
        //    detail.Y = loader.Y;
        //    Draw(graphics, detail);
        //}
        /// <summary>
        /// перегрузка DrawBetweenLoaderAndMiller для рисования потоками
        /// </summary>
        /// <param name="args"></param>
        //public static void DrawBetweenLoaderAndMiller(object args)
        //{
        //    lock (args)
        //    {
        //        ArgsDrawDetail DrawArgs = args as ArgsDrawDetail;
        //        if (DrawArgs != null)
        //        {
        //            //каст прошёл успешно
        //            DrawBetweenLoaderAndMiller(DrawArgs.graphics, DrawArgs.detail, DrawArgs.loader);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Аргументы надо передать правильные");
        //        }
        //    }
        //}
        public static void DrawDetails(Graphics graphics, List<Detail> details)
        {
            if (details.Count() > 0)
            {
                for (int i = 0; i < details.Count(); i++)
                {
                    Draw(graphics, details[i]);
                }
            }
        }
        /// <summary>
        /// перегрузка DrawDetails для рисования потоками
        /// </summary>
        /// <param name="args"></param>
        public static void DrawDetails(object args)
        {
            lock (args)
            {
                ArgsDrawDetail DrawArgs = args as ArgsDrawDetail;
                if (DrawArgs != null)
                {
                    //каст прошёл успешно
                    DrawDetails(DrawArgs.graphics, DrawArgs.details);
                }
                else
                {
                    MessageBox.Show("Аргументы надо передать правильные");
                }
            }
        }
    }
}
