using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestione_Attivita
{
    public partial class Gpu : MetroFramework.Forms.MetroForm
    {
        Thread t;
        string g = "";
        private const string DllFilePath = @"L:\github\Gestione-Attivita\Gestione Attivita\Gestione Attivita\bin\Debug\gpuUsage.dll";

        [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl)]
        private extern static int usage();

        public static int Uso()
        {
            return usage();
        }

        void start()
        {
            while (true)
                g = UpdateVisitor.GetGpuInfo();
        }
        public Gpu()
        {
            InitializeComponent();
        }

        private void Gpu_Load(object sender, EventArgs e)
        {
            timer.Start();
            t = new Thread(start);
            t.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = Uso();
            metroProgressBarGpu.Value = (int)fcpu;
            lblGpu.Text = string.Format("{0:0.00}%", fcpu);
            chart1.Series["GPU"].Points.AddY(fcpu);
            lblInfo.Text = g;
        }

        private void btnRam_Click(object sender, EventArgs e)
        {
            Ram r = new Ram();
            t.Abort();
            Close();
            r.Show();
        }
        private void btnDisco_Click(object sender, EventArgs e)
        {
            Disco r = new Disco();
            t.Abort();
            Close();
            r.Show();
        }

        private void btnGpu_Click(object sender, EventArgs e)
        {
            Gestore r = new Gestore();
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

