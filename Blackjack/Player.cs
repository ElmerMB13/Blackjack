using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {

    public class Player : GenericPlayer {

        public Player(string name) : base(name) { }

        public bool RequestCard() {
            var answer = "";
            Console.WriteLine("{0} Would you like one more card? (Y/N): ", m_name);
            answer = Console.ReadLine();

            return (answer == "y" || answer == "Y");
        }

        public void Win() {
            Console.WriteLine("{0} wins", m_name);
        }

        public void Lost() {
            Console.WriteLine("{0} lost", m_name);
        }

        public void Push() {
            Console.WriteLine("{0} push", m_name);
        }
    }
}