using BitrateCalculation;
using System;
using Newtonsoft.Json;

namespace BitrateCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string givenJson= @"{
                                    'Device': 'Arista',
                                    'Model': 'X-Video',
                                    'NIC': [{
                                                'Description': 'Linksys ABR',
                                                'MAC': '14:91:82:3C:D6:7D',
                                                'Timestamp': '2020-03-23T18:25:43.511Z',
                                                'Rx': '3698574500',
                                                'Tx': '122558800'
                                              }]  
                                }";

            DeviceInfo deviceInfo = JsonConvert.DeserializeObject<DeviceInfo>(givenJson);
            NetworkMonitor.CalculateBitrates(deviceInfo, 2);
        }
    }
}