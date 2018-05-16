using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {
    class Program {
        static void Main(string[] args) {

            char c = 's';
            int numPlayers = 0;
            List<string> names = new List<string>();
            string name;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("BIENVENIDO AL BLACKJACK MIEDO");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            while (numPlayers < 1 || numPlayers > 7) {
                Console.Write("Type the number of players (1 - 7): ");
                numPlayers = Int32.Parse(Console.ReadLine());
                //agregar por si mete letras
            }

            Console.WriteLine();

            for(int i = 0; i < numPlayers; i++) {
                Console.Write("Type the player {0} name: ", i);
                name = Console.ReadLine();
                names.Add(name);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            Game Blackjack = new Game(names);
            while(c != 'n' && c !='N') {

                Blackjack.Play();
                Console.WriteLine();
                //ignore();
                Console.Write("Would you like to play again? [ y/n ] ");
                c = Convert.ToChar(Console.Read());
            }
        }
    }
}

/*
std::ostream& operator<<(std::ostream& os, const Carta& c) {
 const std::string CARTAS[] = { "0", "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
 const std::string PALOS[] = { "T", "D", "C", "E" };

 if (c.m_cartaArriba) {
  os << CARTAS[c.m_rango] << PALOS[c.m_palo];
 }
 else {
  os << "XX";
 }
 return os;
}

std::ostream& operator<<(std::ostream& os, const JugadorGenerico& jugador) {
 std::vector<Carta*>::const_iterator pCarta;
 
 os << jugador.m_nombre << ":\t";
 if (!jugador.m_cartas.empty()) {
  for (pCarta = jugador.m_cartas.begin(); pCarta != jugador.m_cartas.end(); ++pCarta) {
   os << *(*pCarta) << "\t";
  }
  if (jugador.getTotal() != 0) {
   std::cout << "(" << jugador.getTotal() << ")";
  }
 }
 else {
  os << "<Vacio>";
 }
 return os;
}
*/