using System;
using System.Collections.Generic;

namespace TeslaSelfDrivingSimulation.Models
{
    public enum CarStatus
    {
        Idle,
        InMission,
        Completed,
        CriticalFailure
    }

    public class AutonomousCar
    {
        public string CarId { get; set; }
        public double RangeKm { get; set; }
        public int BatteryPercentage { get; set; }
        public int MissionPriority { get; set; }
        public CarStatus Status { get; set; }
        public List<string> OperationLog { get; set; }

        public AutonomousCar()
        {
            OperationLog = new List<string>();
        }

        public void Validate()
        {
            if (BatteryPercentage < 0 || BatteryPercentage > 100)
                throw new Exception("Battery percentage must be between 0 and 100.");

            if (RangeKm <= 0)
                throw new Exception("Range must be greater than zero.");
        }
    }
}

