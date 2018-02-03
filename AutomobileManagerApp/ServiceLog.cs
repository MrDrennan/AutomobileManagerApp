using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileManagerApp
{
    /// <summary>
    /// Represents service records for each type of service of each vehicle
    /// </summary>
    public class ServiceLog
    {
        public short ServiceLogId { get; set; }

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
