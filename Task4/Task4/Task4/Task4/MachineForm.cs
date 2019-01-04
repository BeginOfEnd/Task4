using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library4;
using System.Threading;

namespace Task4
{
    public partial class MachineForm : Form
    {
        List<Detail> details = new List<Detail>();
        List<Miller> millers = new List<Miller>();
        List<Loader> loaders = new List<Loader>();
        List<Machine> machines = new List<Machine>();
        List<Thread> threads = new List<Thread>();        
        int word;
        Graphics graphicsDetail;
        Graphics graphicsLoader;
        Graphics graphicsMachine;
        Graphics graphicsMiller;
        public static MachineForm instance;
        /// <summary>
        /// объект ArgsDrawLoader
        /// </summary>
        ArgsDrawLoader adl = new ArgsDrawLoader();
        /// <summary>
        /// объект ArgsDrawMachine
        /// </summary>
        ArgsDrawMachine adma = new ArgsDrawMachine();
        /// <summary>
        /// объект ArgsDrawMiller
        /// </summary>
        ArgsDrawMiller admi = new ArgsDrawMiller();
        /// <summary>
        /// объект ArgsDrawDetail
        /// </summary>
        ArgsDrawDetail add = new ArgsDrawDetail();
        

        public MachineForm()
        {
            InitializeComponent();
            graphicsDetail = this.CreateGraphics();
            graphicsLoader = this.CreateGraphics();
            graphicsMachine = this.CreateGraphics();
            graphicsMiller = this.CreateGraphics();
            instance = this;
        }
        private void MachineForm_Load(object sender, EventArgs e)
        {
            
        }
        private void MachineForm_Paint(object sender, PaintEventArgs e)
        {
            DrawAll();
        }

        private void DrawAll()
        {
            if (loaders.Count() > 0)
            {
                adl.graphics = graphicsLoader;
                adl.loaders = loaders;
                threads[0] = new Thread(new ParameterizedThreadStart(DrawLoader.DrawLoaders));
                threads[0].Start(adl);
            }
            if (machines.Count() > 0 && (threads.Count() < 2))
            {
                adma.graphics = graphicsMachine;
                adma.machines = machines;
                threads[0] = new Thread(new ParameterizedThreadStart(DrawMachine.DrawMachines));
                threads[0].Start(adma);
            }
            else if (machines.Count() > 0 && (threads.Count() >= 2))
            {
                adma.graphics = graphicsMachine;
                adma.machines = machines;
                threads[1] = new Thread(new ParameterizedThreadStart(DrawMachine.DrawMachines));
                threads[1].Start(adma);
            }
            if (millers.Count() > 0 && (threads.Count() < 3))
            {
                admi.graphics = graphicsMiller;
                admi.millers = millers;
                threads[0] = new Thread(new ParameterizedThreadStart(DrawMiller.DrawMillers));
                threads[0].Start(admi);
            }  
            else if (millers.Count() > 0 && (threads.Count() >= 3))
            {
                admi.graphics = graphicsMiller;
                admi.millers = millers;
                threads[2] = new Thread(new ParameterizedThreadStart(DrawMiller.DrawMillers));
                threads[2].Start(admi);
            }
            if (details.Count() > 0 && (threads.Count() < 4))
            {
                add.graphics = graphicsDetail;
                add.details = details;
                threads[0] = new Thread(new ParameterizedThreadStart(DrawDetail.DrawDetails));
                threads[0].Start(add);
            }
            else if (details.Count() > 0 && (threads.Count() >= 4))
            {
                add.graphics = graphicsDetail;
                add.details = details;
                threads[3] = new Thread(new ParameterizedThreadStart(DrawDetail.DrawDetails));
                threads[3].Start(add);
            }
        }

