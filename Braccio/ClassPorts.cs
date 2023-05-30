using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;

namespace Braccio
{
    public class ClassPorts
    {
        static public Dictionary<string, string> GetSerialPorts() 
        {
            Dictionary<string, string> portList = new Dictionary<string, string>();
            using (var searcher = new ManagementObjectSearcher("Select * from Win32_PnPEntity where Caption like '%COM%'"))
            {
                var portNames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());
                portNames.ToList().ForEach(name =>
                        portList.Add(name, ports.FirstOrDefault(port => port.Contains(name)))
                        );
            }
            return portList;
        }
    }
}
