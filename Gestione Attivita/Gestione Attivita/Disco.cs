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
using System.Windows.Threading;

namespace Gestione_Attivita
{
    public partial class Disco : MetroFramework.Forms.MetroForm
    {
        Thread t;
        string g = "";
        DispatcherTimer Timer99 = new DispatcherTimer();
        public Disco()
        {
            InitializeComponent();
            Timer99.Tick += Timer99_Tick; // don't freeze the ui
            Timer99.Interval = new TimeSpan(0, 0, 0, 0, 1024);
            Timer99.IsEnabled = true;
        }
        void start()
        {
            while (true)
                g = UpdateVisitor.GetDisckInfo();
        }
        public PerformanceCounter myCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
        public Int32 j = 0;
        public void Timer99_Tick(System.Object sender, System.EventArgs e)
        {
            float fcpu = myCounter.NextValue();
            metroProgressBarDisco.Value = (int)fcpu;
            lblDisco.Text = string.Format("{0:0.00}%", fcpu);
            chart1.Series["DISCO"].Points.AddY(fcpu);
            lblInfo.Text = g;
        }
        private void Disco_Load(object sender, EventArgs e)
        {
            t = new Thread(start);
            t.Start();
        }
    }
}
