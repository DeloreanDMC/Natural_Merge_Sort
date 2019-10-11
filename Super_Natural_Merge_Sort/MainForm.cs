using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Super_Natural_Merge_Sort
{
    public partial class MainForm : Form
    {
        // графический объект — некий холст
        Graphics g;
        NaturalMergeSortGUI elemList;
        Thread thread;
        Pen myPen = new Pen(Color.White);
        public MainForm()
        {
            InitializeComponent();
            Application.Idle += OnIdle;
            
            // привязка холста и задание размеров
            g = this.CreateGraphics();
            g.Clip = new Region(new Rectangle(new Point(0, 0), new Size(this.Width, this.Height)));
        }

       
        // при нажатии на кнопку "инициализировать"
        private void CreateButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
            if (InputTextBox.Text.Trim() == "")
            {
                elemList = new NaturalMergeSortGUI(13, g);
                elemList.RandomSet();
            }
            else
            {
                elemList = NaturalMergeSortGUI.StringToElemList(InputTextBox.Text, g);
                if (elemList == null)
                    MessageBox.Show("Неправильный формат ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                elemList.Display();
            }
            InputTextBox.Text = elemList.ToString();
        }

     
        // при наджатии на кнопку "отсортировать"
        private void button1_Click(object sender, EventArgs e)
        {
            if(elemList != null)
            {
                elemList.Speed = trackBar.Value;
                thread = new Thread(elemList.NaturalMergeSort);
                thread.Start();
            }
            else
                MessageBox.Show("Попытка отсортировать не созданную последовательность", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        
        // при передвижении ползунка скорости
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if(elemList != null)
            {
                if (thread != null && thread.IsAlive)

                if ( trackBar.Value == trackBar.Minimum)
                    thread.Suspend();
                else
                {
                    if (thread.ThreadState == ThreadState.Suspended) thread.Resume();
                }

                elemList.Speed = trackBar.Value;
                
            }
                
        }

        private void OnIdle(object sender, EventArgs e)
        {
            Sort.Enabled = CreateButton.Enabled = !(InputTextBox.ReadOnly = thread != null && thread.IsAlive);
        }
    }
}
