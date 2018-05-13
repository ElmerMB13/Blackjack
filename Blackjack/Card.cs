﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        public enum Range { AS = 1, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, JACK = 10, QEEN = 10, KING = 10 };
        public enum Stick { CLUBS, DIAMONDS, HEARTS, SPADES };

        private Range m_range;
        private Stick m_stick;
        private bool m_upCard;

        public Card(Range range, Stick stick, bool status)
        {
            m_range = range;
            m_stick = stick;
            m_upCard = status;
        }

        public int getValue()
        {
            int cardValue = 0;

            if (m_upCard) cardValue = Convert.ToInt32(m_range);

            return cardValue;
        }
    }
}
