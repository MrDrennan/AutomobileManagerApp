using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileManagerApp
{
    /// <summary>
    /// Represents types of services that can be applied to vehicles
    /// </summary>
    class Service
    {
        public ushort ServiceID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public uint MileageInterval { get; set; }
        public byte MonthInterval { get; set; }
        // TODO: Can allow NextDueMileage or NextDueDate to be null but not both
        public uint? NextDueMileage { get; set; }
        public DateTime NextDueDate { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<ServiceLog> ServiceLog { get; set; }
    }
}
