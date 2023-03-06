using System;
namespace BooleanOperators
{
	public class Functions1
	{
		public static bool DoStuff()
		{
			Console.WriteLine("Doing bingo stuff");
			return true;
		}

		public static string ToBinaryString(int value)
		{
			return Convert.ToString(value, toBase: 2).PadLeft(8, '0');
		}
	}
}

