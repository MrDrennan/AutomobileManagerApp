using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileManagerApp
{
    /// <summary>
    /// Represents parts installed in a vehicle for service visit upgrade or repair
    /// </summary>
    class Part
    {
        public ushort PartID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Cost { get; set; }

        public DateTime DatePurchased { get; set; }

        public string Warranty { get; set; }

        /// <summary>
        /// Notes about each part for the user
        /// </summary>
        public string Notes { get; set; }
    }
}
