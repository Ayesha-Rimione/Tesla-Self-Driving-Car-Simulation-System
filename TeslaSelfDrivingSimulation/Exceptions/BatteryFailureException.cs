using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaSelfDrivingSimulation.Exceptions
{
    public class BatteryFailureException : Exception
    {
        public BatteryFailureException(string message) : base(message) { }
    }
}

