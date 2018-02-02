using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileManagerApp
{
    /// <summary>
    /// Represents service records for each type of service of each vehicle
    /// </summary>
    class ServiceLog
    {
        public ushort ServiceLogID { get; set; }

        public DateTime Date { get; set; }

        public double? Cost { get; set; }

        /// <summary>
        /// notes the user can write about each service
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Parts for each service visit that user can keep track of
        /// </summary>
        public List<Part> Parts { get; set; }
    }
}
