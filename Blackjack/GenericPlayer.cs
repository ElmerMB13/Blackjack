using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class GenericPlayer : Hand
    {
        protected string m_name;

        public GenericPlayer(string name) {
            m_name = name;
        }

        public bool over21() {
            return (GetTotal() > 21);
        }

        public void lose() {
            Console.WriteLine(" Player {0} exceeded 21", m_name);
        }
    }
}
