using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileManagerApp
{
    /// <summary>
    /// Represents repair and upgrade records of a vehicle
    /// </summary>
    class RepairUpgradeLog
    {
        public ushort RepairUpgradeLogID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        // TODO: Change this column to money data type in the database. Default to 0.
        public double Cost { get; set; }
        // Notes the user can write about each repair and upgrade
        public string Notes { get; set; }
        // Parts of each repair and upgrade that user can keep track of
        public List<Part> Parts { get; set; }

    }
}
