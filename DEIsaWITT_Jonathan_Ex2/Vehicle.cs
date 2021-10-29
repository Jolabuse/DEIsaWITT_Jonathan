using System;
using System.Collections.Generic;

namespace DEIsaWITT_Jonathan_Ex2
{
    public interface IVehicule
    {
        bool IsMoving { get; set; }
        int WheelsCount { get; set; }

        public abstract void DisplayInfo();
    }

    public abstract class AVehicle : IVehicule
    {
        public bool IsMoving { get; set; }
        public int WheelsCount { get; set; }
        public string Weight { get; set; }
        protected bool CanFly { get; set; }
    
        public abstract bool Drive();
        public abstract bool Stop();

        public abstract void DisplayInfo();
    }

    public class Vehicles
    {
        static void Main(string[] args)
        {
            List<AVehicle> vehicles = new List<AVehicle>();
            vehicles.Add(new Motorcycle());
            vehicles.Add(new Car());
            vehicles.Add(new Cab());
            vehicles.Add(new Helicopter());
            vehicles.Add(new Truck());
            vehicles.Add(new Plane());
            vehicles.Add(new Horse());
            vehicles.Add(new Licorn());

            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
            }
            
            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayInfo();
            }

            foreach (var vehicle in vehicles)
            {
                vehicle.Stop();
            }
        }
    }


}