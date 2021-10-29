using System;

namespace DEIsaWITT_Jonathan
{
    class Factorial
    {

        private int answer { get; set; } = 1;
        
        public Factorial(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                answer *= i;
            }
        }
        
        static void Main(string[] args)
        {
            string s= "";
            Factorial f ;
            int n=-1;
            do
            {
                try
                {
                    do
                    {
                        Console.WriteLine("Enter an int<100");
                        n = Convert.ToInt32(Console.ReadLine());
                    } while (n<0 || n >99);

                    f = new Factorial(n);
                    Console.WriteLine(f.answer);
                    Console.WriteLine("Enter q to quit");
                    s = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (s != "q");
            
        }
    }
}