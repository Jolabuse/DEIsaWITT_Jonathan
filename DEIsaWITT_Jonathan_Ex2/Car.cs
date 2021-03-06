using System;

namespace DEIsaWITT_Jonathan_Ex2
{
    public class Car : AVehicle
    {
        public bool IsMoving { get; set; }
        public int WheelsCount { get; set; }
        public string Weight { get; set; }
        protected bool CanFly { get; set; }

        public Car()
        {
            WheelsCount = 4;
            Weight = "middle";
            CanFly = false;
        }

        public override bool Drive()
        {
            Console.WriteLine("You're driving a car");
            IsMoving = true;
            return IsMoving;
        }

        public override bool Stop()
        {
            if (IsMoving)
            {
                Console.WriteLine("The car stops");
                IsMoving = false;
            }
            else
            {
                Console.WriteLine("The car never started");
            }

            return IsMoving;
        }
        
        public override void DisplayInfo()
        {
            Console.WriteLine("The car is Moving ?\n{0}",IsMoving);
            Console.WriteLine("The car can fly ?\n{0}",CanFly);
            Console.WriteLine("The car is {0} and have {1} wheels\n\n",Weight,WheelsCount);
        }
        
    }
}