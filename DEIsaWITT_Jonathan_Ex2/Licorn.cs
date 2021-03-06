using System;

namespace DEIsaWITT_Jonathan_Ex2
{
    public class Licorn : AVehicle
    {
        public bool IsMoving { get; set; }
        public int WheelsCount { get; set; }
        public string Weight { get; set; }
        protected bool CanFly { get; set; }

        public Licorn()
        {
            WheelsCount = 0;
            Weight = "light";
            CanFly = true;
        }

        public override bool Drive()
        {
            Console.WriteLine("You're driving a licorn");
            IsMoving = true;
            return IsMoving;
        }

        public override bool Stop()
        {
            if (IsMoving)
            {
                Console.WriteLine("The licorn stops");
                IsMoving = false;
            }
            else
            {
                Console.WriteLine("The licorn never started");
            }

            return IsMoving;
        }
        
        
        public override void DisplayInfo()
        {
            Console.WriteLine("The licorn is Moving ?\n{0}",IsMoving);
            Console.WriteLine("The licorn can fly ?\n{0}",CanFly);
            Console.WriteLine("The licorn is {0} and have {1} wheels\n\n",Weight,WheelsCount);
        }
    }
}