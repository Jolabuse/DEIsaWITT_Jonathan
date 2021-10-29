using System;

namespace DEIsaWITT_Jonathan_Rock_Paper_Scissor
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            Console.WriteLine(r.Next()%3);
        }
    }
}