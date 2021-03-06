﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {

    public class Game {

        private Random _random;
        private Deck m_deck;
        private House m_house;
        private List<Player> m_players;

        public Game(List<string> names) {

            m_players = new List<Player>();
            m_deck = new Deck();
            m_house = new House();

            foreach (var name in names) {
                m_players.Add(new Player(name));
            }

            _random = new Random();
            m_deck.FillDeck();
            m_deck.Shuffle();
        }

        public void Play() {

            BeginGame();
        }

        public void BeginGame() {

            for (int i = 0; i < 2; ++i) {//initially assigns 2 cards to each player and the House

                foreach (var player in m_players) {

                    m_deck.GiveCard(player);
                }
                m_deck.GiveCard(m_house);
            }
            ShowHand();
        }

        public void ShowHand() {

            m_house.FlipFirst();
            foreach (var player in m_players) {

                player.PrintGPlayer();
            }

            m_house.PrintGPlayer();

            OneMoreCard();
        }

        public void OneMoreCard() {

            foreach (var player in m_players) {

                m_deck.ExtraCard(player);
            }

            m_house.FlipFirst();
            m_house.PrintGPlayer();
            m_deck.ExtraCard(m_house);

            VerifyWinner();
        }

        public void VerifyWinner() {

            if (m_house.Over21()) {

                foreach (var player in m_players) {

                    if (!(player.Over21())) {
                        player.Win();
                    }
                }
            }

            else {
                foreach (var player in m_players) {
                    if (!(player.Over21())) {

                        if (player.GetTotal() > m_house.GetTotal()) {
                            player.Win();
                        }
                        else if (player.GetTotal() < m_house.GetTotal()) {

                            player.Lost();
                        }
                        else {
                            player.Push();
                        }
                    }
                }
            }
            Clean();
        }

        public void Clean() {

            foreach (var player in m_players) {

                player.Clean();
            }

            m_house.Clean();
        }
    }
}