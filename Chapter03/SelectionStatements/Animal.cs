using System;
namespace SelectionStatements
{
	public class Animal
	{
		public string? Name;
		public DateTime TodaysDate;
		public byte Legs;
	}

	public class Cat : Animal
	{
		public bool IsDometic;
	}

	public class Spider : Animal
	{
		public bool IsPoisonous;
	}
}

