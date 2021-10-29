using System;

namespace DEIsaWITT_Jonathan_Ex2
{
    public class Horse:AVehicle
    {
        public bool IsMoving { get; set; }
        public int WheelsCount { get; set; }
        public string Weight { get; set; }
        protected bool CanFly { get; set; }

        public Horse()
        {
            WheelsCount = 0;
            Weight = "light";
            CanFly = false;
        }

        public override bool Drive()
        {
            Console.WriteLine("You're driving a horse");
            IsMoving = true;
            return IsMoving;
        }

        public override bool Stop()
        {
            if (IsMoving)
            {
                Console.WriteLine("The horse stops");
                IsMoving = false;
            }
            else
            {
                Console.WriteLine("The horse never started");
            }

            return IsMoving;
        }
        
        public override void DisplayInfo()
        {
            Console.WriteLine("The horse is Moving ?\n{0}",IsMoving);
            Console.WriteLine("The horse can fly ?\n{0}",CanFly);
            Console.WriteLine("The horse is {0} and have {1} wheels\n\n",Weight,WheelsCount);
        }
    }
}