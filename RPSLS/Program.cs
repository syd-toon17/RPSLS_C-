using System;

namespace RPSLS // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player one = new Player();

            one.name = "sydney";
            
            one.chosenGesture = "rock";
            one.wins = 3;

            Console.WriteLine(one.name + ' ' + one.chosenGesture);
            Console.ReadLine();

        }
    }
}