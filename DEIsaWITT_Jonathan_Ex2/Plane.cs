using System;

namespace DEIsaWITT_Jonathan_Ex2
{
    public class Plane:AVehicle
    {
        public bool IsMoving { get; set; }
        public int WheelsCount { get; set; }
        public string Weight { get; set; }
        protected bool CanFly { get; set; }

        public Plane()
        {
            WheelsCount = 2;
            Weight = "heavy";
            CanFly = true;
        }

        public override bool Drive()
        {
            Console.WriteLine("You're driving a plane");
            IsMoving = true;
            return IsMoving;
        }

        public override bool Stop()
        {
            if (IsMoving)
            {
                Console.WriteLine("The plane stops");
                IsMoving = false;
            }
            else
            {
                Console.WriteLine("The plane never started");
            }

            return IsMoving;
        }
        
        public override void DisplayInfo()
        {
            Console.WriteLine("The plane is Moving ?\n{0}",IsMoving);
            Console.WriteLine("The plane can fly ?\n{0}",CanFly);
            Console.WriteLine("The plane is {0} and have {1} wheels\n\n",Weight,WheelsCount);
        }
    }
}