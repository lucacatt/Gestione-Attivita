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
    public partial class Ram : MetroFramework.Forms.MetroForm
    {
        Thread t;
        string g = "";
        public Ram()
        {
            InitializeComponent();
        }
        void start()
        {
            while (true)
                g = UpdateVisitor.GetRamInfo();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pRAM.NextValue();
            metroProgressBarRam.Value = (int)fcpu;
            lblRam.Text = string.Format("{0:0.00}%", fcpu);
            chart1.Series["RAM"].Points.AddY(fcpu);
            lblInfo.Text = g;
        }

        private void Ram_Load(object sender, EventArgs e)
        {
            timer.Start();
            t = new Thread(start);
            t.Start();
        }

        private void btnDisco_Click(object sender, EventArgs e)
        {
            Disco r = new Disco();
            Close();
            r.Show();
        }
        private void btnGpu_Click(object sender, EventArgs e)
        {
            Gpu r = new Gpu();
            Close();
            r.Show();
        }
        private void btnRete_Click(object sender, EventArgs e)
        {
            Net r = new Net();
            Close();
            r.Show();
        }

        private void btnCpu_Click(object sender, EventArgs e)
        {
            Gestore r = new Gestore();
            Close();
            r.Show();
        }
    }
}