        private void AddLoaderButton_Click(object sender, EventArgs e)
        {
            int x = -1;
            int y = -1;
            int width = -1;
            if (int.TryParse(XBox.Text, out word))
            {
                word = Convert.ToInt32(XBox.Text);
                x = word;
            }
            word = -1;
            if (int.TryParse(YBox.Text, out word))
            {
                word = Convert.ToInt32(YBox.Text);
                y = word;
            }
            word = -1;
            if (int.TryParse(WidthBox.Text, out word))
            {
                word = Convert.ToInt32(WidthBox.Text);
                width = word;
            }
            word = -1;
            Loader loader;
            if ((millers.Count() > loaders.Count()) && ((loaders.Count()) > 0))
            {
                loader = new Loader(millers[loaders.Count() - 1].X + 100, millers[loaders.Count() - 1].Y, width, null);//погрузчик находится на одной прямой с фрезеровщиком
            }
            else if ((millers.Count() > loaders.Count()) && ((loaders.Count()) == 0))
            {
                loader = new Loader(millers[0].X + 100, millers[0].Y, width, null);
            }
            else
            {
                if (x < 200)
                {
                    x += 100;
                }
                if (y < 100)
                {
                    y += 50;
                }
                loader = new Loader(x, y, width, null);
            }
            loader.OldX = loader.X;
            loaders.Add(loader);
            int maxCount = 0;               
            maxCount = details.Count();
            if (machines.Count() > maxCount)
            {
                maxCount = machines.Count();
            }
            if (millers.Count() > maxCount)
            {
                maxCount = millers.Count();
            }
            if (loaders.Count() < maxCount)
            {
                while (loaders.Count() < maxCount)
                {
                    Random random = new Random();
                    x = random.Next(300, 450);
                    y = random.Next(300, 450);
                    width = random.Next(15, 30);
                    Loader loader1 = new Loader(x, y, width, null);
                    loaders.Add(loader1);
                }
            }
            else
            {
                maxCount = loaders.Count();
            }         
            if (threads.Count() < maxCount)
            {
                adl.graphics = graphicsLoader;
                adl.loader = loader;
                while (threads.Count() < maxCount)
                {
                    Thread thread = new Thread(new ParameterizedThreadStart(DrawLoader.Draw));
                    thread.Start(adl);
                    threads.Add(thread);
                }
            }
        }

