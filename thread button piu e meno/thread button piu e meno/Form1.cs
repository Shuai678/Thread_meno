using System;
using System.Threading;
using System.Windows.Forms;

namespace thread_button_piu_e_meno
{
    public partial class Form1 : Form
    {
        private Thread thread1;
        private Thread thread2;
        private Thread thread3;
        private bool attivo1 = false;
        private bool attivo2 = false;
        private bool attivo3 = false;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "100";
            label2.Text = "100";
            label3.Text = "100";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked )
            {
                attivo1 = true;
                thread1 = new Thread(aggiornaLabel1);
                thread1.Start();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked && !attivo2)
            {
                attivo2 = true;
                thread2 = new Thread(aggiornaLabel2);
                thread2.Start();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                attivo3 = true;
                thread3 = new Thread(aggiornaLabel3);
                thread3.Start();
            }
        }

        private void aggiornaLabel1()
        {
            while (attivo1)
            {
                Thread.Sleep(1000);
                int valore = Convert.ToInt32(label1.Text);

                if (valore > 0)
                {
                    valore--;
                    label1.Text = valore.ToString();
                }
                else
                {
                    attivo1 = false;
                }
            }
        }

        private void aggiornaLabel2()
        {
            while (attivo2)
            {
                Thread.Sleep(1000);
                int valore = Convert.ToInt32(label2.Text);

                if (valore > 0)
                {
                    valore--;
                    label2.Text = valore.ToString();
                }
                else
                {
                    attivo2 = false; 
                }
            }
        }

        private void aggiornaLabel3()
        {
            while (attivo3)
            {
                Thread.Sleep(1000);
                int valore = Convert.ToInt32(label3.Text);

                if (valore > 0)
                {
                    valore--;
                    label3.Text = valore.ToString();
                }
                else
                {
                    attivo3 = false;
                }
            }
        }

    }
}
