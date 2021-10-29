using System;

namespace DEIsaWITT_Jonathan_Rock_Paper_Scissor
{
    class RPS
    {
        private Random r { get; set; } = new Random();
        private int NbWinComputer { get; set; } = 0;
        private int NbWinUser { get; set; } = 0;
        private string UserGuess { get; set; }
        private string ComputerGuess { get; set; }

        public void ComputerGuessing()
        {
            int guess = r.Next() % 3;
            switch (guess)
            {
                case 0:
                    ComputerGuess = "R";
                    break;
                case 1:
                    ComputerGuess = "P";
                    break;
                default:
                    ComputerGuess = "S";
                    break;
            }
        }

        public void UserGuessing()
        {
            string s = "";
            do
            {
                try
                {
                    Console.WriteLine("Enter R for rock, S for scissors or P for paper");
                    s = Console.ReadLine().ToUpper();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            } while (s != "R" && s != "P" && s != "S");

            UserGuess = s;
        }
        
        
        public bool? UserWin()
        {
            if (UserGuess == ComputerGuess)
            {
                return null;
            }
            if (UserGuess == "R")
            {
                if (ComputerGuess == "P")
                {
                    return false;
                }

                return true;
            }

            if (UserGuess == "P")
            {
                if (ComputerGuess == "S")
                {
                    return false;
                }

                return true;
            }

            if (ComputerGuess == "R" && UserGuess == "S")
                return false;
            return true;

        }

        static void Main(string[] args)
        {
            var game = new RPS();
            bool? userWin;
            while (game.NbWinUser <5 && game.NbWinComputer < 5)
            {
                game.ComputerGuessing();
                game.UserGuessing();
                Console.WriteLine("Computer : {0} vs User : {1}",game.ComputerGuess,game.UserGuess);
                userWin = game.UserWin();
                if (userWin == true)
                {
                    Console.WriteLine("user wins this round");
                    game.NbWinUser++;
                }
                else
                {
                    if (userWin == false)
                    {
                        Console.WriteLine("Computer wins this round");
                        game.NbWinComputer++;
                    }
                    else
                    {
                        Console.WriteLine("Equality");
                    }
                }
                Console.WriteLine("Computer : {0} vs User : {1}",game.NbWinComputer,game.NbWinUser);
            }

            if (game.NbWinUser ==5)
            {
                Console.WriteLine("User Wins");
            }
            else
            {
                Console.WriteLine("Computer Wins");
            }
        }

    }
}