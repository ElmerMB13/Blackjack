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

        public bool RequestCard() {
            var answer = "";
            Console.WriteLine("{0} Would you like one more card? (Y/N): ", m_name);
            answer = Console.ReadLine();

            return (answer == "y" || answer == "Y");
        }
    }
}
