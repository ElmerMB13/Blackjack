using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {
    class Program {
        static void Main(string[] args) {

            char c = 's';
            int numPlayers = 0; //initial defualt number of players
            List<string> names = new List<string>();
            string name;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("BIENVENIDO AL BLACKJACK MIEDO");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            while (numPlayers < 1 || numPlayers > 7) {
                Console.Write("Type the number of players (1 - 7): ");
                string nPlayers = Console.ReadLine();
                if(!int.TryParse(nPlayers, out numPlayers)) {
                    PrintColorMessage(ConsoleColor.Red, "Error, please enter a number. ");
                    continue;
                }
                numPlayers = Int32.Parse(nPlayers);
            }

            Console.WriteLine();

            for(int i = 0; i < numPlayers; i++) {
                Console.Write("Type the player {0} name: ", i);
                name = Console.ReadLine();
                names.Add(name);
                Console.WriteLine();
            }

            Console.WriteLine();

            Game Blackjack = new Game(names);
            while(c != 'n' && c !='N') {

                Blackjack.Play();
                Console.WriteLine();
                Console.Write("Would you like to play again? [ y/n ] ");
                c = Convert.ToChar(Console.Read());
            }
        }

        static void PrintColorMessage(ConsoleColor c, string message) {
            Console.ForegroundColor = c;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}