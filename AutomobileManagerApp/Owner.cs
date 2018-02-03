using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileManagerApp
{
    /// <summary>
    /// Represents an Owner of vehicles
    /// </summary>
    public class Owner
    {
        public byte OwnerId { get; set; }

        public string Username { get; set; }

        public List<Vehicle> Vehicle { get; set; }
    }
}
