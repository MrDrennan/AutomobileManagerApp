using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileManagerApp
{
    /// <summary>
    /// Represents a Vehicle that can be tracked by an owner
    /// </summary>
    class Vehicle
    {
        public string VIN { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        //TODO: Make datetime only accept year component
        public DateTime Year { get; set; }

        public string Engine { get; set; }

        public uint Mileage { get; set; }

        public List<Service> Service { get; set; }

        public List<RepairUpgradeLog> RepairUpgradeLog { get; set; }
    }
}
