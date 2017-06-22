using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD47Gabriel_Can_Vidal_Programming1_a3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameRunning;
            gameRunning = true;

            Console.WriteLine("What a journey it was...");
            Console.WriteLine("You think to yourslef as you walk down the stairs of the arena.");
            Console.WriteLine("You never thought you would make it this far. Making so many friends and seeing so many Pokemons along the way.");
            Console.WriteLine("And so many enemies... Yeah like those Team Rocket morons. You wonder what happened to them.");
            Console.WriteLine("The last time you saw them they were in an explosion. You don't think anyone can survive that.");
            Console.WriteLine("But like some comedic relief or lazy writing they always come back. It's unnatural!");
            Console.WriteLine("What if that's it? What if your whole life is an animated japanese TV show for kids and really weird adults...");
            Console.WriteLine("Everything you have been through... Every challenge you faced... Every heartbreak...");
            Console.WriteLine("They were all some sick bastard's sense of fun? Did your life have any meaning at all?");
            Console.WriteLine("Is that why you are at the age of 10 for 20 years?");
            Console.WriteLine("You don't realise the footsteps behind you as you question your whole existence.");
            Console.WriteLine("\"Oh look it's that loser Ash!\" ");
            Console.WriteLine("You would recognise that annoying voice anywhere. It snaps you out of your little moment of enlightenment.");
            Console.WriteLine("You turn around to face your old nemesis Gary Oak.");
            Console.WriteLine("\"I thought they didn't let little kids in to this place. No matter you can be one of my cheerleaders\"");
            Console.WriteLine("Oh it is on!");


            petfight oGary = new petfight("Gary", 100, 60, 40);

            petfight oAsh = new petfight("Ash", 100, 50, 50);
            while (gameRunning)
            {



                newRound(oAsh, oGary);
                battle(oAsh, oGary);
                battleGary(oGary, oAsh);






                if (oGary.m_HitPoints == 0 || oAsh.m_HitPoints == 0)
                {
                    gameRunning = false;
                }

            }
            Console.WriteLine("WOW what a battle");
            Console.ReadLine();



        }
        static void battle(petfight attacker, petfight defender)
        {


            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1. Comeback(Attack)");
            Console.WriteLine("2. Take a deep breath(Heal)");

            Console.WriteLine("-------------------------------------------");
            string userInput = Console.ReadLine();
            int Input;

            bool success = int.TryParse(userInput, out Input);
            //Repeat untill the player uses a correct input.
            while (success == false || Input >= 6)
            {
                Console.WriteLine("That's not a valid option.");
                Console.WriteLine("Try again.");
                Console.ReadLine();

                break;
            }
            while (true)



                if (userInput == "1")
                {
                    attacker.attack(defender);
                    


                }
            if (userInput == "2")
            {
                attacker.Potion();
                


            }
           


        }
        static void battleGary(petfight attacker, petfight defender)
        {
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Surprise, Gary chooses to attack");
            attacker.attack(defender);
            Console.WriteLine("-------------------------------------------");
        }
        static void newRound(petfight ash, petfight gary)
        {
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Your Health: " + ash.m_HitPoints);
            Console.WriteLine("Enemy Health: " + gary.m_HitPoints);
            Console.WriteLine("-------------------------------------------");
        }
        
        
    }
}
