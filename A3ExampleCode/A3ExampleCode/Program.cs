using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3ExampleCode
{
    class Program
    {
        public Ball ballOne = new Ball();
        public Ball ballTwo = new Ball();

        static void Main(string[] args)
        {
            Program menu = new Program;
            bool playerTurn = true;

            menu.StartMenu(playerTurn);
        }

        public void StartMenu(bool playerTurn)
        {
            Console.WriteLine("### WELCOME TO MY GAME ### \n" + "### IN THIS TWO PLAYER GAME, YOUR GOAL IS TO KILL THE OPPONENT ### \n");
            if (playerTurn == true)
            {
                Console.WriteLine("Player 1, input your ball name, health and attacks...");
                Console.WriteLine("What is the balls name?");
                ballOne.BallName = Console.ReadLine();
                Console.WriteLine("What is your balls total health?");
                ballOne.BallHealth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is your balls first attack name?");
                ballOne.BallAttackOneName = Console.ReadLine();
                Console.WriteLine("What is the first attack's damage?");
                ballOne.BallAttackOneDamage = Convert.ToInt32(Console.ReadLine());
            }
            if (playerTurn == false)
            {
                Console.WriteLine("Player 2, input your ball name, health and attacks...");
                Console.WriteLine("What is the balls name?");
                ballTwo.BallName = Console.ReadLine();
            }
        }
    }
}
