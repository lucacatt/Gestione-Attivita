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

namespace Gestione_Attivita
{
    public partial class Gestore : MetroFramework.Forms.MetroForm
    {
        Thread t;
        public Gestore()
        {
            InitializeComponent();
        }
        void start()
        {
            while (true)
                gradi.Text = UpdateVisitor.GetCpuInfo();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            metroProgressBarCpu.Value = (int)fcpu;
            lblCpu.Text = string.Format("{0:0.00}%", fcpu);
            chart1.Series["CPU"].Points.AddY(fcpu);
        }

        private void Gestore_Load(object sender, EventArgs e)
        {
            t = new Thread(start);
            t.Start();
            timer.Start();
        }
        private void btnRam_Click(object sender, EventArgs e)
        {
            Ram r = new Ram();
            Close();
            r.Show();
        }
    }
}
