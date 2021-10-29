using System;
namespace DEIsaWITT_Jonathan_Ex2
{
    public class Truck:AVehicle
    {
        public bool IsMoving { get; set; }
        public int WheelsCount { get; set; }
        public string Weight { get; set; }
        protected bool CanFly { get; set; }

        public Truck()
        {
            WheelsCount = 4;
            Weight = "heavy";
            CanFly = false;
        }

        public override bool Drive()
        {
            Console.WriteLine("You're driving a truck");
            IsMoving = true;
            return IsMoving;
        }

        public override bool Stop()
        {
            if (IsMoving)
            {
                Console.WriteLine("The truck stops");
                IsMoving = false;
            }
            else
            {
                Console.WriteLine("The truck never started");
            }

            return IsMoving;
        }
    }
}