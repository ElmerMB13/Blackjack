using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {

    public class GenericPlayer : Hand {

        protected string m_name;

        public GenericPlayer(string name) {
            m_name = name;
        }

        public bool Over21() {
            return (GetTotal() > 21);
        }

        public void Lost() {
            Console.WriteLine(" Player {0} exceeded 21", m_name);
        }

        public virtual bool RequestCard() {
            var answer = "";
            Console.WriteLine("{0} Would you like a card? (Y/N): ", m_name);
            answer = Console.ReadLine();

            return (answer == "y" || answer == "Y");
        }

        public void PrintGPlayer() {

            Console.WriteLine(m_name);

            if (_cards.Count() != 0) {
                foreach (var card in _cards) {
                    card.PrintCard(card);
                }
                if (GetTotal() != 0)
                    Console.WriteLine(GetTotal());
            }
            else
                Console.WriteLine("Empty");
        }
    }
}
