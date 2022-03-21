﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_LinkedLists
{
    // DO NOT MODIFY THIS FILE EXCEPT WHERE MARKED
    // NO NEW class fields/properties!
    class Deck
    {
        // Each Deck is effectively a doubly linked list of Card objects that it manages
        // via references to the head and tail (top and bottom) cards + a field to track
        // the current # of cards
        private Card head;
        private Card tail;
        private int count;

        /// <summary>
        /// Returns the current number of Cards
        /// </summary>
        public int Count
        {
            get { return count; }
        }

        /// <summary>
        /// Implement an indexer property for the list that correctly gets and sets 
        /// data in the node at a specific index. If the index is invalid, throw 
        /// an IndexOutOfRangeException exception. 
        /// </summary>
        public Card this[int index]
        {
            get
            {
                // TODO: IMPLEMENT THIS (but you should really implement Add and test it using the debugger first!)
                return null; // TMP so starter code compiles
            }
        }

        /// <summary>
        /// Add a new Card object (with the specified suit and rank) to the end of the list. 
        /// Increment the count and update the head and/or tail when you add the card.
        /// </summary>
        public void Add(CardSuit suit, CardRank rank)
        {
            // TODO: IMPLEMENT THIS (and test it by checking the Deck contents using the debugger!)
        }


        /// <summary>
        /// This method should utilize the “next” field of each node to print 
        /// out all of the cards in order.  This will help to test if all of 
        /// your “arrows” point to the correct “boxes”.
        /// </summary>
        public void Print()
        {
            // TODO: IMPLEMENT THIS
        }

        /// <summary>
        /// This method should utilize the “previous” field of each node to 
        /// print out all of the data in reverse order.  This will help to 
        /// test if all of your “arrows” point to the correct “boxes”.
        /// </summary>
        public void PrintReversed()
        {
            // TODO: IMPLEMENT THIS
        }

        /// <summary>
        /// This method will clear the list.  Update the count attribute, 
        /// as well as the head and tail.
        /// </summary>
        public void Clear()
        {
            // TODO: IMPLEMENT THIS
        }

        /// <summary>
        /// This method returns a deck for each player that represents the cards 
        /// in that player’s hand. All the cards in the deck need to be dealt out 
        /// to the players. All players do not need to have the same number of 
        /// cards.
        /// 
        /// Hint: Remember that while, after dealing cards in real life, the full deck
        ///         is split among the players into N smaller decks, but the total
        ///         number of cards remains the same and no cards are repeated. This
        ///         is NOT what will happen here. In order to preserve the links in the
        ///         main deck, your deal will COPY the cards as it adds them to each
        ///         player's deck!
        /// </summary>
        public List<Deck> DealPlayerHands(int playerCount)
        {
            // TODO: IMPLEMENT THIS
            return null; // TMP so starter code compiles
        }

        /// <summary>
        /// This method will remove a number of cards from the end of the list and 
        /// insert them back into the list before a certain index. This method only 
        /// has to worry about moving one group of cards in the deck. The main program 
        /// will repeatedly call this method to shuffle the entire deck.  The first 
        /// parameter is the number of cards to be removed from the end of the list. 
        /// The second parameter is the new index of the first card in the 
        /// group of cards that were moved in the list.
        /// 
        /// Notes:
        ///     - You can assume valid parameters will be give for the size of the deck.
        ///     - If you leverage your this[] get indexer, there's no need for loops here.
        /// </summary>
        public void Move(int cardsToMove, int targetIndex)
        {
            // TODO: IMPLEMENT THIS
        }
    }
}
