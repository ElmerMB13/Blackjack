using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {

    public class House : GenericPlayer {

        public House(string name = "House") : base(name) { }
        
        public override bool RequestCard() {
            return (GetTotal() <= 16);
        }

        public void FlipFirst() {
            if (_cards.Count() != 0)
                _cards[0].Flip();
            else
                Console.WriteLine("There are no cards to flip. ");
        }
    }
}