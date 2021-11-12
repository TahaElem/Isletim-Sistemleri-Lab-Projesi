using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_RAM
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();// form load ile timer çalışır



        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = Pcpu.NextValue();// Cpu anlık kullanılabilirliği
            float fram = Pram.NextValue();// Ram anlık kullanılabilirliği
            metroProgressBar_cpu.Value = (int)fcpu;
            metroProgressBar_ram.Value = (int)fram;
            lbl_cpu.Text = String.Format("{0:0.00}%", fcpu);// aldığımız veriyi % şeklinde gösterme
            lbl_ram.Text = String.Format("{0:0.00}%", fram);// aldığımız veriyi % şeklinde gösterme
            chart1.Series["CPU"].Points.AddY(fcpu);// Cpu performans değerini grafiğe yansıtma
            chart1.Series["RAM"].Points.AddY(fram);// Cpu performans değerini grafiğe yansıtma

        }
    }
}
