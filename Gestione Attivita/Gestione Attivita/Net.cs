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
    public partial class Net : MetroFramework.Forms.MetroForm
    {
        Thread t;
        string g = "";
        public Net()
        {
            InitializeComponent();
        }
        void start()
        {
            while (true)
                g = UpdateVisitor.GetNetInfo();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            PerformanceCounterCategory pcg = new PerformanceCounterCategory("Network Interface");
            string instance = pcg.GetInstanceNames()[0];
            PerformanceCounter pcsent = new PerformanceCounter("Network Interface", "Bytes Sent/sec", instance);
            PerformanceCounter pcreceived = new PerformanceCounter("Network Interface", "Bytes Received/sec", instance);
            prova.Text = "Bytes Sent: " + pcsent.NextValue() / 1024 + "\n";
            prova.Text += "Bytes Received: " + pcreceived.NextValue() / 1024;
        }
        private void Net_Load(object sender, EventArgs e)
        {
            timer.Start();
            t = new Thread(start);
            t.Start();
        }
    }
}
