using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        string g = "";
        public Gestore()
        {
            InitializeComponent();
        }
        void start()
        {
            while (true)
                g = UpdateVisitor.GetCpuInfo();
        }
        const float sampleFrequencyMillis = 1000;

        protected object syncLock = new object();
        protected float lastSample;
        protected DateTime lastSampleTime;
        private void timer_Tick(object sender, EventArgs e)
        {
            //float fcpu = pCPU.NextValue();
            //metroProgressBarCpu.Value = (int)fcpu;
            //lblCpu.Text = string.Format("{0:0.00}%", fcpu);
            //chart1.Series["CPU"].Points.AddY(fcpu);
            gradi.Text = g;
            if ((DateTime.UtcNow - lastSampleTime).TotalMilliseconds > sampleFrequencyMillis)
            {
                lock (syncLock)
                {
                    if ((DateTime.UtcNow - lastSampleTime).TotalMilliseconds > sampleFrequencyMillis)
                    {
                        lastSample = pCPU.NextValue();
                        lastSampleTime = DateTime.UtcNow;
                    }
                }
            }
            metroProgressBarCpu.Value = (int)lastSample;
            lblCpu.Text = string.Format("{0:0.00}%", lastSample);
            chart1.Series["CPU"].Points.AddY(lastSample);
        }

        private void Gestore_Load(object sender, EventArgs e)
        {
            timer.Start();
            t = new Thread(start);
            t.Start();
        }
        private void btnRam_Click(object sender, EventArgs e)
        {
            Ram r = new Ram();
            t.Abort();
            Close();
            r.Show();
        }
        private void btnDisco_Click_1(object sender, EventArgs e)
        {
            Disco r = new Disco();
            t.Abort();
            Close();
            r.Show();
        }

        private void btnGpu_Click(object sender, EventArgs e)
        {
            Gpu r = new Gpu();
            t.Abort();
            Close();
            r.Show();
        }

        private void metroRete_Click(object sender, EventArgs e)
        {
            Net r = new Net();
            t.Abort();
            Close();
            r.Show();
        }
    }
}
