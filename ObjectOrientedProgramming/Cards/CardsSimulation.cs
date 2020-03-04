﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CardSimulation.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------using System;
namespace ObjectOrientedProgramming.Cards
{
    using System.Text;
    using DataStructures.UnOrderedList;
/// <summary>
    /// to distribute cards to players
    /// </summary>
    public class CardsSimulation
    {
/// <summary>
        ///  method to invoke DeckOfCards class
        /// </summary>
        public static void DriverMethod()
        {
////this will create a deck of cards
            DeckOfCards deckOfCards = new DeckOfCards();
//// this will shuffle the deck of cards
            deckOfCards.Shuffle();

            Player[] players = new Player[4];
//// initializing the List and player objects to fill them further
            for (int i = 0; i < 4; i++)
            {
                players[i] = new Player();
                players[i].cards = new List<Card>();
            }