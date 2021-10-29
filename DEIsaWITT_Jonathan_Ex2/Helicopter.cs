using System;

namespace DEIsaWITT_Jonathan_Ex2
{
    public class Helicopter:AVehicle
    {
        public bool IsMoving { get; set; }
        public int WheelsCount { get; set; }
        public string Weight { get; set; }
        protected bool CanFly { get; set; }

        public Helicopter()
        {
            WheelsCount = 0;
            Weight = "heavy";
            CanFly = true;
        }

        public override bool Drive()
        {
            Console.WriteLine("You're driving a helicopter");
            IsMoving = true;
            return IsMoving;
        }

        public override bool Stop()
        {
            if (IsMoving)
            {
                Console.WriteLine("The helicopter stops");
                IsMoving = false;
            }
            else
            {
                Console.WriteLine("The helicopter never started");
            }

            return IsMoving;
        }
    }
}