        private void AddMachineButton_Click(object sender, EventArgs e)
        {
            int x = -1;
            int y = -1;
            int width = -1;
            int height = -1;
            if (int.TryParse(XBox.Text, out word))
            {
                word = Convert.ToInt32(XBox.Text);
                x = word;
            }
            else
            {
                x = 150;
            }
            word = -1;
            if (int.TryParse(YBox.Text, out word))
            {
                word = Convert.ToInt32(YBox.Text);
                y = word;
            }
            else
            {
                y = 150;
            }
            word = -1;
            if (int.TryParse(WidthBox.Text, out word))
            {
                word = Convert.ToInt32(WidthBox.Text);
                width = word;
            }
            word = -1;
            if (int.TryParse(HeightBox.Text, out word))
            {
                word = Convert.ToInt32(HeightBox.Text);
                height = word;
            }
            word = -1;
            Machine machine = new Machine(x, width, y, height);
            machines.Add(machine);
            int maxCount = 0;
            maxCount = details.Count();
            if (loaders.Count() > maxCount)
            {
                maxCount = machines.Count();
            }
            if (millers.Count() > maxCount)
            {
                maxCount = millers.Count();
            }
            if (machines.Count() < maxCount)
            {
                while (machines.Count() < maxCount)
                {
                    Random random = new Random();
                    x = random.Next(1, 300);
                    y = random.Next(1, 300);
                    width = random.Next(60, 100);
                    height = random.Next(20, 40);
                    Machine machine1 = new Machine(x, y, width, height);
                    machines.Add(machine1);
                }
            }
            else
            {
                maxCount = machines.Count();
            }      
            if (threads.Count() < maxCount)
            {
                adma.graphics = graphicsMachine;
                adma.machine = machine;
                while (threads.Count() < maxCount)
                {
                    Thread thread = new Thread(new ParameterizedThreadStart(DrawMachine.Draw));
                    thread.Start(adma);
                    threads.Add(thread);
                }
            }
        }
        private void AddMillerButton_Click(object sender, EventArgs e)
        {
            int x = -1;
            int y = -1;
            int width = -1;
            if (int.TryParse(XBox.Text, out word))
            {
                word = Convert.ToInt32(XBox.Text);
                x = word;
            }
            word = -1;
            if (int.TryParse(YBox.Text, out word))
            {
                word = Convert.ToInt32(YBox.Text);
                y = word;
            }
            word = -1;
            if (int.TryParse(WidthBox.Text, out word))
            {
                word = Convert.ToInt32(WidthBox.Text);
                width = word;
            }
            word = -1;
            Miller miller;
            if (machines.Count() > 0)
            {
                //фрезеровщик будет стоять приблизительно у середины станка
                miller = new Miller(machines[machines.Count() -1 ].X + (machines[machines.Count() - 1].Width) / 3, machines[machines.Count() - 1].Y + (machines[machines.Count() - 1].Height) + 10, width);
            }
            else
            {
                miller = new Miller(x, y , width);
            }
            millers.Add(miller);
            int maxCount = 0;
            maxCount = details.Count();
            if (loaders.Count() > maxCount)
            {
                maxCount = machines.Count();
            }
            if (machines.Count() > maxCount)
            {
                maxCount = millers.Count();
            }
            if (millers.Count() < maxCount)
            {
                while (millers.Count() < maxCount)
                {
                    Random random = new Random();
                    x = random.Next(1, 300);
                    y = random.Next(1, 300);
                    width = random.Next(15, 30);
                    Miller miller1 = new Miller(x, y, width);
                    millers.Add(miller1);
                }
            }
            else
            {
                maxCount = millers.Count();
            }        
            if (threads.Count() < maxCount)
            {
                admi.graphics = graphicsMiller;
                admi.miller = miller;
                while (threads.Count() < maxCount)
                {
                    Thread thread = new Thread(new ParameterizedThreadStart(DrawMiller.Draw));
                    thread.Start(admi);
                    threads.Add(thread);
                }
            }
        }

        private void AddDetailButton_Click(object sender, EventArgs e)
        {
            int x = -1;
            int y = -1;
            int width = -1;
            int height = -1;
            if (int.TryParse(XBox.Text, out word))
            {
                word = Convert.ToInt32(XBox.Text);
                x = word;
            }
            word = -1;
            if (int.TryParse(YBox.Text, out word))
            {
                word = Convert.ToInt32(YBox.Text);
                y = word;
            }
            word = -1;
            if (int.TryParse(WidthBox.Text, out word))
            {
                word = Convert.ToInt32(WidthBox.Text);
                width = word;
            }
            word = -1;
            if (int.TryParse(HeightBox.Text, out word))
            {
                word = Convert.ToInt32(WidthBox.Text);
                height = word;
            }
            word = -1;
            Detail detail = new Detail (x, width, y, height, false);
            int maxCount = 0;
            details.Add(detail);
            maxCount = loaders.Count();
            if (machines.Count() > maxCount)
            {
                maxCount = machines.Count();
            }
            if (millers.Count() > maxCount)
            {
                maxCount = millers.Count();
            }
            if (details.Count() < maxCount)
            {
                while (details.Count() < maxCount)
                {
                    Random random = new Random();
                    x = random.Next(200, 400);
                    y = random.Next(200, 400);
                    width = random.Next(3, 8);
                    height = random.Next(3, 8);
                    Detail detail1 = new Detail(x, width, y, height, false);
                    details.Add(detail1);
                }
            }
            else
            {
                maxCount = details.Count();
            }
            if (threads.Count() < maxCount)
            {
                add.graphics = graphicsDetail;
                add.detail = detail;
                while (threads.Count() < maxCount)
                {
                    Thread thread = new Thread(new ParameterizedThreadStart(DrawDetail.Draw));
                    thread.Start(add);
                    threads.Add(thread);
                }
            }
        }

