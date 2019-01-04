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
    public class DrawMachine
    {
        public static void Draw(Graphics graphics, Machine machine)
        {
            graphics.FillRectangle(Brushes.Green, machine.X, machine.Y, machine.Width, machine.Height);
        }
        /// <summary>
        /// перегрузка Draw для рисования потоками
        /// </summary>
        /// <param name="args"></param>
        public static void Draw(object args)
        {
            lock (args)
            {
                ArgsDrawMachine DrawArgs = args as ArgsDrawMachine;
                if (DrawArgs != null)
                {
                    //каст прошёл успешно
                    Draw(DrawArgs.graphics, DrawArgs.machine);
                }
                else
                {
                    MessageBox.Show("Аргументы надо передать правильные");
                }
            }
        }
        public static void DrawInWork(Graphics graphics, Machine machine)
        {
            graphics.FillRectangle(Brushes.Red, machine.X, machine.Y, machine.Width, machine.Height);
        }
        /// <summary>
        /// перегрузка DrawInWork для рисования потоками
        /// </summary>
        /// <param name="args"></param>
        public static void DrawInWork(object args)
        {
            lock (args)
            {
                ArgsDrawMachine DrawArgs = args as ArgsDrawMachine;
                if (DrawArgs != null)
                {
                    //каст прошёл успешно
                    DrawInWork(DrawArgs.graphics, DrawArgs.machine);
                }
                else
                {
                    MessageBox.Show("Аргументы надо передать правильные");
                }
            }
        }
        public static void DrawMachines(Graphics graphics, List<Machine> machines)
        {
            if (machines.Count() > 0)
            {
                for (int i = 0; i < machines.Count(); i++)
                {
                    Draw(graphics, machines[i]);
                }
            }
        }
        /// <summary>
        /// перегрузка DrawNachines для рисования потоками
        /// </summary>
        /// <param name="args"></param>
        public static void DrawMachines(object args)
        {
            lock (args)
            {
                ArgsDrawMachine DrawArgs = args as ArgsDrawMachine;
                if (DrawArgs != null)
                {
                    //каст прошёл успешно
                    DrawMachines(DrawArgs.graphics, DrawArgs.machines);
                }
                else
                {
                    MessageBox.Show("Аргументы надо передать правильные");
                }
            }
        }
    }
}
