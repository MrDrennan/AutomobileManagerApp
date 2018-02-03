using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileManagerApp
{
    /// <summary>
    /// Represents repair and upgrade records of a vehicle
    /// </summary>
    public class RepairUpgradeLog
    {
        public short RepairUpgradeLogId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        // TODO: Change this column to money data type in the database. Default to 0.
        public double? Cost { get; set; }

        /// <summary>
        /// Notes the user can write about each repair and upgrade
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Parts of each repair and upgrade that user can keep track of
        /// </summary>
        public List<Part> Parts { get; set; }

    }
}
