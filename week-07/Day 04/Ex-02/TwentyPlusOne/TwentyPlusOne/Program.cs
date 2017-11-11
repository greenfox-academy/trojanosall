﻿using System;

namespace TwentyPlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Twenty Plus One
            //Create the beloved Twenty Plus One game!
            //    Create a Card, a Deck, and a Game class
            //The Card class has 3 enum properties :
            //One for the color(red, black)
            //One for the suit(clubs, diamonds, hearts, spades)
            //One for the rank(2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A)
            //The Deck class holds the instances of the Card classes
            //    Create methods for the class
            //c# ShuffleDeck, PullFirst, PullLast, PullRandom
            //java shuffleDeck, pullFirst, pullLast, pullRandom
            //The Game class is responsible to the game itself
            //    It should have a method that generates a random number between 15 and 21, which will be the opponents score
            //It should ask the player to continue or to stop drawing cards
            //    The game is lost, if the sum of the pulled cards are above 21 or below the random number

            //var myCar = new Card(SuitEnum.Clubs, RankEnum.Queen);

            //Console.WriteLine(myCar.CardSuit);
            //Console.WriteLine(myCar.CardRank);
            //Console.WriteLine(myCar.CardName);
            //Console.WriteLine(myCar.CardValue);

            var myDeck = new Deck();

            var FirstPulledCar = myDeck.PullFirst(myDeck.ShuffleDeck(myDeck.GenerateMyDeck()));

            

            Console.ReadKey();

        }
    }
}
