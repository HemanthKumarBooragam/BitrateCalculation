using System.Collections.Generic;

namespace BitrateCalculation
{
    internal class DeviceInfo
    {
        public string    Device { get; set; }
        public string    Model  { get; set; }
        public List<NIC> NIC    { get; set; }
    }

    public class NIC
    {
        public string   Description { get; set; }
        public string   MAC         { get; set; }
        public DateTime Timestamp   { get; set; }
        public long     Rx          { get; set; }
        public long     Tx          { get; set; }
    }
}
