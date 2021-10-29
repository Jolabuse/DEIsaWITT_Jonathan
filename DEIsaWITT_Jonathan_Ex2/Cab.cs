using System;

namespace DEIsaWITT_Jonathan_Ex2
{
    public class Cab:AVehicle
    {
        public bool IsMoving { get; set; }
        public int WheelsCount { get; set; }
        public string Weight { get; set; }
        protected bool CanFly { get; set; }

        public Cab()
        {
            WheelsCount = 4;
            Weight = "middle";
            CanFly = false;
        }

        public override bool Drive()
        {
            Console.WriteLine("You're driving a Cab");
            IsMoving = true;
            return IsMoving;
        }

        public override bool Stop()
        {
            if (IsMoving)
            {
                Console.WriteLine("The Cab stops");
                IsMoving = false;
            }
            else
            {
                Console.WriteLine("The Cab never started");
            }

            return IsMoving;
        }
    }
}