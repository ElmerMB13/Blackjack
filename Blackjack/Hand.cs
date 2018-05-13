using System;
using System.Collections.Generic;
using System.Linq; //
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {

    public class Hand {

        protected readonly List<Card> _cards;

        public Hand() {
            _cards = new List<Card>();
        }

        public void AddCard(Card card) {
            _cards.Add(card);
        }

        public void Clean() {
            _cards.Clear();
        }

        public int GetTotal() {

            var total = 0;
            var hasAs = false;

            if (_cards.Count <= 0) return 0;
            if (_cards[0].GetValue() == 0) return 0;

            foreach (var entry in _cards) {
                total += entry.GetValue();
                hasAs = entry.GetValue() == (int)Card.Range.AS;
            }

            if (hasAs && total <= 10)
                total += 11;

            return total;
        }
    }
}