namespace Coding_Lab_Project
{
            public enum Color{
                Red,
                Black};
        class Card{
                public int Value; // The amount each card is worth, A = 1, J = 11, Q = 12, K  13
                public string Suit;
                public Color color;

                public Card(int v, int s){
                    Value = v;

                    switch(s){
                        case 1:
                            Suit = "Heart";
                            color = Color.Red;
                            break;
                        case 2:
                            Suit = "Club";
                            color = Color.Black;
                            break;
                        case 3:
                            Suit = "Spade";
                            color = Color.Black;
                            break;
                        case 4:
                            Suit = "Diamonds";
                            color = Color.Red;
                            break;
                        default:
                            Suit = "N/A";
                            break;

                    }
                }
                public string DisplayCard(){
                    {
                        string temp;

                        switch (Value){
                            case 1:
                                temp = "Ace";
                                break;
                            case 11:
                                temp = "Jack";
                                break;
                            case 12:
                                temp = "Queen";
                                break;
                            case 13:
                                temp = "King";
                                break;
                            default:
                                temp = Value.ToString();
                                break;
                                
                                
                        }
                        return temp + " of " + Suit;
                    }
                }
            }
        }
