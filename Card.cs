using System;

public class Card
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
	}
}