        private void GiveAwayDetailBox_Click(object sender, EventArgs e)
        {
            int number = -1;
            if (int.TryParse(LoaderBox.Text, out word))
            {
                word = Convert.ToInt32(LoaderBox.Text);
                if ((word >= 0) && (word < loaders.Count()))
                {
                    if (!loaders[word].Detail1.IsReady)
                    {
                        number = word;
                        threads[number] = new Thread(new ParameterizedThreadStart(DrawLoader.DrawMovingToMiller));
                        adl.graphics = graphicsLoader;
                        adl.loader = loaders[number];
                        adl.miller = millers[number];
                        threads[number].Start(adl);
                        //threads[number] = new Thread(new ParameterizedThreadStart(DrawDetail.DrawBetweenLoaderAndMiller));
                        //add.graphics = graphicsDetail;
                        //add.detail = details[number];
                        //add.loader = loaders[number];
                        //threads[number].Start(add);
                        millers[number].Detail1 = loaders[number].Detail1;
                        loaders[number].Detail1 = null;
                        threads[number] = new Thread(new ParameterizedThreadStart(DrawLoader.DrawMovingFromMiller));
                        //adl.graphics = graphicsLoader;
                        //adl.loader = loaders[number];
                        //adl.miller = millers[number];
                        threads[number].Start(adl);
                        threads[number] = new Thread(new ParameterizedThreadStart(DrawDetail.DrawOnMachine));
                        add.graphics = graphicsDetail;
                        add.machine = machines[number];
                        add.detail = details[number];
                        threads[number].Start(add);
                        threads[number] = new Thread(new ParameterizedThreadStart(DrawMachine.DrawInWork));
                        adma.graphics = graphicsMachine;
                        adma.machine = machines[number];
                        threads[number].Start(adma);
                        machines[number].Work(details[number]);
                        Thread.Sleep(4000);
                    }
                }
            }            
        }

        private void TakeDetailBox_Click(object sender, EventArgs e)
        {
            int number = -1;
            if (int.TryParse(LoaderBox.Text, out word))
            {
                word = Convert.ToInt32(LoaderBox.Text);
                if ((word >= 0) && (word < loaders.Count()))
                {
                    number = word;
                    threads[number] = new Thread(new ParameterizedThreadStart(DrawLoader.DrawMovingToMiller));
                    adl.graphics = graphicsMiller;
                    adl.loader = loaders[number];
                    adl.miller = millers[number];
                    threads[number].Start(adl);
                    //threads[number] = new Thread(new ParameterizedThreadStart(DrawDetail.DrawBetweenLoaderAndMiller));
                    //add.graphics = graphicsDetail;
                    //add.detail = details[number];
                    //add.loader = loaders[number];
                    //threads[number].Start(add);
                    loaders[number].Detail1 = millers[number].Detail1;
                    millers[number].Detail1 = null;
                    threads[number] = new Thread(new ParameterizedThreadStart(DrawLoader.DrawMovingFromMiller));
                    adl.graphics = graphicsLoader;
                    adl.loader = loaders[number];
                    adl.miller = millers[number];
                    threads[number].Start(adl);
                }
            }            
        }

        

        private void DetailLoaderButton_Click(object sender, EventArgs e)
        {
            int numberOfLoader = -1;
            int numberOfDetail = -1;
            if (int.TryParse(LoaderBox.Text, out word))
            {
                word = Convert.ToInt32(LoaderBox.Text);
                if ((word >= 0) && (word < loaders.Count()))
                {
                    numberOfLoader = word;
                }
            }
            if (int.TryParse(DetailBox.Text, out word))
            {
                word = Convert.ToInt32(DetailBox.Text);
                if ((word >= 0) && (word < details.Count()))
                {
                    if (!details[word].IsReady)
                    {
                        numberOfDetail = word;
                    }
                }
            }
            if (numberOfLoader >= 0 && numberOfDetail >= 0)
            {
                loaders[numberOfLoader].Detail1 = details[numberOfDetail];
            }
        }
    }
}