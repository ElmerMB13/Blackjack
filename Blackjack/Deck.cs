using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {

    public class Deck : Hand {

        private Random _rand;

        public Deck() {
            //_cards//.Capacity(52);

            _rand = new Random();
            FillDeck();
        }

        public void FillDeck() {
            Clean();
            for(int pal = (int)Card.Stick.CLUBS; pal <= (int)Card.Stick.SPADES; pal++) {
                for (int c = (int)Card.Range.AS; c <= (int)Card.Range.KING; c++)
                    AddCard(new Card((Card.Range)c, (Card.Stick)pal));
            }
        }

        public void GiveCard(Hand h) {

            if (base._cards.Count() != 0) {
                h.AddCard(base._cards.Last());
                _cards.RemoveAt(_cards.Count() - 1);
            }
            else {
                Console.WriteLine("There are no more cards left in the deck. ");
            }
        }

        public void Shuffle() {
            //var rand = new Random();
            var shuffledCards = _cards.OrderBy(item => _rand.Next());
            //std::random_shuffle(m_cartas.begin(), m_cartas.end());
        }

        public void ExtraCard(GenericPlayer p) {
            Console.WriteLine();

            while (!(p.Over21()) && p.RequestCard()) {
                GiveCard(p);
                p.PrintGPlayer();
                if (p.Over21()) p.Lost();
            }
        }

    }
}