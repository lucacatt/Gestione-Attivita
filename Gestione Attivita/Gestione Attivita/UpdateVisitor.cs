using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Attivita
{
    public class UpdateVisitor : IVisitor
    {
        public void VisitComputer(IComputer computer)
        {
            computer.Traverse(this);
        }

        public void VisitHardware(IHardware hardware)
        {
            hardware.Update();
            foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
        }

        public void VisitSensor(ISensor sensor) { }
        public void VisitParameter(IParameter parameter) { }

        public static string GetCpuInfo()
        {
            string tutto = "";
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject mo in mos.Get())
            {
                tutto = mo["Name"].ToString() + "\n";
            }

            UpdateVisitor updateVisitor = new UpdateVisitor();
            Computer computer = new Computer();
            computer.Open();
            computer.CPUEnabled = true;
            computer.Accept(updateVisitor);
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                            tutto += computer.Hardware[i].Sensors[j].Name + ": " + computer.Hardware[i].Sensors[j].Value.ToString() + "\r";
                    }
                }
            }
            computer.Close();
            return tutto;
        }
        public static string GetGpuInfo()
        {
            string tutto = "";
            ManagementObjectSearcher moss = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
            foreach (ManagementObject moo in moss.Get())
            {
                tutto += moo["Name"].ToString() + "\n";
            }

            UpdateVisitor updateVisitor = new UpdateVisitor();
            Computer computer = new Computer();
            computer.Open();
            computer.GPUEnabled = true;
            computer.Accept(updateVisitor);
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.GpuNvidia)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                            tutto += computer.Hardware[i].Sensors[j].Name + ": " + computer.Hardware[i].Sensors[j].Value.ToString() + "\r";
                    }
                }
                else if (computer.Hardware[i].HardwareType == HardwareType.GpuAti)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                            tutto += computer.Hardware[i].Sensors[j].Name + ": " + computer.Hardware[i].Sensors[j].Value.ToString() + "\r";
                    }
                }
            }
            computer.Close();
            return tutto;
        }
        public static string GetDisckInfo()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            string tutto = "";
            foreach (DriveInfo d in allDrives)
            {
                tutto += "Drive " + d.Name + "\n";
                tutto += "Drive " + d.DriveType + "\n";
                if (d.IsReady == true)
                {
                    tutto +=
                        "  Available space to current user: GB" +
                        Convert.ToInt32(d.AvailableFreeSpace / 1000000000) + "\n";

                    tutto +=
                        "  Total available space: GB" +
                        Convert.ToInt32(d.TotalFreeSpace / 1000000000) + "\n";

                    tutto +=
                       "  Total size of drive: GB " +
                        Convert.ToInt32(d.TotalSize / 1000000000) + "\n";
                }
            }
            return tutto;
        }
        public static string GetNetInfo()
        {
            //rete
            string tutto = "";
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in interfaces)
            {
                tutto += "Name: " + adapter.Name + "\n";
                tutto += adapter.Description + "\n";
                tutto += String.Empty.PadLeft(adapter.Description.Length, '=') + "\n";
                tutto += "  Interface type: " + adapter.NetworkInterfaceType + "\n";
                tutto += "  Operational status : " + adapter.OperationalStatus + "\n";
                string versions = "";

                // Create a display string for the supported IP versions.
                if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                {
                    versions = "IPv4";
                }
                if (adapter.Supports(NetworkInterfaceComponent.IPv6))
                {
                    if (versions.Length > 0)
                    {
                        versions += " ";
                    }
                    versions += "IPv6";
                }
                tutto += "  IP version .............................. :" + versions;
            }
            return tutto;
        }
    }
}
