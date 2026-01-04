using System;
using System.Collections.Generic;
using System.Linq;
using TeslaSelfDrivingSimulation.Models;
using TeslaSelfDrivingSimulation.Exceptions;

namespace TeslaSelfDrivingSimulation.Controllers
{
    public delegate void VehicleAlert(string message);

    public class FleetController
    {
        public event VehicleAlert OnAlert;

        private List<AutonomousCar> cars = new List<AutonomousCar>();

        public void AddCar(AutonomousCar car)
        {
            car.Validate();
            cars.Add(car);
            OnAlert?.Invoke($"Car {car.CarId} added.");
        }
            public List<AutonomousCar> GetActiveCars()
        {
            return cars;
        }

        public void SimulateIncident(AutonomousCar car)
        {
            try
            {
                // simulate battery drain
                car.BatteryPercentage -= 30;

                if (car.BatteryPercentage < 20)
                    throw new BatteryFailureException("Critical battery failure.");

                car.Status = CarStatus.Completed;
                OnAlert?.Invoke($"Car {car.CarId} completed mission.");
            }
            catch (BatteryFailureException ex)
            {
                car.Status = CarStatus.CriticalFailure;
                OnAlert?.Invoke($"ALERT [{car.CarId}]: {ex.Message}");
            }
        }

    }
}
