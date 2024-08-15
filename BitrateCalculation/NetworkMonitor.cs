using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitrateCalculation
{
    internal class NetworkMonitor
    {
        public static void CalculateBitrates(DeviceInfo deviceInfo, int pollingRateHz)
        {
            foreach (var nic in deviceInfo.NIC)
            {
                double pollingInterval = 1.0 / pollingRateHz; //in seconds
               
                double rxBitRate = nic.Rx * 8.0 / pollingInterval; //convert bytes to bits
                double txBirRate = nic.Tx * 8.0 / pollingInterval;

                Console.WriteLine($"NIC : {nic.Description}");
                Console.WriteLine($"Rx Bitrate : {rxBitRate} bps");
                Console.WriteLine($"Tx Bitrate : {txBirRate} bps");
            }
        }
    }
}
