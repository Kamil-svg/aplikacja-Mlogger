using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1727
{
    public partial class Zadanie : Form
    {
        public Zadanie()
        {
            InitializeComponent();
        }

        private void Zadanie_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog opis = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames= true})
            {
                if(opis.ShowDialog() == DialogResult.OK)
                {
                    using(StreamWriter s = new StreamWriter(opis.FileName))
                    {
                        s.WriteLineAsync(textBox1.Text);
                    }
                }
            }

        }
    }
}
