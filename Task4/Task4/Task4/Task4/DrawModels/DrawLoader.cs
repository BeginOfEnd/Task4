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
    public class DrawLoader
    {
        public static void Draw(Graphics graphics, Loader loader)
        {
            graphics.FillRectangle(Brushes.Gray, loader.X, loader.Y, loader.Width, loader.Width);
        }
        /// <summary>
        /// перегрузка Draw для рисования потоками
        /// </summary>
        /// <param name="args"></param>
        public static void Draw(object args)
        {
            lock (args)
            {
                ArgsDrawLoader DrawArgs = args as ArgsDrawLoader;
                if (DrawArgs != null)
                {
                    //каст прошёл успешно
                    Draw(DrawArgs.graphics, DrawArgs.loader);
                }
                else
                {
                    MessageBox.Show("Аргументы надо передать правильные");
                }
            }
        }
        //погрузчик находится справа от фрезеровщика
        /// <summary>
        /// рисование погрузчика при движении К фрезеровщику
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="loader"></param>
        /// <param name="miller"></param>
        public static void DrawMovingToMiller(Graphics graphics, Loader loader, Miller miller)
        {
            while((loader.X - (miller.X + miller.Width) )>= 45)//погрузчик должен не вплотную подъехать
            {
                    loader.X -= 45;
                    graphics.Clear(MachineForm.instance.BackColor);
                    Draw(graphics, loader);
            }
        }
        /// <summary>
        /// перегрузка DrawMovingToMiller для рисования потоками
        /// </summary>
        /// <param name="args"></param>
        public static void DrawMovingToMiller(object args)
        {
            lock (args)
            {
                ArgsDrawLoader DrawArgs = args as ArgsDrawLoader;
                if (DrawArgs != null)
                {
                    //каст прошёл успешно
                    DrawArgs.graphics.Clear(MachineForm.instance.BackColor);
                    DrawMovingToMiller(DrawArgs.graphics, DrawArgs.loader, DrawArgs.miller);

                }
                else
                {
                    MessageBox.Show("Аргументы надо передать правильные");
                }
            }
        }
        /// <summary>
        /// рисование погрузчика при движении ОТ фрезеровщика
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="loader"></param>
        /// <param name="miller"></param>
        public static void DrawMovingFromMiller(Graphics graphics, Loader loader, Miller miller)
        {
            while ((loader.OldX - loader.X) >= 10)
            {
                    loader.X += 10;
                    graphics.Clear(MachineForm.instance.BackColor);
                    Draw(graphics, loader);
            }
            if (loader.OldX - loader.X < 10)
            {
                while(loader.OldX - loader.X > 0)
                {
                    loader.X += 1;
                    graphics.Clear(MachineForm.instance.BackColor);
                    Draw(graphics, loader);
                }
            }
        }
        /// <summary>
        /// перегрузка DrawMovigFromMiller для рисования потоками
        /// </summary>
        /// <param name="args"></param>
        public static void DrawMovingFromMiller(object args)
        {
            lock (args)
            {
                ArgsDrawLoader DrawArgs = args as ArgsDrawLoader;
                if (DrawArgs != null)
                {
                    //каст прошёл успешно
                    DrawMovingToMiller(DrawArgs.graphics, DrawArgs.loader, DrawArgs.miller);
                }
                else
                {
                    MessageBox.Show("Аргументы надо передать правильные");
                }
            }
        }
        public static void DrawLoaders(Graphics graphics, List<Loader> loaders)
        {
            if (loaders.Count() > 0)
            {
                for (int i = 0; i < loaders.Count(); i++)
                {
                    Draw(graphics, loaders[i]);
                }
            }
        }
        /// <summary>
        /// перегрузка DrawLoaders для рисования потоками
        /// </summary>
        /// <param name="args"></param>
        public static void DrawLoaders(object args)
        {
            lock (args)
            {
                ArgsDrawLoader DrawArgs = args as ArgsDrawLoader;
                if (DrawArgs != null)
                {
                    //каст прошёл успешно
                    DrawLoaders(DrawArgs.graphics, DrawArgs.loaders);
                }
                else
                {
                    MessageBox.Show("Аргументы надо передать правильные");
                }
            }
        }

    }
}
