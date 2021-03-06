using System;

namespace DEIsaWITT_Jonathan_Ex2
{
    public class Motorcycle : AVehicle
    {
        public bool IsMoving { get; set; }
        public int WheelsCount { get; set; }
        public string Weight { get; set; }
        protected bool CanFly { get; set; }

        public Motorcycle()
        {
            WheelsCount = 2;
            Weight = "light";
            CanFly = false;
        }

        public override bool Drive()
        {
            Console.WriteLine("You're driving a Motorcycle");
            IsMoving = true;
            return IsMoving;
        }

        public override bool Stop()
        {
            if (IsMoving)
            {
                Console.WriteLine("The Motorcycle stops");
                IsMoving = false;
            }
            else
            {
                Console.WriteLine("The Motorcycle never started");
            }

            return IsMoving;
        }
        
        public override void DisplayInfo()
        {
            Console.WriteLine("The motorcylce is Moving ?\n{0}",IsMoving);
            Console.WriteLine("The motorcycle can fly ?\n{0}",CanFly);
            Console.WriteLine("The motorcyle is {0} and have {1} wheels\n\n",Weight,WheelsCount);
        }
    }
    
}