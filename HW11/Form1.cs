using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;

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
            Stopwatch watch2 = new Stopwatch();
            Random random = new Random();
            ArrayList myArrayList = new ArrayList();

            HW9A.DynamicStack<int> StackInst = new HW9A.DynamicStack<int>(bufferSize);
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
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label2.Text = this.LabelStackLink;
            this.label2.Refresh();

            watch2.Start();
            for (int i = 0; i < 10000; i++)
            {
                myArrayList.Add(999999/*random.Next()*/);
            }
            watch2.Stop();

            nanosecPerTick = (watch2.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label15.Text = this.LabelStackLink;
            this.label15.Refresh();
        }
        private void DynamicArrayQueue_click(object sender, EventArgs e)
        {
            int bufferSize = 10000;
            Stopwatch watch = new Stopwatch();
            Random random = new Random();
            Stopwatch watch2 = new Stopwatch();
            ArrayList myArrayList = new ArrayList();

            HW9A.DynamicQueue<int> QueueInst = new HW9A.DynamicQueue<int>(bufferSize);
            watch.Start();
            if (!QueueInst.IsFull())
            {
                for (int i = 0; i < 10000; i++)
                {
                    QueueInst.Enqueue(999999/*random.Next()*/);
                }
            }
            watch.Stop();

            long nanosecPerTick = (watch.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label5.Text = this.LabelStackLink;
            this.label5.Refresh();

            watch2.Start();
            for (int i = 0; i < 10000; i++)
            {
                myArrayList.Add(999999/*random.Next()*/);
            }
            watch2.Stop();

            nanosecPerTick = (watch2.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label27.Text = this.LabelStackLink;
            this.label27.Refresh();
        }
        private void ArrayBasedStack_Click(object sender, EventArgs e)
        {
            int[] bufferSize = new int[10000] ;
            Stack myStack = new Stack();
            Stopwatch watch1 = new Stopwatch();
            Stopwatch watch2 = new Stopwatch();
            Random random = new Random();

            HW7.MyStack<int> StackInst3 = new HW7.MyStack<int>(bufferSize);
            watch1.Start();
            if (!StackInst3.IsFull())
            {
                for (int i = 0; i < 10000; i++)
                {
                    StackInst3.Push(999999/*random.Next()*/);
                }
            }
            watch1.Stop();

            long nanosecPerTick = (watch1.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label1.Text = this.LabelStackLink;
            this.label1.Refresh();

            watch2.Start();
            for (int i = 0; i < 10000; i++)
            {
                myStack.Push(999999);
            }
            watch2.Stop();
            nanosecPerTick = (watch2.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label14.Text = this.LabelStackLink;
            this.label14.Refresh();
        }
        private void ArrayBasedQueue_Click(object sender, EventArgs e)
        {
            int[] bufferSize = new int[10000];
            Queue myQueue = new Queue();
            Stopwatch watch = new Stopwatch();
            Random random = new Random();
            Stopwatch watch2 = new Stopwatch();

            HW7.MyQueue<int> QueueInst1 = new HW7.MyQueue<int>(bufferSize);
            watch.Start();
            if (!QueueInst1.IsFull())
            {
                for (int i = 0; i < 10000; i++)
                {
                    QueueInst1.Enqueue(999999/*random.Next()*/);
                }
            }
            watch.Stop();

            long nanosecPerTick = (watch.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label4.Text = this.LabelStackLink;
            this.label4.Refresh();

            watch2.Start();
            for (int i = 0; i < 10000; i++)
            {
                myQueue.Enqueue(999999);
            }
            watch2.Stop();

            nanosecPerTick = (watch2.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label26.Text = this.LabelStackLink;
            this.label26.Refresh();
        }

        private void LinkedLitStack_Click(object sender, EventArgs e)
        {
            int bufferSize = 10000;
            Stopwatch watch = new Stopwatch();
            Stopwatch watch2 = new Stopwatch();
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
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label3.Text = this.LabelStackLink;
            this.label3.Refresh();

            LinkedList<int> list = new LinkedList<int>();
            watch2.Start();
            for (int i = 0; i < 10000; i++)
            {
                list.AddLast(999999/*random.Next()*/);
            }
            watch2.Stop();

            nanosecPerTick = (watch2.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label16.Text = this.LabelStackLink;
            this.label16.Refresh();
        }
        private void LinkedListQueue_Click(object sender, EventArgs e)
        {
           
            int bufferSize = 10000;
            Stopwatch watch = new Stopwatch();
            Random random = new Random();
            Stopwatch watch2 = new Stopwatch();

            HW9B.DynamicQueue<int> QueueInst3 = new HW9B.DynamicQueue<int>(bufferSize);

            watch.Start();
            if (!QueueInst3.IsFull())
            {
                for (int i = 0; i < 10000; i++)
                {
                    QueueInst3.Enqueue(999999/*random.Next()*/);
                }
            }
            watch.Stop();

            long nanosecPerTick = (watch.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label6.Text = this.LabelStackLink;
            this.label6.Refresh();

            LinkedList<int> list = new LinkedList<int>();
            watch2.Start();
            for (int i = 0; i < 10000; i++)
            {
                list.AddLast(999999/*random.Next()*/);
            }
            watch2.Stop();

            nanosecPerTick = (watch2.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label28.Text = this.LabelStackLink;
            this.label28.Refresh();
        }
        //---------------------  Popping -------------------------//
        private void ArrayStackPop_Click(object sender, EventArgs e)
        {
            int[] bufferSize = new int[10000];
            Stack myStack = new Stack();
            Stopwatch watch = new Stopwatch();
            Stopwatch watch2 = new Stopwatch();
            Random random = new Random();

            HW7.MyStack<int> StackInst3 = new HW7.MyStack<int>(bufferSize);

            if (!StackInst3.IsFull())
            {
                for (int i = 0; i < 10000; i++)
                {
                    StackInst3.Push(999999/*random.Next()*/);
                }
            }

            watch.Start();
            if (!StackInst3.IsEmpty())
            {
                for (int i = 0; i < 10000; i++)
                {
                    StackInst3.Pop();
                }
            }
            watch.Stop();

            long nanosecPerTick = (watch.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label10.Text = this.LabelStackLink;
            this.label10.Refresh();

            for (int i = 0; i < 10000; i++)
            {
                myStack.Push(999999);
            }
            watch2.Start();
            for (int i = 0; i < 10000; i++)
            {
                myStack.Pop();
            }
            watch2.Stop();
            nanosecPerTick = (watch2.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label19.Text = this.LabelStackLink;
            this.label19.Refresh();
        }
        private void ArrayQueuePop_Click(object sender, EventArgs e)
        {
            int[] bufferSize = new int[10000];
            Stopwatch watch = new Stopwatch();
            Random random = new Random();
            Queue myQueue = new Queue();
            Stopwatch watch2 = new Stopwatch();

            HW7.MyQueue<int> QueueInst1 = new HW7.MyQueue<int>(bufferSize);
            if (!QueueInst1.IsFull())
            {
                for (int i = 0; i < 10000; i++)
                {
                    QueueInst1.Enqueue(999999/*random.Next()*/);
                }
            }

            watch.Start();
            if (!QueueInst1.IsEmpty())
            {
                for (int i = 0; i < 10000; i++)
                {
                    QueueInst1.Dequeue();
                }
            }
            watch.Stop();

            long nanosecPerTick = (watch.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label13.Text = this.LabelStackLink;
            this.label13.Refresh();

            for (int i = 0; i < 10000; i++)
            {
                myQueue.Enqueue(999999);
            }
            watch2.Start();
            for (int i = 0; i < 10000; i++)
            {
                myQueue.Dequeue();
            }
            watch2.Stop();
            nanosecPerTick = (watch2.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label29.Text = this.LabelStackLink;
            this.label29.Refresh();
        }
        private void DynamicArrayStackPop_Click(object sender, EventArgs e)
        {
            int bufferSize = 10000;
            Stopwatch watch = new Stopwatch();
            Random random = new Random();
            Stopwatch watch2 = new Stopwatch();
            ArrayList myArrayList = new ArrayList();

            HW9A.DynamicStack<int> StackInst = new HW9A.DynamicStack<int>(bufferSize);
            if (!StackInst.IsFull())
            {
                for (int i = 0; i < 10000; i++)
                {
                    StackInst.Push(999999/*random.Next()*/);
                }
            }

            watch.Start();
            if (!StackInst.IsEmpty())
            {
                for (int i = 0; i < 10000; i++)
                {
                    StackInst.Pop();
                }
            }
            watch.Stop();

            long nanosecPerTick = (watch.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label9.Text = this.LabelStackLink;
            this.label9.Refresh();

            for (int i = 0; i < 10000; i++)
            {
                myArrayList.Add(999999/*random.Next()*/);
            }

            watch2.Start();
            for (int i = 10000; i > 0; i--)
            {
                myArrayList.Remove(999999);
                //myArrayList.Clear();
            }
            watch2.Stop();

            nanosecPerTick = (watch2.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label22.Text = this.LabelStackLink;
            this.label22.Refresh();
        }
        private void DynamicArrayQueuePop_Click(object sender, EventArgs e)
        {
            int bufferSize = 10000;
            Stopwatch watch = new Stopwatch();
            Random random = new Random();
            Stopwatch watch2 = new Stopwatch();
            ArrayList myArrayList = new ArrayList();

            HW9A.DynamicQueue<int> QueueInst = new HW9A.DynamicQueue<int>(bufferSize);
            if (!QueueInst.IsFull())
            {
                for (int i = 0; i < 10000; i++)
                {
                    QueueInst.Enqueue(999999/*random.Next()*/);
                }
            }

            watch.Start();
            if (!QueueInst.IsEmpty())
            {
                for (int i = 0; i < 10000; i++)
                {
                    QueueInst.Dequeue();
                }
            }
            watch.Stop();

            long nanosecPerTick = (watch.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label12.Text = this.LabelStackLink;
            this.label12.Refresh();

            for (int i = 0; i < 10000; i++)
            {
                myArrayList.Add(999999/*random.Next()*/);
            }

            watch2.Start();
            for (int i = 0; i < 10000; i++)
            {
                myArrayList.Remove(999999);
            }
            watch2.Stop();

            nanosecPerTick = (watch2.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label30.Text = this.LabelStackLink;
            this.label30.Refresh();
        }
        private void LinkedListStackPop_Click(object sender, EventArgs e)
        {
            int bufferSize = 10000;
            Stopwatch watch = new Stopwatch();
            Random random = new Random();
            Stopwatch watch2 = new Stopwatch();

            HW9B.DynamicStack<int> StackInst = new HW9B.DynamicStack<int>(bufferSize);
            if (!StackInst.IsFull())
            {
                for (int i = 0; i < 10000; i++)
                {
                    StackInst.Push(999999/*random.Next()*/);
                }
            }

            watch.Start();
            if (!StackInst.IsEmpty())
            {
                for (int i = 0; i < 10000; i++)
                {
                    StackInst.Pop();
                }
            }
            watch.Stop();

            long nanosecPerTick = (watch.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label8.Text = this.LabelStackLink;
            this.label8.Refresh();

            LinkedList<int> list = new LinkedList<int>();
            
            for (int i = 0; i < 10000; i++)
            {
                list.AddLast(999999/*random.Next()*/);
            }

            watch2.Start();
            for (int i = 0; i < 10000; i++)
            {
                list.RemoveLast();
            }
            watch2.Stop();

            nanosecPerTick = (watch2.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label23.Text = this.LabelStackLink;
            this.label23.Refresh();
        }
        private void LinkedListQueuePop_Click(object sender, EventArgs e)
        {
            int bufferSize = 10000;
            Stopwatch watch = new Stopwatch();
            Random random = new Random();
            Stopwatch watch2 = new Stopwatch();

            HW9B.DynamicQueue<int> QueueInst = new HW9B.DynamicQueue<int>(bufferSize);
            if (!QueueInst.IsFull())
            {
                for (int i = 0; i < 10000; i++)
                {
                    QueueInst.Enqueue(999999/*random.Next()*/);
                }
            }

            watch.Start();
            if (!QueueInst.IsEmpty())
            {
                for (int i = 0; i < 10000; i++)
                {
                    QueueInst.Dequeue();
                }
            }
            watch.Stop();

            long nanosecPerTick = (watch.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label11.Text = this.LabelStackLink;
            this.label11.Refresh();

            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < 10000; i++)
            {
                list.AddLast(999999/*random.Next()*/);
            }

            watch2.Start();
            for (int i = 0; i < 10000; i++)
            {
                list.RemoveFirst();
            }
            watch2.Stop();

            nanosecPerTick = (watch2.ElapsedTicks * 1000L * 1000L) / Stopwatch.Frequency;
            LabelStackLink = String.Format("{0}", nanosecPerTick);
            this.label31.Text = this.LabelStackLink;
            this.label31.Refresh();
        }
        //------------------------------------------------//
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
