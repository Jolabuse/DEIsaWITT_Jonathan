using System;

namespace DEIsaWITT_Jonathan_Ex2
{
    public interface IVehicule
    {
        bool IsMoving { get; set; }
        int WheelsCount { get; set; }
    }

    public abstract class AVehicle : IVehicule
    {
        public bool IsMoving { get; set; }
        public int WheelsCount { get; set; }
        protected bool CanFly { get; set; }
    
        public abstract bool Drive();
        public abstract bool Stop();
    }
    
}