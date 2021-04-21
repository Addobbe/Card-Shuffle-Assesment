using System;

namespace Card_Shuffle
{

	class Card
	{
		private int _value;
		private string _suit;
		private string _string_value;

		public Card(int value, string suit)
		{
			_value = value;
			_suit = suit;
			_string_value = _AssignStringValue(_value);
		}
		private string _AssignStringValue(value)
		{
			string[] string_values =  ["Ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "jack", "queen", "King"];
			return string_values[_value];
		}
		public void _print_values()
		{
			Console.WriteLine(_value);
			Console.WriteLine(_suit);
			Console.WriteLine(_string_value);
		}
	}
}
