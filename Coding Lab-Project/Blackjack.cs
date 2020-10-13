using System;

namespace Coding_Lab_Project
{
    class Blackjack{
        static void Main(string[] args){
            Deck d = new Deck();

            for(int i = 1; i <= 4; i ++){
                for (int j = 1; j <= 13; j++){
                    Card c = new Card(j, i);

                    d.ListOfCards.Add(c);
                }
            }

           public class Player{
               Deck Hand;

               public Player{
                   Hand = new Deck
               }
           }

            public static class Game{
                public static string[] ids = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K"};

                
            }
            }
        }
        
        }
    }



