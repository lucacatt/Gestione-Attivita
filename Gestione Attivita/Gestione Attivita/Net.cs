using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestione_Attivita
{
    public partial class Net : MetroFramework.Forms.MetroForm
    {
        private NetworkInterface[] nicArr;
        public Net()
        {
            InitializeComponent();
            InitializeNetworkInterface();
            lblBytesSent.Text = "0";
            lblBytesReceived.Text = "0";
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateNetworkInterface();
        }
        private void Net_Load(object sender, EventArgs e)
        {

        }
        private void InitializeNetworkInterface()
        {
            nicArr = NetworkInterface.GetAllNetworkInterfaces();
            for (int i = 0; i < nicArr.Length; i++)
                cmbInterface.Items.Add(nicArr[i].Name);
            cmbInterface.SelectedIndex = 0;
        }

        private void UpdateNetworkInterface()
        {
            NetworkInterface nic = nicArr[cmbInterface.SelectedIndex];
            IPv4InterfaceStatistics interfaceStats = nic.GetIPv4Statistics();
            int bytesSentSpeed = Convert.ToInt32(interfaceStats.BytesSent - double.Parse(lblBytesSent.Text) / 1024);
            int bytesReceivedSpeed = Convert.ToInt32(interfaceStats.BytesReceived - double.Parse(lblBytesReceived.Text) / 1024);
            // Update the labels
            lblSpeed.Text = "Velocita " + nic.Speed.ToString();
            lblInterfaceType.Text = "Tipo di interfaccia " + nic.NetworkInterfaceType.ToString();
            lblSpeed.Text = "Velocita " + nic.Speed.ToString();
            lblBytesReceived.Text = interfaceStats.BytesReceived.ToString();
            lblBytesSent.Text = interfaceStats.BytesSent.ToString();
            lblUpload1.Text = bytesSentSpeed.ToString();
            lblDownload1.Text = bytesReceivedSpeed.ToString();
            chart1.Series["DOWNLOAD"].Points.AddY(lblDownload1.Text);
        }

        private void Net_Load_1(object sender, EventArgs e)
        {

        }
    }
}
