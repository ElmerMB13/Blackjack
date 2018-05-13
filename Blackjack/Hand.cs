using System;
using System.Collections.Generic;
using System.Linq; //
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Hand
    {
        private readonly List<Card> _cards;

        /// <summary>
        /// 
        /// </summary>
        public Hand()
        {
            _cards = new List<Card>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cart"></param>
        public void AddCard(Card cart)
        {
            _cards.Add(cart);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Clean()
        {
            _cards.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetTotal()
        {
            var total = 0;
            var hasAs = false;

            if (_cards.Count <= 0) return 0;
            if (_cards[0].getValue() == 0) return 0;

            foreach (var entry in _cards)
            {
                total += entry.getValue();
                hasAs = entry.getValue() == (int)Card.Range.AS;
            }

            if (hasAs && total <= 11)
                total += 10;

            return total;
        }
    }
}