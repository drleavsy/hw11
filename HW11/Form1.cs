using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace HW11
{
    public partial class Form1 : Form
    {
        private string LabelNew;

        public Form1()
        {
            InitializeComponent();
        }

        public string LabelStackLink
        {
            get { return LabelNew; }
            private set { LabelNew = value; }
        }

        private void DynamicArrayStack_click(object sender, EventArgs e)
        {
            int bufferSize = 10000;
            Stopwatch watch = new Stopwatch();
            Random random = new Random();

            //HW9A.DynamicStack<int> StackInst = new HW9A.DynamicStack<int>(bufferSize);
            HW9A.DynamicStack<int> StackInst2 = new HW9A.DynamicStack<int>(bufferSize);
            watch.Start();
            if (!StackInst2.IsFull())
            {
                for (int i = 0; i < 10000; i++)
                {
                    StackInst2.Push(999999/*random.Next()*/);
                }
            }
            watch.Stop();

            long nanosecPerTick = (watch.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0} micro sec", nanosecPerTick);
            Console.WriteLine(String.Format("{0} ms", watch.ElapsedMilliseconds));
            this.label2.Text = this.LabelStackLink;
            this.label2.Refresh();
        }

        private void regularArray_Click(object sender, EventArgs e)
        {
            int[] bufferSize = new int[10000] ;
            Stopwatch watch = new Stopwatch();
            Random random = new Random();

            HW7.MyStack<int> StackInst3 = new HW7.MyStack<int>(bufferSize);
            watch.Start();
            if (!StackInst3.IsFull())
            {
                for (int i = 0; i < 10000; i++)
                {
                    StackInst3.Push(999999/*random.Next()*/);
                }
            }
            watch.Stop();

            long nanosecPerTick = (watch.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0} micro sec", nanosecPerTick);
            Console.WriteLine(String.Format("{0} ms", watch.ElapsedMilliseconds));
            this.label1.Text = this.LabelStackLink;
            this.label1.Refresh();
        }

        private void LinkedLitStack_Click(object sender, EventArgs e)
        {
            int bufferSize = 10000;
            Stopwatch watch = new Stopwatch();
            Random random = new Random();

            HW9B.DynamicStack<int> StackInst = new HW9B.DynamicStack<int>(bufferSize);

            watch.Start();
            if (!StackInst.IsFull())
            {
                for (int i = 0; i < 10000; i++)
                {
                    StackInst.Push(999999/*random.Next()*/);
                }
            }
            watch.Stop();

            long nanosecPerTick = (watch.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0} micro sec", nanosecPerTick);
            Console.WriteLine(String.Format("{0} ms", watch.ElapsedMilliseconds));
            this.label3.Text = this.LabelStackLink;
            this.label3.Refresh();
        }

        private void LinkedLitStackButton_Hover(object sender, EventArgs e)
        {
            this.LinkedListStack.BackColor = Color.LightGray;
        }
        private void LinkedLitStackButton_Leave(object sender, EventArgs e)
        {
            this.LinkedListStack.BackColor = Color.WhiteSmoke;
        }

        private void Exit_Hover(object sender, EventArgs e)
        {
            this.EXIT.BackColor = Color.LightGray;
        }
        private void Exit_Leave(object sender, EventArgs e)
        {
            this.EXIT.BackColor = Color.WhiteSmoke;
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Dispose(true);
            //return;
        }
    }
}
