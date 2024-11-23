using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thread_button_piu_e_meno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void threadMeno (object sender,object a)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (true) {
                Thread.Sleep(1000);
                int valore = Convert.ToInt16(label1.Text);

                valore--;
                label1.Text=valore.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (true)
            {
                int valore = Convert.ToInt16(label1.Text);
                Thread.Sleep(1000);
                valore++;
                label1.Text = valore.ToString();
            }
        }

        private void threadMeno(object a)
        {
            button1_Click(a,new EventArgs());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread meno = new Thread(threadMeno);
            meno.Start();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
