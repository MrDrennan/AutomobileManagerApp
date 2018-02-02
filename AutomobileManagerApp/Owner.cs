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
    class Owner
    {
        public byte OwnerID { get; set; }

        public string Username { get; set; }

        public List<Vehicle> Vehicle { get; set; }
    }
}
