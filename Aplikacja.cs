using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace Task_1727
{
    public partial class Aplikacja : Form
    {
        System.Timers.Timer t;
        int h, m, s;
        
        

        public Aplikacja()
        {
            InitializeComponent();
        }
      
        private void btnAdd(object sender, EventArgs e)
        {
           

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Podaj nazwę zadania", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
            }
            else
            {
                this.panel1.Visible = true;

                t = new System.Timers.Timer();
                t.Interval = 1000;
                t.Elapsed += OnTimeEvent;

                t.Start();
            }
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if(s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                time.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2,'0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }
                ));
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            t.Stop();
            Application.DoEvents();

            Zadanie z = new Zadanie();
            z.Show();
        }
    }
}
