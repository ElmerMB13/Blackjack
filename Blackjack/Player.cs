using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {

    public class Player : GenericPlayer {

        public Player(string name) : base(name) { }

        public void Win() {
            Console.WriteLine("{0} wins", m_name);
        }

        public void Loses() {
            Console.WriteLine("{0} loses", m_name);
        }

        public void Push() {
            Console.WriteLine("{0} push", m_name);
        }
    }
}