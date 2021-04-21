using System;
using System.Collections.Generic;

namespace Card_Shuffle
{
	class Program
	{
		static void Main(string[] args)
		{
			bool quit = false;
			Deck deck = new Deck();
			create_deck(deck);
			while (!quit)
			{
				Console.WriteLine("Would you like to\nShuffle > A\nDeal one card > B\nDeal all cards > C\nRemake a full deck > D\n Quit > E");
				string answer = Console.ReadLine().ToUpper();
				if (answer == "A")
				{
					deck.Shuffle();
				}
				else if (answer == "B")
				{
					Card current_card = deck.Deal();
					if (current_card == null)
					{

						Console.WriteLine("Deck is empty");
					}
					else
					{
						current_card._print_values();
					}

				}
				else if (answer == "C")
				{
					print_all_values(deck);
				}
				else if (answer == "D")
				{
					deck.Clear();
					create_deck(deck);
				}
				else if (answer == "E")
				{
					quit = true;
				}
			}


		}
		static void create_deck(Deck deck)
		{
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 13; j++)
				{
					Card temp_card = new Card(j, i);
					deck.card_list.Add(temp_card);

				}
			}
		}
		static void print_all_values(Deck deck)
		{
			foreach (Card card in deck.card_list)
			{
				card._print_values();
			}
		}

	}

	class Card
	{
		private int _value { get; set; }
		private string _suit { get; set; }
		private int _suit_int { get; set; }
		private string _string_value { get; set; }

		public Card(int value, int suit_int)
		{
			_value = value + 1;
			_suit_int = suit_int;
			_AssignStringValue(value, suit_int);
		}
		private void _AssignStringValue(int value, int suit_value)
		{
			string[] suits = { "Hearts", "Spades", "Diamonds", "Clubs" };
			string[] string_values = { "Ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "jack", "queen", "King" };
			_string_value = string_values[value];
			_suit = suits[suit_value];
		}
		public void _print_values()
		{
			Console.WriteLine(_string_value + " of " + _suit);
		}
	}

	class Deck
	{
		private Random random = new Random();
		public List<Card> card_list = new List<Card>(52);

		public Deck()
		{ 
			
		}


		public Card Deal()
		// pops the top item in the deck and returns it
		{
			if (IsEmpty())
			{
				return null;
			}
			Card temp = card_list[0];
			card_list.RemoveAt(0);
			return temp;
            
		}
		public bool IsEmpty()
		// returns weather the list is empty or not
		{
			if (card_list.Count == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void Shuffle()
		{
			int n = card_list.Count;
			while (n > 1)
			{
				n--;
				int random_item = random.Next(n + 1);
				Card value = card_list[random_item];
				card_list[random_item] = card_list[n];
				card_list[n] = value;

			}
		}
		public void Clear()
		{
			card_list.Clear();
		}
	}
}
